using ESA.Resources;
using System.ComponentModel.DataAnnotations;

namespace ESA.Enums {
    public enum ArchiveTranscriptRequestedInfoEnum {
        [Display(ResourceType = typeof(ArchiveTranscriptResources), Name = "ArchiveSvcWorkRequest")]
        ArchiveSvcWorkRequest = 1,
        [Display(ResourceType = typeof(ArchiveTranscriptResources), Name = "ArchiveSvcSalaryRequest")]
        ArchiveSvcSalaryRequest = 2,
        [Display(ResourceType = typeof(ArchiveTranscriptResources), Name = "ArchiveSvcAccidentsRequest")]
        ArchiveSvcAccidentsRequest = 3,
        [Display(ResourceType = typeof(ArchiveTranscriptResources), Name = "ArchiveSvcLearningRequest")]
        ArchiveSvcLearningRequest = 4,
        [Display(ResourceType = typeof(ArchiveTranscriptResources), Name = "ArchiveSvcCivilStatusRequest")]
        ArchiveSvcCivilStatusRequest = 5,
        [Display(ResourceType = typeof(ArchiveTranscriptResources), Name = "ArchiveSvcTechnicalDetailsRequest")]
        ArchiveSvcTechnicalDetailsRequest = 6,
        [Display(ResourceType = typeof(ArchiveTranscriptResources), Name = "ArchiveSvcAkimatDecisionsRequest")]
        ArchiveSvcAkimatDecisionsRequest = 7,
        [Display(ResourceType = typeof(ArchiveTranscriptResources), Name = "ArchiveSvcPrivatizationRequest")]
        ArchiveSvcPrivatizationRequest = 8,
        [Display(ResourceType = typeof(ArchiveTranscriptResources), Name = "ArchiveSvcLegalizationRequest")]
        ArchiveSvcLegalizationRequest = 9,
        [Display(ResourceType = typeof(ArchiveTranscriptResources), Name = "ArchiveSvcRenameRequest")]
        ArchiveSvcRenameRequest = 10,
        [Display(ResourceType = typeof(ArchiveTranscriptResources), Name = "ArchiveSvcJudgementRequest")]
        ArchiveSvcJudgementRequest = 11,
        [Display(ResourceType = typeof(ArchiveTranscriptResources), Name = "ArchiveSvcInheritanceRequest")]
        ArchiveSvcInheritanceRequest = 12,
        [Display(ResourceType = typeof(ArchiveTranscriptResources), Name = "ArchiveSvcOrphanageRequest")]
        ArchiveSvcOrphanageRequest = 13,
        [Display(ResourceType = typeof(ArchiveTranscriptResources), Name = "ArchiveSvcOthersRequest")]
        ArchiveSvcOthersRequest = 14
    }
}