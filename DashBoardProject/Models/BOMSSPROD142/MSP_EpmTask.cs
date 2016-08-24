namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmTask
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSP_EpmTask()
        {
            MSP_EpmAssignment = new HashSet<MSP_EpmAssignment>();
            MSP_EpmAssignmentBaseline = new HashSet<MSP_EpmAssignmentBaseline>();
            MSP_EpmAssignmentBaselineByDay = new HashSet<MSP_EpmAssignmentBaselineByDay>();
            MSP_EpmAssignmentByDay = new HashSet<MSP_EpmAssignmentByDay>();
            MSP_EpmTaskBaseline = new HashSet<MSP_EpmTaskBaseline>();
            MSP_EpmTaskBaselineByDay = new HashSet<MSP_EpmTaskBaselineByDay>();
            MSP_EpmTaskByDay = new HashSet<MSP_EpmTaskByDay>();
        }

        [Key]
        [Column(Order = 0)]
        public Guid TaskUID { get; set; }

        public Guid? TaskParentUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ProjectUID { get; set; }

        public Guid FixedCostAssignmentUID { get; set; }

        [Required]
        [StringLength(255)]
        public string TaskName { get; set; }

        public short? TaskOutlineLevel { get; set; }

        [StringLength(255)]
        public string TaskOutlineNumber { get; set; }

        public int? TaskIndex { get; set; }

        public bool? TaskIsProjectSummary { get; set; }

        public bool? TaskIsOverallocated { get; set; }

        public bool? TaskIsMilestone { get; set; }

        public bool? TaskIsCritical { get; set; }

        public bool? TaskIsSummary { get; set; }

        public decimal? TaskFixedCost { get; set; }

        public decimal? TaskActualFixedCost { get; set; }

        public decimal? TaskCost { get; set; }

        public decimal? TaskOvertimeCost { get; set; }

        public decimal? TaskActualCost { get; set; }

        public decimal? TaskActualOvertimeCost { get; set; }

        public decimal? TaskWork { get; set; }

        public decimal? TaskOvertimeWork { get; set; }

        public decimal? TaskActualWork { get; set; }

        public decimal? TaskActualOvertimeWork { get; set; }

        public decimal? TaskDurationVariance { get; set; }

        public decimal? TaskStartVariance { get; set; }

        public decimal? TaskFinishVariance { get; set; }

        public decimal? TaskTotalSlack { get; set; }

        public decimal? TaskFreeSlack { get; set; }

        public decimal? TaskDuration { get; set; }

        public decimal? TaskActualDuration { get; set; }

        public DateTime? TaskStartDate { get; set; }

        public DateTime? TaskFinishDate { get; set; }

        public DateTime? TaskDeliverableStartDate { get; set; }

        public DateTime? TaskDeliverableFinishDate { get; set; }

        public DateTime? TaskActualStartDate { get; set; }

        public DateTime? TaskActualFinishDate { get; set; }

        public short? TaskPercentCompleted { get; set; }

        public short? TaskPercentWorkCompleted { get; set; }

        public short? TaskPhysicalPercentCompleted { get; set; }

        public decimal? TaskACWP { get; set; }

        public decimal? TaskBCWP { get; set; }

        public decimal? TaskBCWS { get; set; }

        public decimal? TaskLevelingDelay { get; set; }

        public short? TaskPriority { get; set; }

        public decimal? TaskSPI { get; set; }

        public decimal? TaskTCPI { get; set; }

        public decimal? TaskVAC { get; set; }

        public DateTime? TaskDeadline { get; set; }

        public bool TaskDurationIsEstimated { get; set; }

        public decimal? TaskEAC { get; set; }

        public bool TaskIsEffortDriven { get; set; }

        public bool TaskIsExternal { get; set; }

        public bool TaskIsRecurring { get; set; }

        public decimal? TaskCostVariance { get; set; }

        public decimal? TaskCV { get; set; }

        public decimal? TaskCPI { get; set; }

        public DateTime? TaskEarlyFinish { get; set; }

        public DateTime? TaskEarlyStart { get; set; }

        public DateTime? TaskLateFinish { get; set; }

        public DateTime? TaskLateStart { get; set; }

        public decimal? TaskSV { get; set; }

        public decimal? TaskWorkVariance { get; set; }

        public bool TaskIgnoresResourceCalendar { get; set; }

        public int TaskClientUniqueId { get; set; }

        public bool TaskIsMarked { get; set; }

        [Column(TypeName = "ntext")]
        public string TaskWBS { get; set; }

        public int TaskCreatedRevisionCounter { get; set; }

        public int TaskModifiedRevisionCounter { get; set; }

        public DateTime TaskCreatedDate { get; set; }

        public DateTime TaskModifiedDate { get; set; }

        public decimal TaskBudgetCost { get; set; }

        public decimal TaskBudgetWork { get; set; }

        public decimal TaskResourcePlanWork { get; set; }

        [StringLength(255)]
        public string TaskHyperLinkFriendlyName { get; set; }

        [StringLength(255)]
        public string TaskHyperLinkAddress { get; set; }

        [StringLength(255)]
        public string TaskHyperLinkSubAddress { get; set; }

        [StringLength(255)]
        public string TaskStartDateString { get; set; }

        [StringLength(255)]
        public string TaskDurationString { get; set; }

        [StringLength(255)]
        public string TaskFinishDateString { get; set; }

        public bool TaskIsManuallyScheduled { get; set; }

        public bool TaskIsActive { get; set; }

        public Guid TaskStatusManagerUID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmAssignment> MSP_EpmAssignment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmAssignmentBaseline> MSP_EpmAssignmentBaseline { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmAssignmentBaselineByDay> MSP_EpmAssignmentBaselineByDay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmAssignmentByDay> MSP_EpmAssignmentByDay { get; set; }

        public virtual MSP_EpmProject MSP_EpmProject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmTaskBaseline> MSP_EpmTaskBaseline { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmTaskBaselineByDay> MSP_EpmTaskBaselineByDay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmTaskByDay> MSP_EpmTaskByDay { get; set; }
    }
}
