using ESA.Resources;
using System.ComponentModel.DataAnnotations;

namespace ESA.Enums {
    public enum RefOccupationEnum {
        [Display(ResourceType = typeof(CommonEnumResources), Name = "None")]
        None = 0,
        [Display(ResourceType = typeof(CommonEnumResources), Name = "Working")]
        Working = 1,
        [Display(ResourceType = typeof(CommonEnumResources), Name = "Pensioner")]
        Pensioner = 2,
        [Display(ResourceType = typeof(CommonEnumResources), Name = "Disabled")]
        Disabled = 3,
        [Display(ResourceType = typeof(CommonEnumResources), Name = "Student")]
        Student = 4,
        [Display(ResourceType = typeof(CommonEnumResources), Name = "Unemployed")]
        Unemployed = 5
    }
}