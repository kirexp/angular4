using ESA.DAL.Almaty.Entities.Account;
using ESA.Enums;

namespace ESA.DAL.Almaty.Entities.ServiceSettings
{
    public class ServiceStep : IEntity
    {
        public virtual long Id { get; set; }
        public virtual ServiceEnum Service { get; set; }
        public virtual ServiceStepEnum Step { get; set; }
        //public virtual RequestStateEnum CurrentState { get; set; }
        //public virtual RequestStateEnum NextState { get; set; }
        public virtual User Executor { get; set; }
    }
}