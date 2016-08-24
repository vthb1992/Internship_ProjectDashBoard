namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmTask_UserView
    {
        public Guid? TaskUID { get; set; }

        public Guid? TaskParentUID { get; set; }

        public Guid? ProjectUID { get; set; }

        public Guid? FixedCostAssignmentUID { get; set; }

        [StringLength(255)]
        public string TaskName { get; set; }

        public int? TaskIndex { get; set; }

        public bool? TaskIsOverallocated { get; set; }

        public bool? TaskIsProjectSummary { get; set; }

        public short? TaskOutlineLevel { get; set; }

        [StringLength(255)]
        public string TaskOutlineNumber { get; set; }

        [Column("TaskIsMilestone ")]
        public bool? TaskIsMilestone_ { get; set; }

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

        [StringLength(255)]
        public string TaskDurationString { get; set; }

        public DateTime? TaskStartDate { get; set; }

        public DateTime? TaskFinishDate { get; set; }

        [StringLength(255)]
        public string TaskStartDateString { get; set; }

        public DateTime? TaskDeliverableStartDate { get; set; }

        public DateTime? TaskDeliverableFinishDate { get; set; }

        [StringLength(255)]
        public string TaskFinishDateString { get; set; }

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

        public bool? TaskDurationIsEstimated { get; set; }

        public decimal? TaskEAC { get; set; }

        public bool? TaskIsEffortDriven { get; set; }

        public bool? TaskIsExternal { get; set; }

        public bool? TaskIsRecurring { get; set; }

        public decimal? TaskCostVariance { get; set; }

        public decimal? TaskCV { get; set; }

        public decimal? TaskCPI { get; set; }

        public DateTime? TaskEarlyFinish { get; set; }

        public DateTime? TaskEarlyStart { get; set; }

        public DateTime? TaskLateFinish { get; set; }

        public DateTime? TaskLateStart { get; set; }

        public decimal? TaskSV { get; set; }

        public decimal? TaskWorkVariance { get; set; }

        public bool? TaskIgnoresResourceCalendar { get; set; }

        public int? TaskClientUniqueId { get; set; }

        public bool? TaskIsMarked { get; set; }

        [Column(TypeName = "ntext")]
        public string TaskWBS { get; set; }

        public int? TaskCreatedRevisionCounter { get; set; }

        public int? TaskModifiedRevisionCounter { get; set; }

        public bool? TaskIsActive { get; set; }

        public DateTime? TaskCreatedDate { get; set; }

        public DateTime? TaskModifiedDate { get; set; }

        public bool? TaskIsManuallyScheduled { get; set; }

        public decimal? TaskBudgetCost { get; set; }

        public decimal? TaskBudgetWork { get; set; }

        public decimal? TaskResourcePlanWork { get; set; }

        [StringLength(255)]
        public string TaskHyperLinkFriendlyName { get; set; }

        [StringLength(255)]
        public string TaskHyperLinkAddress { get; set; }

        [StringLength(255)]
        public string TaskHyperLinkSubAddress { get; set; }

        public Guid? TaskStatusManagerUID { get; set; }

        public decimal? TaskRegularCost { get; set; }

        public decimal? TaskRemainingCost { get; set; }

        public decimal? TaskRemainingOvertimeCost { get; set; }

        public decimal? TaskActualRegularCost { get; set; }

        public decimal? TaskRemainingRegularCost { get; set; }

        public decimal? TaskRegularWork { get; set; }

        public decimal? TaskRemainingWork { get; set; }

        public decimal? TaskRemainingOvertimeWork { get; set; }

        public decimal? TaskActualRegularWork { get; set; }

        public decimal? TaskRemainingRegularWork { get; set; }

        public decimal? TaskRemainingDuration { get; set; }

        public decimal? TaskCVP { get; set; }

        public decimal? TaskSVP { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TaskCount { get; set; }

        public decimal? TaskBaseline0Cost { get; set; }

        public decimal? TaskBaseline0FixedCost { get; set; }

        public decimal? TaskBaseline0Work { get; set; }

        public decimal? TaskBaseline0BudgetCost { get; set; }

        public decimal? TaskBaseline0BudgetWork { get; set; }

        public DateTime? TaskBaseline0StartDate { get; set; }

        [StringLength(255)]
        public string TaskBaseline0StartDateString { get; set; }

        public DateTime? TaskBaseline0FinishDate { get; set; }

        [StringLength(255)]
        public string TaskBaseline0FinishDateString { get; set; }

        public DateTime? TaskBaseline0DeliverableStartDate { get; set; }

        public DateTime? TaskBaseline0DeliverableFinishDate { get; set; }

        public decimal? TaskBaseline0Duration { get; set; }

        [StringLength(255)]
        public string TaskBaseline0DurationString { get; set; }

        public decimal? TaskBaseline1Cost { get; set; }

        public decimal? TaskBaseline1FixedCost { get; set; }

        public decimal? TaskBaseline1Work { get; set; }

        public decimal? TaskBaseline1BudgetCost { get; set; }

        public decimal? TaskBaseline1BudgetWork { get; set; }

        public DateTime? TaskBaseline1StartDate { get; set; }

        [StringLength(255)]
        public string TaskBaseline1StartDateString { get; set; }

        public DateTime? TaskBaseline1FinishDate { get; set; }

        [StringLength(255)]
        public string TaskBaseline1FinishDateString { get; set; }

        public DateTime? TaskBaseline1DeliverableStartDate { get; set; }

        public DateTime? TaskBaseline1DeliverableFinishDate { get; set; }

        public decimal? TaskBaseline1Duration { get; set; }

        [StringLength(255)]
        public string TaskBaseline1DurationString { get; set; }

        public decimal? TaskBaseline2Cost { get; set; }

        public decimal? TaskBaseline2FixedCost { get; set; }

        public decimal? TaskBaseline2Work { get; set; }

        public decimal? TaskBaseline2BudgetCost { get; set; }

        public decimal? TaskBaseline2BudgetWork { get; set; }

        public DateTime? TaskBaseline2StartDate { get; set; }

        [StringLength(255)]
        public string TaskBaseline2StartDateString { get; set; }

        public DateTime? TaskBaseline2FinishDate { get; set; }

        [StringLength(255)]
        public string TaskBaseline2FinishDateString { get; set; }

        public DateTime? TaskBaseline2DeliverableStartDate { get; set; }

        public DateTime? TaskBaseline2DeliverableFinishDate { get; set; }

        public decimal? TaskBaseline2Duration { get; set; }

        [StringLength(255)]
        public string TaskBaseline2DurationString { get; set; }

        public decimal? TaskBaseline3Cost { get; set; }

        public decimal? TaskBaseline3FixedCost { get; set; }

        public decimal? TaskBaseline3Work { get; set; }

        public decimal? TaskBaseline3BudgetCost { get; set; }

        public decimal? TaskBaseline3BudgetWork { get; set; }

        public DateTime? TaskBaseline3StartDate { get; set; }

        [StringLength(255)]
        public string TaskBaseline3StartDateString { get; set; }

        public DateTime? TaskBaseline3FinishDate { get; set; }

        [StringLength(255)]
        public string TaskBaseline3FinishDateString { get; set; }

        public DateTime? TaskBaseline3DeliverableStartDate { get; set; }

        public DateTime? TaskBaseline3DeliverableFinishDate { get; set; }

        public decimal? TaskBaseline3Duration { get; set; }

        [StringLength(255)]
        public string TaskBaseline3DurationString { get; set; }

        public decimal? TaskBaseline4Cost { get; set; }

        public decimal? TaskBaseline4FixedCost { get; set; }

        public decimal? TaskBaseline4Work { get; set; }

        public decimal? TaskBaseline4BudgetCost { get; set; }

        public decimal? TaskBaseline4BudgetWork { get; set; }

        public DateTime? TaskBaseline4StartDate { get; set; }

        [StringLength(255)]
        public string TaskBaseline4StartDateString { get; set; }

        public DateTime? TaskBaseline4FinishDate { get; set; }

        [StringLength(255)]
        public string TaskBaseline4FinishDateString { get; set; }

        public DateTime? TaskBaseline4DeliverableStartDate { get; set; }

        public DateTime? TaskBaseline4DeliverableFinishDate { get; set; }

        public decimal? TaskBaseline4Duration { get; set; }

        [StringLength(255)]
        public string TaskBaseline4DurationString { get; set; }

        public decimal? TaskBaseline5Cost { get; set; }

        public decimal? TaskBaseline5FixedCost { get; set; }

        public decimal? TaskBaseline5Work { get; set; }

        public decimal? TaskBaseline5BudgetCost { get; set; }

        public decimal? TaskBaseline5BudgetWork { get; set; }

        public DateTime? TaskBaseline5StartDate { get; set; }

        [StringLength(255)]
        public string TaskBaseline5StartDateString { get; set; }

        public DateTime? TaskBaseline5FinishDate { get; set; }

        [StringLength(255)]
        public string TaskBaseline5FinishDateString { get; set; }

        public DateTime? TaskBaseline5DeliverableStartDate { get; set; }

        public DateTime? TaskBaseline5DeliverableFinishDate { get; set; }

        public decimal? TaskBaseline5Duration { get; set; }

        [StringLength(255)]
        public string TaskBaseline5DurationString { get; set; }

        public decimal? TaskBaseline6Cost { get; set; }

        public decimal? TaskBaseline6FixedCost { get; set; }

        public decimal? TaskBaseline6Work { get; set; }

        public decimal? TaskBaseline6BudgetCost { get; set; }

        public decimal? TaskBaseline6BudgetWork { get; set; }

        public DateTime? TaskBaseline6StartDate { get; set; }

        [StringLength(255)]
        public string TaskBaseline6StartDateString { get; set; }

        public DateTime? TaskBaseline6FinishDate { get; set; }

        [StringLength(255)]
        public string TaskBaseline6FinishDateString { get; set; }

        public DateTime? TaskBaseline6DeliverableStartDate { get; set; }

        public DateTime? TaskBaseline6DeliverableFinishDate { get; set; }

        public decimal? TaskBaseline6Duration { get; set; }

        [StringLength(255)]
        public string TaskBaseline6DurationString { get; set; }

        public decimal? TaskBaseline7Cost { get; set; }

        public decimal? TaskBaseline7FixedCost { get; set; }

        public decimal? TaskBaseline7Work { get; set; }

        public decimal? TaskBaseline7BudgetCost { get; set; }

        public decimal? TaskBaseline7BudgetWork { get; set; }

        public DateTime? TaskBaseline7StartDate { get; set; }

        [StringLength(255)]
        public string TaskBaseline7StartDateString { get; set; }

        public DateTime? TaskBaseline7FinishDate { get; set; }

        [StringLength(255)]
        public string TaskBaseline7FinishDateString { get; set; }

        public DateTime? TaskBaseline7DeliverableStartDate { get; set; }

        public DateTime? TaskBaseline7DeliverableFinishDate { get; set; }

        public decimal? TaskBaseline7Duration { get; set; }

        [StringLength(255)]
        public string TaskBaseline7DurationString { get; set; }

        public decimal? TaskBaseline8Cost { get; set; }

        public decimal? TaskBaseline8FixedCost { get; set; }

        public decimal? TaskBaseline8Work { get; set; }

        public decimal? TaskBaseline8BudgetCost { get; set; }

        public decimal? TaskBaseline8BudgetWork { get; set; }

        public DateTime? TaskBaseline8StartDate { get; set; }

        [StringLength(255)]
        public string TaskBaseline8StartDateString { get; set; }

        public DateTime? TaskBaseline8FinishDate { get; set; }

        [StringLength(255)]
        public string TaskBaseline8FinishDateString { get; set; }

        public DateTime? TaskBaseline8DeliverableStartDate { get; set; }

        public DateTime? TaskBaseline8DeliverableFinishDate { get; set; }

        public decimal? TaskBaseline8Duration { get; set; }

        [StringLength(255)]
        public string TaskBaseline8DurationString { get; set; }

        public decimal? TaskBaseline9Cost { get; set; }

        public decimal? TaskBaseline9FixedCost { get; set; }

        public decimal? TaskBaseline9Work { get; set; }

        public decimal? TaskBaseline9BudgetCost { get; set; }

        public decimal? TaskBaseline9BudgetWork { get; set; }

        public DateTime? TaskBaseline9StartDate { get; set; }

        [StringLength(255)]
        public string TaskBaseline9StartDateString { get; set; }

        public DateTime? TaskBaseline9FinishDate { get; set; }

        [StringLength(255)]
        public string TaskBaseline9FinishDateString { get; set; }

        public DateTime? TaskBaseline9DeliverableStartDate { get; set; }

        public DateTime? TaskBaseline9DeliverableFinishDate { get; set; }

        public decimal? TaskBaseline9Duration { get; set; }

        [StringLength(255)]
        public string TaskBaseline9DurationString { get; set; }

        public decimal? TaskBaseline10Cost { get; set; }

        public decimal? TaskBaseline10FixedCost { get; set; }

        public decimal? TaskBaseline10Work { get; set; }

        public decimal? TaskBaseline10BudgetCost { get; set; }

        public decimal? TaskBaseline10BudgetWork { get; set; }

        public DateTime? TaskBaseline10StartDate { get; set; }

        [StringLength(255)]
        public string TaskBaseline10StartDateString { get; set; }

        public DateTime? TaskBaseline10FinishDate { get; set; }

        [StringLength(255)]
        public string TaskBaseline10FinishDateString { get; set; }

        public DateTime? TaskBaseline10DeliverableStartDate { get; set; }

        public DateTime? TaskBaseline10DeliverableFinishDate { get; set; }

        public decimal? TaskBaseline10Duration { get; set; }

        [StringLength(255)]
        public string TaskBaseline10DurationString { get; set; }

        [StringLength(4000)]
        public string Health { get; set; }

        [Column("Site Task")]
        [StringLength(4000)]
        public string Site_Task { get; set; }

        [StringLength(4000)]
        public string CapEx { get; set; }

        [Column("Fac Activity Code")]
        [StringLength(4000)]
        public string Fac_Activity_Code { get; set; }

        [Key]
        [Column("Flag Status", Order = 1)]
        public bool Flag_Status { get; set; }

        [Column("Task Note")]
        [StringLength(4000)]
        public string Task_Note { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool ReportTask { get; set; }

        public decimal? TargetPercentComplete { get; set; }

        [Column("PLM Milestone")]
        [StringLength(4000)]
        public string PLM_Milestone { get; set; }

        [Column("PLM Segment")]
        [StringLength(4000)]
        public string PLM_Segment { get; set; }

        [Key]
        [Column("Task Group 1 (Flag1)", Order = 3)]
        public bool Task_Group_1__Flag1_ { get; set; }

        [Key]
        [Column("Task Group 2 (Flag2)", Order = 4)]
        public bool Task_Group_2__Flag2_ { get; set; }

        [Key]
        [Column("Task Group 3 (Flag3)", Order = 5)]
        public bool Task_Group_3__Flag3_ { get; set; }

        [Key]
        [Column("Task Group 4 (Flag4)", Order = 6)]
        public bool Task_Group_4__Flag4_ { get; set; }

        [Key]
        [Column("Task Group 5 (Flag5)", Order = 7)]
        public bool Task_Group_5__Flag5_ { get; set; }

        [Column("PLM ID")]
        [StringLength(4000)]
        public string PLM_ID { get; set; }

        [Column("Component1 ID")]
        [StringLength(4000)]
        public string Component1_ID { get; set; }

        [Column("Component2 ID")]
        [StringLength(4000)]
        public string Component2_ID { get; set; }

        [Column("Component3 ID")]
        [StringLength(4000)]
        public string Component3_ID { get; set; }

        [Column("Component4 ID")]
        [StringLength(4000)]
        public string Component4_ID { get; set; }

        [Column("Component5 ID")]
        [StringLength(4000)]
        public string Component5_ID { get; set; }

        [Column("Component6 ID")]
        [StringLength(4000)]
        public string Component6_ID { get; set; }

        [Column("Department Cost Center")]
        [StringLength(4000)]
        public string Department_Cost_Center { get; set; }
    }
}
