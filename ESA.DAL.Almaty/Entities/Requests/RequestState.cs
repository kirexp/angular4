using System;
using ESA.DAL.Almaty.Entities.Account;
using ESA.Enums;

namespace ESA.DAL.Almaty.Entities.Requests
{
    public class RequestState : IEntity
    {
        public virtual long Id { get; set; }
        public virtual Request Request { get; set; }
        public virtual ServiceStepEnum Step { get; set; }
        public virtual RequestStateEnum State { get; set; }
        public virtual DateTime DateTime  { get; set; }
        public virtual User User { get; set; }
        public virtual string SignedXml { get; set; }
    }
}