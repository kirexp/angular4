using ESA.Resources;
using System.ComponentModel.DataAnnotations;

namespace ESA.Enums {
    public enum ProbateMinorsRequestTypeEnum {
        [Display(ResourceType = typeof(ProbateMinorResources), Name = "ProbMinRelNone")]
        None = 0,
        [Display(ResourceType = typeof(ProbateMinorResources), Name = "ProbMinToPensFund")]
        ToPensionFound = 1,
        [Display(ResourceType = typeof(ProbateMinorResources), Name = "ProbMinToMvd")]
        ToMvd = 2
    }
}