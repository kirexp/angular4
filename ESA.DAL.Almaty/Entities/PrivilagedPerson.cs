using System;
using ESA.DAL.Almaty.Entities.Account;
using ESA.Enums;

namespace ESA.DAL.Almaty.Entities
{
    public class PrivilagedPerson : IEntity
    {
        public virtual long Id { get; set; }
        public virtual string Iin { get; set; }
        public virtual string LastName { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual DateTime BirthDate { get; set; }
        public virtual PrivilageTypeEnum PrivilageType { get; set; }
        public virtual string Reason { get; set; }
        public virtual DateTime BeginDate { get; set; }
        public virtual DateTime? EndDate { get; set; }
        public virtual DateTime ChangeDateTime { get; set; }
        public virtual Profile User { get; set; }
    }
}
