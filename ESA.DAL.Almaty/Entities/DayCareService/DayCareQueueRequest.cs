using System;
using System.Collections.Generic;
using ESA.DAL.Almaty.Entities.Requests;
using ESA.Enums;

namespace ESA.DAL.Almaty.Entities.DayCareService
{
    public class DayCareQueueRequest : Request
    {
        public virtual string ApplicantIin { get; set; }
        public virtual DateTime ApplicantBirthDate { get; set; }
        public virtual string ApplicantRegion { get; set; }
        public virtual string ApplicantCity { get; set; }
        public virtual string ApplicantDistrict { get; set; }
        public virtual string ApplicantStreet { get; set; }
        public virtual string ApplicantBuiling { get; set; }
        public virtual string ApplicantFlat { get; set; }
        public virtual string ApplicantEmail { get; set; }
        public virtual string ApplicantPhone { get; set; }
        public virtual string ChildIin { get; set; }
        public virtual string ChildLastName { get; set; }
        public virtual string ChildFirstName { get; set; }
        public virtual string ChildMiddleName { get; set; }
        public virtual DateTime ChildBirthDate { get; set; }
        public virtual int Year { get; set; }
        public virtual int QueueNumber { get; set; }
        //new 
        public virtual int ActualQueueNumber { get; set; }
        public virtual bool Migrated { get; set; }

        public virtual PrivilageTypeEnum Privilage { get; set; }
        public virtual DayCareQueueState DayCareState { get; set; }
        public virtual ISet<RequestHistory> History { get; set; }
        public virtual ISet<DayCareDirection> DayCareDirection { get; set; }
        public virtual string Reason { get; set; }

        public DayCareQueueRequest() {
            DayCareDirection = new HashSet<DayCareDirection>();
            History=new HashSet<RequestHistory>();
        }
    }
     
}