using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESA.Resources;

namespace ESA.Enums {
    public enum ArchiveTranscriptAttachmentsEnum {
        [Display(ResourceType = typeof(ArchiveTranscriptResources), Name = "ScanOfIdentification")]
        ScanOfIdentification = 1,
        [Display(ResourceType = typeof(CommonEnumResources), Name = "OtherDocuments")]
        OtherDocuments = 2
    }
}
