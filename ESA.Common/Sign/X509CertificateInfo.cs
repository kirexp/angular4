using System;

namespace Utils {
    public class X509CertificateInfo {
        public string Location { get; set; }
        public string Sity { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public string CommonName { get; set; }
        public string FullName { get { return string.Format("{0} {1}", CommonName, MiddleName ?? string.Empty).Trim(); } }
        public string SerialNumber { get; set; }
        public string Bin { get; set; }
        public string CompanyName { get; set; }
        public DateTime NotBefore { get; set; }
        public DateTime NotAfter { get; set; }

        public bool ValidByDate() {
            return (DateTime.Now.Date <= NotAfter.Date) && (DateTime.Now.Date >= NotBefore.Date);
        }
    }
}