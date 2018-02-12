using ESA.Resources;
using System.ComponentModel.DataAnnotations;

namespace ESA.Enums {
    public enum PrivilageTypeEnum {
        [Display(ResourceType = typeof(DayCareQueueResources), Name = "DdoPrevNotPrivilaged")]
        NotPrivilaged = 0,
        [Display(ResourceType = typeof(DayCareQueueResources), Name = "DdoPrevPrivilaged")]
        Privilaged = 1,
        [Display(ResourceType = typeof(DayCareQueueResources), Name = "DdoPrevLargeFam")]
        BigFamily = 2,
        [Display(ResourceType = typeof(DayCareQueueResources), Name = "DdoPrevInvalid")]
        Disablers = 3,
        [Display(ResourceType = typeof(DayCareQueueResources), Name = "DdoPrevMilitary")]
        Military = 4,
        [Display(ResourceType = typeof(DayCareQueueResources), Name = "DdoPrevGosOrgan")]
        GoverenmentEmpKid =5,
        [Display(ResourceType = typeof(DayCareQueueResources), Name = "DdoPrevOrphans")]
        Orphans = 6
    }
}