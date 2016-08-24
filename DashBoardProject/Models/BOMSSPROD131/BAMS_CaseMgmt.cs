namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BAMS_CaseMgmt
    {
        [Key]
        [StringLength(31)]
        public string EFOLDERID { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(40)]
        public string Department { get; set; }

        [StringLength(20)]
        public string SubmitterFacility { get; set; }

        [Column(TypeName = "ntext")]
        public string Justification { get; set; }

        [Column(TypeName = "ntext")]
        public string BusinessNeed { get; set; }

        [Column(TypeName = "ntext")]
        public string Requirements { get; set; }

        [StringLength(250)]
        public string CCList { get; set; }

        [StringLength(31)]
        public string forwardStage { get; set; }

        [StringLength(250)]
        public string BillTo { get; set; }

        [StringLength(2000)]
        public string AffectedSites { get; set; }

        public int? EffortEstimate { get; set; }

        [StringLength(250)]
        public string Classification { get; set; }

        [Column(TypeName = "ntext")]
        public string TestCases { get; set; }

        [StringLength(250)]
        public string PrimaryStakeholder { get; set; }

        [Column(TypeName = "ntext")]
        public string EffortBreakdown { get; set; }

        public int? Phase { get; set; }

        [StringLength(100)]
        public string pRouter { get; set; }

        [Column(TypeName = "ntext")]
        public string NextSteps { get; set; }

        public int? bitOptions { get; set; }

        [StringLength(250)]
        public string pSiteCoordinator { get; set; }

        public int? FsrbID { get; set; }

        public int? legacyID { get; set; }

        public int? RBRank { get; set; }

        public DateTime? RequiredCompletionDate { get; set; }

        public int? StrategicDirectiveID { get; set; }

        [Column(TypeName = "ntext")]
        public string GeneralNotes { get; set; }

        public int? FactorySystemID { get; set; }

        [StringLength(50)]
        public string CQID { get; set; }

        public int? FsrbRank { get; set; }

        [StringLength(250)]
        public string ApprovalType { get; set; }

        [StringLength(250)]
        public string HoldReason { get; set; }

        [Column(TypeName = "ntext")]
        public string HoldComment { get; set; }

        public short? bRequirementsComplete { get; set; }

        public short? bTestCasesComplete { get; set; }

        public short? bHoursEstimateComplete { get; set; }

        [StringLength(250)]
        public string HoldReleaseComment { get; set; }

        [StringLength(50)]
        public string SubmitterUsername { get; set; }

        [Column(TypeName = "ntext")]
        public string RBRankComments { get; set; }

        [Column(TypeName = "ntext")]
        public string memTechnicalDetails { get; set; }

        [StringLength(20)]
        public string legacyERSID { get; set; }

        public short? bLeadOverride { get; set; }

        [StringLength(250)]
        public string force_to_stage { get; set; }

        [StringLength(50)]
        public string JIRA_Key { get; set; }

        public int? FSPriority { get; set; }

        public double? ActualHours { get; set; }

        [StringLength(250)]
        public string pCoreApprover { get; set; }

        [Column(TypeName = "ntext")]
        public string Quality { get; set; }

        [Column(TypeName = "ntext")]
        public string CycleTime { get; set; }

        [Column(TypeName = "ntext")]
        public string Cost { get; set; }

        [Column(TypeName = "ntext")]
        public string NPICadence { get; set; }

        public short? QualityComplete { get; set; }

        public short? CycleTimeComplete { get; set; }

        public short? CostComplete { get; set; }

        public short? NPICadenceComplete { get; set; }
    }
}
