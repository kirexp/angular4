using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESA.Enums
{
    public enum HistoryStepEnum
    {
        Registered=0,
        Noticed=1,
        Directed=2,
        Rejected=3,
        Out=4,
        ReturnToQueue=5,
        RemoveFromQueue=6,
        MoveToBlockList=7,
        PrivilageChanged=8
    }
}
