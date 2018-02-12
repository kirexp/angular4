using ESA.Resources;
using System.ComponentModel.DataAnnotations;

namespace ESA.Enums {
    public enum ProbateMinorsRelationTypeEnum {
        [Display(ResourceType = typeof(ProbateMinorResources), Name = "ProbMinRelNone")]
        None = 0,
        [Display(ResourceType = typeof(ProbateMinorResources), Name = "ProbMinRelNotRelated")]
        NotRelated = 1,
        [Display(ResourceType = typeof(ProbateMinorResources), Name = "ProbMinRelRelated")]
        Related = 2,
    }
}