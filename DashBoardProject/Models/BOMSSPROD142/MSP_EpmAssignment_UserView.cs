namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmAssignment_UserView
    {
        public Guid? AssignmentUID { get; set; }

        public Guid? ProjectUID { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid ResourceUID { get; set; }

        public Guid? TaskUID { get; set; }

        public Guid? TimesheetClassUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ResourceOwnerUID { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal AssignmentCost { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal AssignmentOvertimeCost { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal AssignmentActualCost { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal AssignmentActualOvertimeCost { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal AssignmentWork { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal AssignmentOvertimeWork { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal AssignmentActualWork { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal AssignmentActualOvertimeWork { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal AssignmentMaterialWork { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal AssignmentMaterialActualWork { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short AssignmentPercentWorkCompleted { get; set; }

        public DateTime? AssignmentStartDate { get; set; }

        public DateTime? AssignmentFinishDate { get; set; }

        public DateTime? AssignmentActualStartDate { get; set; }

        public DateTime? AssignmentActualFinishDate { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal AssignmentDelay { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal AssignmentStartVariance { get; set; }

        [Key]
        [Column(Order = 15)]
        public decimal AssignmentFinishVariance { get; set; }

        [Key]
        [Column(Order = 16)]
        public decimal AssignmentACWP { get; set; }

        [Key]
        [Column(Order = 17)]
        public decimal AssignmentBCWP { get; set; }

        [Key]
        [Column(Order = 18)]
        public decimal AssignmentBCWS { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AssignmentBookingID { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AssignmentType { get; set; }

        [Key]
        [Column(Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short AssignmentResourceType { get; set; }

        [Key]
        [Column(Order = 22)]
        public bool AssignmentIsPublished { get; set; }

        public bool? IsPublic { get; set; }

        [Key]
        [Column(Order = 23)]
        public decimal AssignmentCostVariance { get; set; }

        [Key]
        [Column(Order = 24)]
        public decimal AssignmentWorkVariance { get; set; }

        [Key]
        [Column(Order = 25)]
        public decimal AssignmentCV { get; set; }

        [Key]
        [Column(Order = 26)]
        public decimal AssignmentSV { get; set; }

        [Key]
        [Column(Order = 27)]
        public decimal AssignmentVAC { get; set; }

        [Key]
        [Column(Order = 28)]
        public bool AssignmentIsOverallocated { get; set; }

        [Key]
        [Column(Order = 29)]
        public decimal AssignmentPeakUnits { get; set; }

        [Key]
        [Column(Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AssignmentCreatedRevisionCounter { get; set; }

        [Key]
        [Column(Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AssignmentModifiedRevisionCounter { get; set; }

        public DateTime? AssignmentCreatedDate { get; set; }

        public DateTime? AssignmentModifiedDate { get; set; }

        [Key]
        [Column(Order = 32)]
        public decimal AssignmentBudgetCost { get; set; }

        [Key]
        [Column(Order = 33)]
        public decimal AssignmentBudgetWork { get; set; }

        [Key]
        [Column(Order = 34)]
        public decimal AssignmentBudgetMaterialWork { get; set; }

        [Key]
        [Column(Order = 35)]
        public decimal AssignmentResourcePlanWork { get; set; }

        public bool? TaskIsActive { get; set; }

        [Key]
        [Column(Order = 36)]
        public decimal AssignmentRegularCost { get; set; }

        [Key]
        [Column(Order = 37)]
        public decimal AssignmentRemainingCost { get; set; }

        [Key]
        [Column(Order = 38)]
        public decimal AssignmentRemainingOvertimeCost { get; set; }

        [Key]
        [Column(Order = 39)]
        public decimal AssignmentActualRegularCost { get; set; }

        [Key]
        [Column(Order = 40)]
        public decimal AssignmentRemainingRegularCost { get; set; }

        [Key]
        [Column(Order = 41)]
        public decimal AssignmentRegularWork { get; set; }

        [Key]
        [Column(Order = 42)]
        public decimal AssignmentRemainingWork { get; set; }

        [Key]
        [Column(Order = 43)]
        public decimal AssignmentRemainingOvertimeWork { get; set; }

        [Key]
        [Column(Order = 44)]
        public decimal AssignmentActualRegularWork { get; set; }

        [Key]
        [Column(Order = 45)]
        public decimal AssignmentRemainingRegularWork { get; set; }

        [Key]
        [Column(Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AssignmentCount { get; set; }

        public decimal? AssignmentBaseline0Cost { get; set; }

        public decimal? AssignmentBaseline0Work { get; set; }

        public decimal? AssignmentBaseline0MaterialWork { get; set; }

        public decimal? AssignmentBaseline0BudgetCost { get; set; }

        public decimal? AssignmentBaseline0BudgetWork { get; set; }

        public decimal? AssignmentBaseline0BudgetMaterialWork { get; set; }

        public DateTime? AssignmentBaseline0StartDate { get; set; }

        public DateTime? AssignmentBaseline0FinishDate { get; set; }

        public decimal? AssignmentBaseline1Cost { get; set; }

        public decimal? AssignmentBaseline1Work { get; set; }

        public decimal? AssignmentBaseline1MaterialWork { get; set; }

        public decimal? AssignmentBaseline1BudgetCost { get; set; }

        public decimal? AssignmentBaseline1BudgetWork { get; set; }

        public decimal? AssignmentBaseline1BudgetMaterialWork { get; set; }

        public DateTime? AssignmentBaseline1StartDate { get; set; }

        public DateTime? AssignmentBaseline1FinishDate { get; set; }

        public decimal? AssignmentBaseline2Cost { get; set; }

        public decimal? AssignmentBaseline2Work { get; set; }

        public decimal? AssignmentBaseline2MaterialWork { get; set; }

        public decimal? AssignmentBaseline2BudgetCost { get; set; }

        public decimal? AssignmentBaseline2BudgetWork { get; set; }

        public decimal? AssignmentBaseline2BudgetMaterialWork { get; set; }

        public DateTime? AssignmentBaseline2StartDate { get; set; }

        public DateTime? AssignmentBaseline2FinishDate { get; set; }

        public decimal? AssignmentBaseline3Cost { get; set; }

        public decimal? AssignmentBaseline3Work { get; set; }

        public decimal? AssignmentBaseline3MaterialWork { get; set; }

        public decimal? AssignmentBaseline3BudgetCost { get; set; }

        public decimal? AssignmentBaseline3BudgetWork { get; set; }

        public decimal? AssignmentBaseline3BudgetMaterialWork { get; set; }

        public DateTime? AssignmentBaseline3StartDate { get; set; }

        public DateTime? AssignmentBaseline3FinishDate { get; set; }

        public decimal? AssignmentBaseline4Cost { get; set; }

        public decimal? AssignmentBaseline4Work { get; set; }

        public decimal? AssignmentBaseline4MaterialWork { get; set; }

        public decimal? AssignmentBaseline4BudgetCost { get; set; }

        public decimal? AssignmentBaseline4BudgetWork { get; set; }

        public decimal? AssignmentBaseline4BudgetMaterialWork { get; set; }

        public DateTime? AssignmentBaseline4StartDate { get; set; }

        public DateTime? AssignmentBaseline4FinishDate { get; set; }

        public decimal? AssignmentBaseline5Cost { get; set; }

        public decimal? AssignmentBaseline5Work { get; set; }

        public decimal? AssignmentBaseline5MaterialWork { get; set; }

        public decimal? AssignmentBaseline5BudgetCost { get; set; }

        public decimal? AssignmentBaseline5BudgetWork { get; set; }

        public decimal? AssignmentBaseline5BudgetMaterialWork { get; set; }

        public DateTime? AssignmentBaseline5StartDate { get; set; }

        public DateTime? AssignmentBaseline5FinishDate { get; set; }

        public decimal? AssignmentBaseline6Cost { get; set; }

        public decimal? AssignmentBaseline6Work { get; set; }

        public decimal? AssignmentBaseline6MaterialWork { get; set; }

        public decimal? AssignmentBaseline6BudgetCost { get; set; }

        public decimal? AssignmentBaseline6BudgetWork { get; set; }

        public decimal? AssignmentBaseline6BudgetMaterialWork { get; set; }

        public DateTime? AssignmentBaseline6StartDate { get; set; }

        public DateTime? AssignmentBaseline6FinishDate { get; set; }

        public decimal? AssignmentBaseline7Cost { get; set; }

        public decimal? AssignmentBaseline7Work { get; set; }

        public decimal? AssignmentBaseline7MaterialWork { get; set; }

        public decimal? AssignmentBaseline7BudgetCost { get; set; }

        public decimal? AssignmentBaseline7BudgetWork { get; set; }

        public decimal? AssignmentBaseline7BudgetMaterialWork { get; set; }

        public DateTime? AssignmentBaseline7StartDate { get; set; }

        public DateTime? AssignmentBaseline7FinishDate { get; set; }

        public decimal? AssignmentBaseline8Cost { get; set; }

        public decimal? AssignmentBaseline8Work { get; set; }

        public decimal? AssignmentBaseline8MaterialWork { get; set; }

        public decimal? AssignmentBaseline8BudgetCost { get; set; }

        public decimal? AssignmentBaseline8BudgetWork { get; set; }

        public decimal? AssignmentBaseline8BudgetMaterialWork { get; set; }

        public DateTime? AssignmentBaseline8StartDate { get; set; }

        public DateTime? AssignmentBaseline8FinishDate { get; set; }

        public decimal? AssignmentBaseline9Cost { get; set; }

        public decimal? AssignmentBaseline9Work { get; set; }

        public decimal? AssignmentBaseline9MaterialWork { get; set; }

        public decimal? AssignmentBaseline9BudgetCost { get; set; }

        public decimal? AssignmentBaseline9BudgetWork { get; set; }

        public decimal? AssignmentBaseline9BudgetMaterialWork { get; set; }

        public DateTime? AssignmentBaseline9StartDate { get; set; }

        public DateTime? AssignmentBaseline9FinishDate { get; set; }

        public decimal? AssignmentBaseline10Cost { get; set; }

        public decimal? AssignmentBaseline10Work { get; set; }

        public decimal? AssignmentBaseline10MaterialWork { get; set; }

        public decimal? AssignmentBaseline10BudgetCost { get; set; }

        public decimal? AssignmentBaseline10BudgetWork { get; set; }

        public decimal? AssignmentBaseline10BudgetMaterialWork { get; set; }

        public DateTime? AssignmentBaseline10StartDate { get; set; }

        public DateTime? AssignmentBaseline10FinishDate { get; set; }

        [StringLength(4000)]
        public string Health_T { get; set; }

        [Column("Cost Type_R")]
        [StringLength(4000)]
        public string Cost_Type_R { get; set; }

        [Column("Team Name_R")]
        [StringLength(4000)]
        public string Team_Name_R { get; set; }

        [StringLength(4000)]
        public string RBS_R { get; set; }

        [Column("Worker Team_R")]
        [StringLength(4000)]
        public string Worker_Team_R { get; set; }

        [Column("Site Task_T")]
        [StringLength(4000)]
        public string Site_Task_T { get; set; }

        [StringLength(4000)]
        public string CapEx_T { get; set; }

        [Column("Worker Organization_R")]
        [StringLength(4000)]
        public string Worker_Organization_R { get; set; }

        [Column("Fac Activity Code_T")]
        [StringLength(4000)]
        public string Fac_Activity_Code_T { get; set; }

        [Column("Worker Role_R")]
        [StringLength(4000)]
        public string Worker_Role_R { get; set; }

        [Column("Resource Departments_R")]
        [StringLength(4000)]
        public string Resource_Departments_R { get; set; }

        [Key]
        [Column("Flag Status_T", Order = 47)]
        public bool Flag_Status_T { get; set; }

        [Column("Worker Domain_R")]
        [StringLength(4000)]
        public string Worker_Domain_R { get; set; }

        [Column("Task Note_T")]
        [StringLength(4000)]
        public string Task_Note_T { get; set; }

        [Key]
        [Column(Order = 48)]
        public bool ReportTask_T { get; set; }

        public decimal? TargetPercentComplete_T { get; set; }

        [Column("PLM Milestone_T")]
        [StringLength(4000)]
        public string PLM_Milestone_T { get; set; }

        [Column("PLM Segment_T")]
        [StringLength(4000)]
        public string PLM_Segment_T { get; set; }

        [Key]
        [Column("Task Group 1 (Flag1)_T", Order = 49)]
        public bool Task_Group_1__Flag1__T { get; set; }

        [Key]
        [Column("Task Group 2 (Flag2)_T", Order = 50)]
        public bool Task_Group_2__Flag2__T { get; set; }

        [Key]
        [Column("Task Group 3 (Flag3)_T", Order = 51)]
        public bool Task_Group_3__Flag3__T { get; set; }

        [Key]
        [Column("Task Group 4 (Flag4)_T", Order = 52)]
        public bool Task_Group_4__Flag4__T { get; set; }

        [Key]
        [Column("Task Group 5 (Flag5)_T", Order = 53)]
        public bool Task_Group_5__Flag5__T { get; set; }

        [Column("PLM ID_T")]
        [StringLength(4000)]
        public string PLM_ID_T { get; set; }

        [Column("Component1 ID_T")]
        [StringLength(4000)]
        public string Component1_ID_T { get; set; }

        [Column("Component2 ID_T")]
        [StringLength(4000)]
        public string Component2_ID_T { get; set; }

        [Column("Component3 ID_T")]
        [StringLength(4000)]
        public string Component3_ID_T { get; set; }

        [Column("Component4 ID_T")]
        [StringLength(4000)]
        public string Component4_ID_T { get; set; }

        [Column("Component5 ID_T")]
        [StringLength(4000)]
        public string Component5_ID_T { get; set; }

        [Column("Component6 ID_T")]
        [StringLength(4000)]
        public string Component6_ID_T { get; set; }

        [Column("Department Cost Center_T")]
        [StringLength(4000)]
        public string Department_Cost_Center_T { get; set; }
    }
}
