using ESA.Resources;
using System.ComponentModel.DataAnnotations;

namespace ESA.Enums {
    public enum ProcessedStateEnum {
        [Display(ResourceType = typeof(TrusteeshipResources), Name = "ProcessedStateNone")]
        None = 0,
        [Display(ResourceType = typeof(TrusteeshipResources), Name = "ProcessedStateInstall")]
        Install = 1,
        [Display(ResourceType = typeof(TrusteeshipResources), Name = "ProcessedStateDeny")]
        Deny = 2
    }
}