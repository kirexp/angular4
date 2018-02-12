using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESA.DAL.Almaty.Entities.DayCareService;
using ESA.Enums;

namespace ESA.DAL.Almaty.Entities.Requests
{
    public class RequestHistory:IEntity
    {
        public virtual long Id { get; set; }
        public virtual DayCareQueueRequest Request { get; set; }
        public virtual string  Description { get; set; }
        public virtual DateTime DateTime { get; set; }
        public virtual HistoryStepEnum HistoryStep { get; set; }

    }
}
