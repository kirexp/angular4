using System.ComponentModel.DataAnnotations;
using ESA.Resources;

namespace ESA.Enums {
    public enum UserTypeEnum {
        [Display(ResourceType = typeof(CommonUserTypeResources), Name = "None")]
        None = 0,
        [Display(ResourceType = typeof(CommonUserTypeResources), Name = "Employee")]
        Employee = 1,
        [Display(ResourceType = typeof(CommonUserTypeResources), Name = "Client")]
        Client = 2,
        [Display(ResourceType = typeof(CommonUserTypeResources), Name = "Admin")]
        Admin = 3
    }
}