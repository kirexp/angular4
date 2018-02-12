using ESA.DAL.Almaty.Entities.Account;
using ESA.Enums;

namespace ESA.DAL.Almaty.Entities.Dictionaries
{
    public class DayCare : IEntity
    {
        public virtual long Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Address { get; set; }
        public virtual string Phone { get; set; }
        public virtual User DayCareOwner { get; set; }
        public virtual FreePlaceTypeEnum DayCareType { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual string WebSite { get; set; }

    }
}
