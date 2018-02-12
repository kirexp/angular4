using System;
using ESA.DAL.Almaty.Entities.Account;
using ESA.DAL.Almaty.Entities.Dictionaries;
using ESA.Enums;

namespace ESA.DAL.Almaty.Entities.DayCareService {
    public class DayCareFreePlace : IEntity
    {
        public virtual long Id { get; set; }
        public virtual DayCare DayCare { get; set; }
        public virtual int Year { get; set; }
        public virtual FreePlaceTypeEnum FreePlaceType { get; set; }
        public virtual LanguageEnum Language { get; set; }
        public virtual int TotalCount { get; set; }
        public virtual int FreeCount { get; set; }
        public virtual DateTime CreationDateTime { get; set; }
        public virtual User User { get; set; }
        public virtual bool IsReserved { get; set; }
    }
}