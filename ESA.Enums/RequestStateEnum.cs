using ESA.Resources;
using System.ComponentModel.DataAnnotations;

namespace ESA.Enums {
    public enum RequestStateEnum {
        [Display(ResourceType = typeof(CommonReqStateResources), Name = "Created")]
        Created,
        [Display(ResourceType = typeof(CommonReqStateResources), Name = "Accepted")]
        Accepted,
        [Display(ResourceType = typeof(CommonReqStateResources), Name = "Refused")]
        Refused,
        [Display(ResourceType = typeof(CommonReqStateResources), Name = "Processed")]
        Processed,
        [Display(ResourceType = typeof(CommonReqStateResources), Name = "Confirmed")]
        Confirmed,
        [Display(ResourceType = typeof(CommonReqStateResources), Name = "Done")]
        Done,
        [Display(ResourceType = typeof(CommonReqStateResources), Name = "Error")]
        Error,
        [Display(ResourceType = typeof(CommonReqStateResources), Name = "AddInfo")]
        AddInfo
    }
}