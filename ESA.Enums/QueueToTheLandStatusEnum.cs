using ESA.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESA.Enums
{
   public enum QueueToTheLandStatusEnum {
        [Display(ResourceType = typeof(CommonEnumResources), Name = "Closed")]
        Closed = 0,
        [Display(ResourceType = typeof(CommonEnumResources), Name = "Open")]
        Opened = 1
    }
}
