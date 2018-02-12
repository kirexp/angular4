using System.ComponentModel.DataAnnotations;
using ESA.Resources;

namespace ESA.Enums
{
    public enum LanguageEnum
    {
        [Display(ResourceType = typeof(CommonEnumResources), Name = "LanguageКz")]
        Kk = 0,
        [Display(ResourceType = typeof(CommonEnumResources), Name = "LanguageRu")]
        Ru = 1,
        [Display(ResourceType = typeof(CommonEnumResources), Name = "LanguageEn")]
        En = 2
    }
}