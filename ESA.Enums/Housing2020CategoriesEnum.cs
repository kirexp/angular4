using System.ComponentModel.DataAnnotations;
using ESA.Resources;

namespace ESA.Enums {
    public enum Housing2020CategoriesEnum {
        [Display(ResourceType = typeof(Housing2020Resources), Name = "Housing2020CatOrphan")]
        Category1 = 1,
        [Display(ResourceType = typeof(Housing2020Resources), Name = "Housing2020CatAfgan")]
        Category2 = 2,
        [Display(ResourceType = typeof(Housing2020Resources), Name = "Housing2020CatChernobyl")]
        Category3 = 3,
        [Display(ResourceType = typeof(Housing2020Resources), Name = "Housing2020CatInvalid")]
        Category4 = 4,
        [Display(ResourceType = typeof(Housing2020Resources), Name = "Housing2020CatPensioner")]
        Category5 = 5,
        [Display(ResourceType = typeof(Housing2020Resources), Name = "Housing2020CatOralman")]
        Category6 = 6,
        [Display(ResourceType = typeof(Housing2020Resources), Name = "Housing2020CatTehnogen")]
        Category7 = 7,
        [Display(ResourceType = typeof(Housing2020Resources), Name = "Housing2020CatEcolog")]
        Category8 = 8,
        [Display(ResourceType = typeof(Housing2020Resources), Name = "Housing2020CatFire")]
        Category9 = 9,
        [Display(ResourceType = typeof(Housing2020Resources), Name = "Housing2020CatLargeFam")]
        Category10 = 10,
        [Display(ResourceType = typeof(Housing2020Resources), Name = "Housing2020CatIncompFam")]
        Category11 = 11,
        [Display(ResourceType = typeof(Housing2020Resources), Name = "Housing2020CatGos")]
        Category12 = 12,
        [Display(ResourceType = typeof(Housing2020Resources), Name = "Housing2020CatMilitary")]
        Category13 = 13,
        [Display(ResourceType = typeof(Housing2020Resources), Name = "Housing2020CatBudget")]
        Category14 = 14,
        [Display(ResourceType = typeof(Housing2020Resources), Name = "Housing2020CatVov")]
        Category15 = 15
    }
}
