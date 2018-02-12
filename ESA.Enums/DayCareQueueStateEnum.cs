using ESA.Resources;
using System.ComponentModel.DataAnnotations;

namespace ESA.Enums {
    public enum DayCareQueueStateEnum {
        None=0,
        [Display(ResourceType = typeof(DayCareQueueResources), Name = "DdoStateInQueue")]
        InQueue = 1,
        [Display(ResourceType = typeof(DayCareQueueResources), Name = "DdoStateNoticed")]
        Noticed = 2,
        [Display(ResourceType = typeof(DayCareQueueResources), Name = "DdoStateDirected")]
        Directed = 3,
        [Display(ResourceType = typeof(DayCareQueueResources), Name = "DdoStateBlocked")]
        Blocked = 4,
        [Display(ResourceType = typeof(DayCareQueueResources), Name = "DdoStateRemoved")]
        Removed = 5
    }
}