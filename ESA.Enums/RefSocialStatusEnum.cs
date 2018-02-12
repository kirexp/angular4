using System.ComponentModel.DataAnnotations;
using ESA.Resources;

namespace ESA.Enums {
    public enum RefSocialStatusEnum {
        [Display(ResourceType = typeof(CommonEnumResources), Name = "Working")]
        Working = 1,
        [Display(ResourceType = typeof(CommonEnumResources), Name = "Pensioner")]
        Pensioner = 2,
        [Display(ResourceType = typeof(CommonEnumResources), Name = "Disabled")]
        Disabled = 3,
        [Display(ResourceType = typeof(CommonEnumResources), Name = "Student")]
        Student = 4,
        [Display(ResourceType = typeof(CommonEnumResources), Name = "Learner")]
        Learner = 5,
        [Display(ResourceType = typeof(CommonEnumResources), Name = "PreschoolChild")]
        PreschoolChild = 6,
        [Display(ResourceType = typeof(CommonEnumResources), Name = "Unemployed")]
        Unemployed = 7
    }
}