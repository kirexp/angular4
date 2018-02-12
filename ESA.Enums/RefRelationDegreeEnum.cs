using System.ComponentModel.DataAnnotations;
using ESA.Resources;

namespace ESA.Enums {
    public enum RefRelationDegreeEnum {
        [Display(ResourceType = typeof(CommonFamRelationsResources), Name = "NoRelationship")]
        NoRelationship = 0,
        [Display(ResourceType = typeof(CommonFamRelationsResources), Name = "Granddad")]
        Granddad = 1,
        [Display(ResourceType = typeof(CommonFamRelationsResources), Name = "Grandmother")]
        Grandmother = 2,
        [Display(ResourceType = typeof(CommonFamRelationsResources), Name = "Aunt")]
        Aunt = 3,
        [Display(ResourceType = typeof(CommonFamRelationsResources), Name = "Uncle")]
        Uncle = 4,
        [Display(ResourceType = typeof(CommonFamRelationsResources), Name = "Brother")]
        Brother = 5,
        [Display(ResourceType = typeof(CommonFamRelationsResources), Name = "Sister")]
        Sister = 6
    }
}