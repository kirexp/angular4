using ESA.DAL.Almaty.Entities.Account;
using ESA.Enums;

namespace ESA.DAL.Almaty.Entities.ServiceSettings
{
    public class ServiceEmployee : IEntity
    {
        public virtual long Id { get; set; }
        public virtual ServiceEnum Service { get; set; }
        public virtual User Executor { get; set; }
    }
}