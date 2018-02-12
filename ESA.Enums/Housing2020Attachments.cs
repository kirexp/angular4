using System.ComponentModel.DataAnnotations;
using ESA.Resources;

namespace ESA.Enums {
    public enum Housing2020Attachments {
        [Display(ResourceType = typeof(Housing2020Resources), Name = "Housing2020AttIncomesDocument")]
        IncomesDocument = 1,
        [Display(ResourceType = typeof(Housing2020Resources), Name = "Housing2020AttWorkplaceDocument")]
        WorkplaceDocument = 2,
        [Display(ResourceType = typeof(Housing2020Resources), Name = "Housing2020AttMarriageDocument")]
        MarriageDocument = 3,
        [Display(ResourceType = typeof(Housing2020Resources), Name = "Housing2020AttDeathDocument")]
        DeathDocument = 4,
        [Display(ResourceType = typeof(Housing2020Resources), Name = "Housing2020AttBirthDocument")]
        BirthDocument = 5
    }
}