using System;
using ESA.Enums;

namespace ESA.DAL.Almaty.Entities.DayCareService
{
   public class DayCareQueueState:IEntity
    {
        public virtual long Id { get; set; }
        public virtual DayCareQueueRequest Request { get; set; }
        public virtual DateTime? NotificationDateTime { get; set; }
        // 
        public virtual DateTime? FirstCheckedDate { get; set; }
        public virtual DateTime? StateInQueueDateTime { get; set; }
        public virtual DayCareQueueStateEnum? StateInQueue { get; set; }
        public virtual DateTime? LastApprovalDate { get; set; }
        public virtual bool WasBlocked { get; set; }
        public virtual DateTime? BlockDateTime { get; set; }
        public virtual DayCareDirection  ActiveDirection { get; set; }
        public virtual byte BlockCount { get; set; }

    }
}
