using System.ComponentModel.DataAnnotations;
using ESA.Resources;

namespace ESA.Enums {
    public enum ReportTypeEnum {
        #region Enums for BaseRequests
        [Display(ResourceType = typeof(ReportTypeResources), Name = "RegistrationReport")]
        RegistrationReport = 0,
        [Display(ResourceType = typeof(ReportTypeResources), Name = "DocumentReceptionReport")]
        DocumentReceptionReport = 1,
        [Display(ResourceType = typeof(ReportTypeResources), Name = "ServiceCompletionReport")]
        ServiceCompletionReport = 2,
        [Display(ResourceType = typeof(ReportTypeResources), Name = "ErrorReport")]
        ErrorReport = 4,
        #endregion
        #region Enums for CitizensReseption
        [Display(ResourceType = typeof(ReportTypeResources), Name = "CitizensReseptionRecordedReport")]
        CitizensReseptionRecordedReport = 5,
        [Display(ResourceType = typeof(ReportTypeResources), Name = "CitizensReseptionDateTransferedRepor")]
        CitizensReseptionDateTransferedReport = 6,
        [Display(ResourceType = typeof(ReportTypeResources), Name = "CitizensReseptioRejectedReport")]
        CitizensReseptioRejectedReport = 7,
        #endregion
        #region Enums for DayCareQueue
        [Display(ResourceType = typeof(ReportTypeResources), Name = "DayCareQueueRegistrated")]
        DayCareQueueRegistrated = 11,
        [Display(ResourceType = typeof(ReportTypeResources), Name = "DayCareQueueDecisionReport")]
        DayCareQueueDecisionReport = 12,
        [Display(ResourceType = typeof(ReportTypeResources), Name = "DayCareQueueRemovalReport")]
        DayCareQueueRemovalReport = 13,
        [Display(ResourceType = typeof(ReportTypeResources), Name = "DayCareQueueVilagedDecisionReport")]
        DayCareQueueVilagedDecisionReport =33,
        [Display(ResourceType = typeof(ReportTypeResources), Name = "DayCareMiniCenterDecisionReport")]
        DayCareMiniCenterDecisionReport = 34,
        [Display(ResourceType = typeof(ReportTypeResources), Name = "DayCareQueuePrivateDecisionReport")]
        DayCareQueuePrivateDecisionReport = 31,
        [Display(ResourceType = typeof(ReportTypeResources), Name = "DayCareQueueChildcard")]
        DayCareQueueChildcard = 32,
        [Display(ResourceType = typeof(ReportTypeResources), Name = "DayCareQueueRemovalNotification")]
        DayCareQueueRemovalNotification = 36,
        #endregion

        [Display(ResourceType = typeof(ReportTypeResources), Name = "CertificateOfBirth")]
        CertificateOfBirthReport = 14,
        [Display(ResourceType = typeof(ReportTypeResources), Name = "CertificateOfMarriage")]
        CertificateOfMarriageReport = 15,
        [Display(ResourceType = typeof(ReportTypeResources), Name = "RealEstateCertificate")]
        RealEstateCertificate = 16,
        [Display(ResourceType = typeof(ReportTypeResources), Name = "PensionPaymentsCertificate")]
        PensionPaymentsCertificate = 17,

        #region Enums for Housing2020
        [Display(ResourceType = typeof(ReportTypeResources), Name = "RequestSummary")]
        Housing2020RequestSummary = 18,
        [Display(ResourceType = typeof(ReportTypeResources), Name = "RegistrationReport")]
        Housing2020DeliveryReport = 19,
        [Display(ResourceType = typeof(ReportTypeResources), Name = "Housing2020Report")]
        Housing2020Report = 20,
        [Display(ResourceType = typeof(ReportTypeResources), Name = "Housing2020Report")]
        Housing2020Report2 = 21,
        #endregion

        [Display(ResourceType = typeof(ReportTypeResources), Name = "TrusteeshipMatchingInstall")]
        TrusteeshipMatchingInstall = 22,
        [Display(ResourceType = typeof(ReportTypeResources), Name = "DenyNotification")]
        TrusteeshipMatchingDeny = 23,
        [Display(ResourceType = typeof(ReportTypeResources), Name = "TrusteeshipCertificatesIssueConfirm")]
        TrusteeshipCertificatesIssueConfirm = 24,
        [Display(ResourceType = typeof(ReportTypeResources), Name = "DenyNotification")]
        TrusteeshipCertificatesIssueRefuse = 25,
        [Display(ResourceType = typeof(ReportTypeResources), Name = "AllowancePaymentsMatchingInstall")]
        AllowancePaymentsMatchingInstall = 26,
        [Display(ResourceType = typeof(ReportTypeResources), Name = "DenyNotification")]
        AllowancePaymentsMatchingDeny = 27,

        [Display(ResourceType = typeof(ReportTypeResources), Name = "DenyNotification")]
        ArchiveTrancriptDeny = 28,
        [Display(ResourceType = typeof(ReportTypeResources), Name = "RequestSummary")]
        ArchiveTranscriptRequestSummary = 35,
        #region Enums for QueueToTheLand

        [Display(ResourceType = typeof(ReportTypeResources), Name = "QueueToTheLandRefused")]
        QueueToTheLandRefused = 29,
        [Display(ResourceType = typeof(ReportTypeResources), Name = "QueueToTheLandStateInQueue")]
        QueueToTheLandStateInQueue = 30,
        #endregion
        
    }
}
