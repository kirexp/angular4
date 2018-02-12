using ESA.Resources;
using System.ComponentModel.DataAnnotations;

namespace ESA.Enums
{
    public enum Housing2020RoomsEnum
    {
        [Display(ResourceType = typeof(Housing2020Resources), Name = "Housing2020OneRoom")]
        OneRoom = 1,
        [Display(ResourceType = typeof(Housing2020Resources), Name = "Housing2020TwoRooms")]
        TwoRooms = 2,
        [Display(ResourceType = typeof(Housing2020Resources), Name = "Housing2020ThreeRooms")]
        ThreeRooms = 3
    }
}
