using ESA.Resources;
using System.ComponentModel.DataAnnotations;

namespace ESA.Enums {
    public enum ProbateMinorsRequestSubTypeEnum {
        [Display(ResourceType = typeof(ProbateMinorResources), Name = "ProbMinRelNone")]
        None = 0,
        [Display(ResourceType = typeof(ProbateMinorResources), Name = "ProbMinTypeExchange")]
        Exchange = 1,
        [Display(ResourceType = typeof(ProbateMinorResources), Name = "ProbMinTypeSale")]
        Sale = 2,
        [Display(ResourceType = typeof(ProbateMinorResources), Name = "ProbMinTypeGrant")]
        Grant = 3
    }
}