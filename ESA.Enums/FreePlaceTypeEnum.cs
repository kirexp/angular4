using System.ComponentModel.DataAnnotations;
using ESA.Resources;

namespace ESA.Enums {
    public enum FreePlaceTypeEnum {
        [Display(ResourceType = typeof(DayCareQueueResources), Name = "DdoTypeGovernment")]
        Goverment = 0,
        [Display(ResourceType = typeof(DayCareQueueResources), Name = "DdoTypePrivacy")]
        Privacy = 1,
        [Display(ResourceType = typeof(DayCareQueueResources), Name = "DdoTypeVillaged")]
        Villaged = 2,
        [Display(ResourceType = typeof(DayCareQueueResources), Name = "DdoTypeMiniCenters")]
        MiniCenters=3
    }
}