using System.ComponentModel.DataAnnotations;
using ESA.Resources;

namespace ESA.Enums {
    public enum ServiceEnum {

        [Display(ResourceType = typeof(ServiceNameResources), Name = "DayCareQueue")]
        DayCareQueue = 1,
        [Display(ResourceType = typeof(ServiceNameResources), Name = "Trusteeship")]
        Trusteeship = 2,
        [Display(ResourceType = typeof(ServiceNameResources), Name = "CitizensInNeedHousing")]
        CitizensInNeedHousing = 3,
        [Display(ResourceType = typeof(ServiceNameResources), Name = "ReceptionOfCitizens")]
        ReceptionOfCitizens = 4,
        [Display(ResourceType = typeof(ServiceNameResources), Name = "Housing2020")]
        Housing2020 = 5,
        [Display(ResourceType = typeof(ServiceNameResources), Name = "QueueToTheLand")]
        QueueToTheLand = 6,
        [Display(ResourceType = typeof(ServiceNameResources), Name = "HousingAssistance")]
        HousingAssistance = 7,
        [Display(ResourceType = typeof(ServiceNameResources), Name = "UnemployedRegistration")]
        UnemployedRegistration = 8,
        [Display(ResourceType = typeof(ServiceNameResources), Name = "ProbateMinorsToMVD")]
        ProbateMinors = 9,
        [Display(ResourceType = typeof(ServiceNameResources), Name = "ProbateMinorsToPensionFound")]
        ProbateMinorsToPensionFound = 10,
        [Display(ResourceType = typeof(ServiceNameResources), Name = "TrusteeshipCertificatesIssue")]
        TrusteeshipCertificatesIssue = 11,
        [Display(ResourceType = typeof(ServiceNameResources), Name = "AllowancePayments")]
        AllowancePayments = 12,
        [Display(ResourceType = typeof(ServiceNameResources), Name = "ArchiveTranscript")]
        ArchiveTranscript = 13
    }
}
