using ESA.Resources;
using System.ComponentModel.DataAnnotations;
namespace ESA.Enums
{
        public enum CitizensReseptionStatus
        {
            [Display(ResourceType = typeof(CitizenReceptionResources), Name = "CitResSvcOpen")]
            Opened = -1,
            [Display(ResourceType = typeof(CitizenReceptionResources), Name = "CitResSvcRegistered")]
            Registred = 0,
            [Display(ResourceType = typeof(CitizenReceptionResources), Name = "CitResSvcAccepted")]
            Accepted=1,
            [Display(ResourceType = typeof(CitizenReceptionResources), Name = "CitResSvcRejected")]
            Rejected = 2,
            [Display(ResourceType = typeof(CitizenReceptionResources), Name = "CitResSvcTransfered")]
            Transfered = 3,
            [Display(ResourceType = typeof(CitizenReceptionResources), Name = "CitResSvcDone")]
            Done=8
        }

}
