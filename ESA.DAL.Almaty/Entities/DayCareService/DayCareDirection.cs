using System;
using ESA.DAL.Almaty.Entities.Dictionaries;
using ESA.DAL.Almaty.Entities.Requests;
using ESA.Enums;

namespace ESA.DAL.Almaty.Entities.DayCareService
{
    public class DayCareDirection : IEntity
    {
        public DayCareDirection()
        {
            //DayCareQueueRequests = new HashSet<DayCareQueueRequest>();
        }
        public virtual long Id { get; set; }
        public virtual DayCare DayCare { get; set; }
        public virtual DayCareFreePlace DayCareFreePlace { get; set; }
        public virtual string Number { get; set; }
        public virtual DateTime DateTime { get; set; }
        public virtual FreePlaceTypeEnum DirectionType { get; set; }
        public virtual long DirectedYear { get; set; }
        public virtual LanguageEnum DirectedLanguage { get; set; }
        public virtual RequestDocument RequestDocument { get; set; }
        public virtual DayCareQueueRequest DayCareQueueRequest { get; set; }
        public virtual DirectionState DirectionState { get; set; }
    }
}