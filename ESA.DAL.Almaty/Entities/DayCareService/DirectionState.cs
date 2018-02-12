using System;
using ESA.Enums;

namespace ESA.DAL.Almaty.Entities.DayCareService
{
    public class DirectionState:IEntity{
        public virtual long Id { get; set; }
        public virtual string Reason { get; set; }
        public virtual DirectionStatus Status { get; set; }
        public virtual DateTime CreationDateTime { get; set; }
        public virtual DateTime? ComplitionDateTime { get; set; }
        public virtual DayCareDirection Direction { get; set; }
        public virtual string Signature { get; set; }
        public virtual DateTime LastChangeDate { get; set; }

        public DirectionState() {
            this.LastChangeDate = DateTime.Now;
        }
    }
}
