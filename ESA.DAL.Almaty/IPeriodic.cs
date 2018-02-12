using System;

namespace ESA.DAL.Almaty
{
    public interface IPeriodic
    {
        DateTime BeginDate { get; set; }
        DateTime? EndDate { get; set; }

        bool IsActual(DateTime? dateTime = null);
    }
}
