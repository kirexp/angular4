using System.ComponentModel.DataAnnotations;
using ESA.Resources;

namespace ESA.Enums {
    public enum RefSexEnum {
        [Display(ResourceType = typeof(CommonEnumResources), Name = "Male")]
        Male = 1,
        [Display(ResourceType = typeof(CommonEnumResources), Name = "Female")]
        Female = 2
    }
}