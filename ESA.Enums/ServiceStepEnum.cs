using ESA.Resources;
using System.ComponentModel.DataAnnotations;

namespace ESA.Enums
{
    public enum ServiceStepEnum
    {
        [Display(ResourceType = typeof(CommonSvcStepResources), Name = "Creation")]
        Creation = 0,
        [Display(ResourceType = typeof(CommonSvcStepResources), Name = "Reception")]
        Reception = 1,
        [Display(ResourceType = typeof(CommonSvcStepResources), Name = "Decision")]
        Decision = 2,
        [Display(ResourceType = typeof(CommonSvcStepResources), Name = "Confirmation")]
        Confirmation = 3,
        [Display(ResourceType = typeof(CommonSvcStepResources), Name = "Completion")]
        Completion = 4
    }
}