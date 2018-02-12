using ESA.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESA.Enums
{
    public enum QueueToTheLandAttachments
    {
        [Display(ResourceType = typeof(CommonEnumResources), Name = "CopyOfIdentification")]
        Identification = 1,
        [Display(ResourceType = typeof(CommonEnumResources), Name = "OtherDocuments")]
        Others = 2,
    }
}
