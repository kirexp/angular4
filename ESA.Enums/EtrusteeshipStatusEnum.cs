using System.ComponentModel.DataAnnotations;
using ESA.Resources;

namespace ESA.Enums {
    public enum EtrusteeshipStatusEnum {
        [Display(ResourceType = typeof(EtrusteeshipResources), Name = "EtrustNone")]
        None = 0,
        [Display(ResourceType = typeof(EtrusteeshipResources), Name = "EtrustInProcess")]
        InProcess = 1,
        [Display(ResourceType = typeof(EtrusteeshipResources), Name = "EtrustCompleted")]
        Completed = 2
    }
}