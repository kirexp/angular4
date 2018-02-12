using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESA.Resources;

namespace ESA.Enums {
    public enum PersonTypeEnum {
        [Display(ResourceType = typeof(CommonEnumResources), Name = "PrivatePerson")]
        PrivatePerson = 0,
        [Display(ResourceType = typeof(CommonEnumResources), Name = "LegalPerson")]
        LegalPerson = 1
    }
}
