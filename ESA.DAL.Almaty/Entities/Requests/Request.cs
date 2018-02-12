using System;
using System.Collections.Generic;
using ESA.DAL.Almaty.Entities.Account;
using ESA.Enums;

namespace ESA.DAL.Almaty.Entities.Requests
{
    public class Request : IRequest
    {
        public Request()
        {
            RequestStates = new HashSet<RequestState>();
            RequestAttachments = new HashSet<RequestAttachment>();
            RequestDocuments = new HashSet<RequestDocument>();   
        }

        public virtual long Id { get; set; }
        public virtual ServiceEnum Service { get; set; }
        public virtual string RequestNumber { get; set; }
        public virtual string ConNumber { get; set; }
        public virtual string PepNumber { get; set; }

        public virtual string ApplicantLastName { get; set; }
        public virtual string ApplicantFirstName { get; set; }
        public virtual string ApplicantMiddleName { get; set; }

        public virtual User Registrator { get; set; }
        public virtual RequestStateEnum State { get; set; }
        public virtual DateTime StateDateTime { get; set; }
        public virtual DateTime CreationDateTime { get; set; }
        public virtual string SignedXml { get; set; }

        public virtual ISet<RequestState> RequestStates { get; set; }
        public virtual ISet<RequestAttachment> RequestAttachments { get; set; }
        public virtual ISet<RequestDocument> RequestDocuments { get; set; }

        public virtual Profile Applicant { get; set; }
    }
}
