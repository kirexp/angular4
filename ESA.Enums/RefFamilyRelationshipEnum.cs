using ESA.Resources;
using System.ComponentModel.DataAnnotations;

namespace ESA.Enums {
    public enum RefFamilyRelationshipEnum {
        [Display(ResourceType = typeof(CommonFamRelationsResources), Name = "Spouse")]
        Spouse = 1,
        [Display(ResourceType = typeof(CommonFamRelationsResources), Name = "Father")]
        Father = 2,
        [Display(ResourceType = typeof(CommonFamRelationsResources), Name = "Mother")]
        Mother = 3,
        [Display(ResourceType = typeof(CommonFamRelationsResources), Name = "Brother")]
        Brother = 4,
        [Display(ResourceType = typeof(CommonFamRelationsResources), Name = "Sister")]
        Sister = 5,
        [Display(ResourceType = typeof(CommonFamRelationsResources), Name = "Daughter")]
        Daughter = 6,
        [Display(ResourceType = typeof(CommonFamRelationsResources), Name = "Son")]
        Son = 7
    }
}