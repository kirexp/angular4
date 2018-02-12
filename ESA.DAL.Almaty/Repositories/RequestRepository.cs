using System;
using ESA.DAL.Almaty.Entities.Account;
using ESA.DAL.Almaty.Entities.Requests;
using ESA.Enums;

namespace ESA.DAL.Almaty.Repositories {
    public class RequestRepository<T> : Repository<T> where T : Request, new() {
        public RequestRepository(Repository repository) : base(repository) { }

        public RequestRepository() { }

        public T CreateNew(long userId, ServiceEnum service, string format, int lastRequestCount = 0) {
            var request = new T();
            var now = DateTime.Now;
            var state = new RequestState {
                Request = request,
                Step = ServiceStepEnum.Creation,
                User = this.Load<User>(userId),
                DateTime = now,
                State = RequestStateEnum.Created
            };
            request.State = state.State;
            request.RequestStates.Add(state);
            request.StateDateTime = state.DateTime;
            request.CreationDateTime = now;

            var number = this.Count(x => x.CreationDateTime.Year == now.Year) + 1 + lastRequestCount;
            request.RequestNumber = string.Format(format, now.Year, number.ToString("00000"));
            request.Service = service;
            request.Registrator = this.Load<User>(userId);
            request.Applicant = request.Registrator.Profile;


            var document = new RequestDocument() {
                Request = request,
                CreationDate = DateTime.Now,
                ReportType = ReportTypeEnum.RegistrationReport
            };
            request.RequestDocuments.Add(document);
            return request;
        }

        public void ChangeNullableType() {
            try {
                Session.CreateSQLQuery("alter table [dbo].[Request] alter column [ApplicantLastName] nvarchar(max) NULL").UniqueResult();
                Session.CreateSQLQuery("alter table [dbo].[Request] alter column [ApplicantFirstName] nvarchar(max) NULL").UniqueResult();
            }
            catch (Exception) {
            }
        }
    }
}