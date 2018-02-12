﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ESA.Common {
    public class ParallelEmailSender {
        private readonly string _mailAddress;
        private readonly string _mailHost;
        private readonly string _mailCredentialsUserName;
        private readonly string _mailCredentialsPassword;
        private readonly bool _mailSslEnabled;
        private const string HmtlTemplate =
            "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0 Transitional//EN\"><HTML><HEAD><META http-equiv=Content-Type content=\"text/html; charset=UTF-8\"></HEAD><BODY><DIV>{0}</DIV></BODY></HTML>";

        private const int _clientcount = 10;
        private SmtpClient[] _smtpClients = new SmtpClient[_clientcount + 1];
        private CancellationTokenSource _cancelToken;

        public ParallelEmailSender()
            : this(
                ConfigurationManager.AppSettings["MailHost"],
                ConfigurationManager.AppSettings["MailCredentialsUserName"],
                ConfigurationManager.AppSettings["MailCredentialsPassword"],
                ConfigurationManager.AppSettings["MailAddress"],
                bool.Parse(ConfigurationManager.AppSettings["MailSslEnabled"])) {
        }

        public ParallelEmailSender(string host, string userName, string password, string mailAddress, bool sslEnabled) {
            _mailAddress = mailAddress;
            _mailHost = host;
            _mailCredentialsUserName = userName;
            _mailCredentialsPassword = password;
            _mailSslEnabled = sslEnabled;

            if (string.IsNullOrEmpty(_mailAddress) || string.IsNullOrEmpty(_mailHost) ||
                string.IsNullOrEmpty(_mailCredentialsUserName) || string.IsNullOrEmpty(_mailCredentialsPassword))
                throw new ConfigurationErrorsException("SMTP сервис не сконфигурирован.");

            for (int i = 0; i <= _clientcount; i++) {
                try {
                    SmtpClient _client = new SmtpClient() {
                        Host = _mailHost,
                        EnableSsl = _mailSslEnabled,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(_mailCredentialsUserName, _mailCredentialsPassword),
                        DeliveryMethod = SmtpDeliveryMethod.Network
                    };
                    _smtpClients[i] = _client;
                }
                catch (Exception ex) {
                    GenLogger.Error("Ошибка при инициализации SMTP", ex);
                }
            }
        }

        public void ParallelSending(List<EmailDto> data) {
            try {
                ParallelOptions po = new ParallelOptions();
                _cancelToken = new CancellationTokenSource();
                po.CancellationToken = _cancelToken.Token;
                po.MaxDegreeOfParallelism = System.Environment.ProcessorCount*2;
                try {
                    Parallel.ForEach(data, po, (EmailDto dataobject) => {
                        try {
                            MailMessage msg = new MailMessage() {
                                Subject = dataobject.Subject,
                                From = new MailAddress(_mailAddress),
                                IsBodyHtml = true,
                                BodyEncoding = Encoding.UTF8
                            };
                            var mimeType = new ContentType("text/html");
                            var alternate = AlternateView.CreateAlternateViewFromString(string.Format(HmtlTemplate, dataobject.Body),
                                mimeType);
                            msg.Body = dataobject.Body;
                            msg.Priority = MailPriority.Normal;
                            msg.AlternateViews.Add(alternate);
                            msg.To.Add(new MailAddress(dataobject.To));
                            Console.WriteLine("Start msg " + dataobject.Subject);
                            SendEmail(msg);
                            Console.WriteLine("End msg " + dataobject.Subject);

                        }
                        catch (Exception ex) {
                            GenLogger.Error("Ошибка при параллельной рассылке сообщений", ex);
                        }
                    });
                }
                catch (OperationCanceledException e) {
                    GenLogger.Error("Ошибка при отмене параллельной рассылки", e);
                }
            }
            finally {
                disposeSMTPClients();
            }
        }

        private void SendEmail(MailMessage msg) {
            try {
                bool _gotlocked = false;
                while (!_gotlocked) {
                    for (int i = 0; i <= _clientcount; i++) {
                        if (Monitor.TryEnter(_smtpClients[i])) {
                            try {
                                GenLogger.Debug(string.Format("НАЧАЛО ОТПРАВКИ. Email: {0}, Host: {1}, SSL: {2}",
                                    msg.To, _mailHost, _mailSslEnabled));

                                _smtpClients[i].Send(msg);

                                GenLogger.Debug(string.Format("КОНЕЦ ОТПРАВКИ. Email: {0}, Host: {1}, SSL: {2}",
                                    msg.To, _mailHost, _mailSslEnabled));
                            }
                            catch (Exception ex) {
                                GenLogger.Error(string.Format("ОШИБКА ОТПРАВКИ. Email: {0}, Host: {1}, SSL: {2}", msg.To,
                                    _mailHost, _mailSslEnabled));
                            }
                            finally {
                                Monitor.Exit(_smtpClients[i]);
                            }
                            _gotlocked = true;
                            break;
                        }
                    }
                    Thread.Sleep(1);
                }
            }
            finally {
                msg.Dispose();
            }
        }

        public void CancelEmailRun() {
            _cancelToken.Cancel();
        }

        private void disposeSMTPClients() {
            for (int i = 0; i <= _clientcount; i++) {
                try {
                    _smtpClients[i].Dispose();
                }
                catch (Exception ex) {
                    //Log Exception
                }
            }
        }
    }

    public class EmailDto {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}