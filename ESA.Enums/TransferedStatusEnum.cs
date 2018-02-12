using System.ComponentModel.DataAnnotations;
using ESA.Resources;

namespace ESA.Enums
{
    public enum TimeTransfered
    {
        [Display(ResourceType = typeof(CitizenReceptionResources), Name = "CitResSvcTransfered")]
        Transfered = 0,
        [Display(ResourceType = typeof(CitizenReceptionResources), Name = "CitResSvcNotTransfered")]
        DontTransfered = 1
    }
}
