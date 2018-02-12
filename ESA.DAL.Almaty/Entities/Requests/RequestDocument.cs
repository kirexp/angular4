using System;
using ESA.Enums;

namespace ESA.DAL.Almaty.Entities.Requests
{
   public class RequestDocument : IEntity
    {
        public virtual long Id { get; set; }
        public virtual Request Request { get; set; }
        public virtual ReportTypeEnum ReportType { get; set; }
        public virtual DateTime CreationDate { get; set; }
        public virtual string Signature { get; set; }
        public virtual string InitialValue { get; set; }
    }
}
