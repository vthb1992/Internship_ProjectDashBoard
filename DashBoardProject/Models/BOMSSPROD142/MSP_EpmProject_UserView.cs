namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmProject_UserView
    {
        [Key]
        [Column(Order = 0)]
        public Guid ProjectUID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string ProjectName { get; set; }

        [Column(TypeName = "ntext")]
        public string ProjectDescription { get; set; }

        [StringLength(255)]
        public string ProjectAuthorName { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid ProjectOwnerResourceUID { get; set; }

        public DateTime? ProjectStartDate { get; set; }

        public Guid? EnterpriseProjectTypeUID { get; set; }

        public DateTime? ProjectFinishDate { get; set; }

        public DateTime? ProjectStatusDate { get; set; }

        [StringLength(255)]
        public string ProjectManagerName { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectType { get; set; }

        [StringLength(1024)]
        public string ProjectWorkspaceInternalHRef { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool ProjectWbsIsStale { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool ProjectEarnedValueIsStale { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool ProjectRollupsAreStale { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool ProjectHierarchyNotSynchronized { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool ProjectCalculationsAreStale { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool ProjectGhostTaskAreStale { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(4)]
        public string ProjectCurrency { get; set; }

        public short? ResourcePlanUtilizationType { get; set; }

        public DateTime? ResourcePlanUtilizationDate { get; set; }

        [StringLength(255)]
        public string ProjectCategoryName { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectCreatedRevisionCounter { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectModifiedRevisionCounter { get; set; }

        [StringLength(255)]
        public string ProjectCompanyName { get; set; }

        [StringLength(255)]
        public string ProjectKeywords { get; set; }

        [Key]
        [Column(Order = 13)]
        public DateTime ProjectCreatedDate { get; set; }

        [StringLength(255)]
        public string ProjectSubject { get; set; }

        [Key]
        [Column(Order = 14)]
        public DateTime ProjectModifiedDate { get; set; }

        [StringLength(255)]
        public string ProjectTitle { get; set; }

        public int? ProjectCalendarDuration { get; set; }

        public Guid? ParentProjectUID { get; set; }

        public decimal? ProjectFixedCost { get; set; }

        public decimal? ProjectCost { get; set; }

        public decimal? ProjectOvertimeCost { get; set; }

        public decimal? ProjectActualCost { get; set; }

        public decimal? ProjectActualOvertimeCost { get; set; }

        public decimal? ProjectWork { get; set; }

        public decimal? ProjectOvertimeWork { get; set; }

        public decimal? ProjectActualWork { get; set; }

        public decimal? ProjectActualOvertimeWork { get; set; }

        public decimal? ProjectDurationVariance { get; set; }

        public decimal? ProjectStartVariance { get; set; }

        public decimal? ProjectFinishVariance { get; set; }

        public decimal? ProjectDuration { get; set; }

        public decimal? ProjectActualDuration { get; set; }

        public DateTime? ProjectActualStartDate { get; set; }

        public DateTime? ProjectActualFinishDate { get; set; }

        public short? ProjectPercentCompleted { get; set; }

        public short? ProjectPercentWorkCompleted { get; set; }

        public decimal? ProjectACWP { get; set; }

        public decimal? ProjectBCWP { get; set; }

        public decimal? ProjectBCWS { get; set; }

        public decimal? ProjectSPI { get; set; }

        public decimal? ProjectTCPI { get; set; }

        public decimal? ProjectVAC { get; set; }

        public decimal? ProjectEAC { get; set; }

        public decimal? ProjectCostVariance { get; set; }

        public decimal? ProjectCV { get; set; }

        public decimal? ProjectCPI { get; set; }

        public DateTime? ProjectEarlyFinish { get; set; }

        public DateTime? ProjectEarlyStart { get; set; }

        public DateTime? ProjectLateFinish { get; set; }

        public DateTime? ProjectLateStart { get; set; }

        public decimal? ProjectSV { get; set; }

        public decimal? ProjectWorkVariance { get; set; }

        public decimal? ProjectBudgetCost { get; set; }

        public decimal? ProjectBudgetWork { get; set; }

        public decimal? ProjectResourcePlanWork { get; set; }

        public decimal? ProjectRegularCost { get; set; }

        public decimal? ProjectRemainingCost { get; set; }

        public decimal? ProjectRemainingOvertimeCost { get; set; }

        public decimal? ProjectActualRegularCost { get; set; }

        public decimal? ProjectRemainingRegularCost { get; set; }

        public decimal? ProjectRegularWork { get; set; }

        public decimal? ProjectRemainingWork { get; set; }

        public decimal? ProjectRemainingOvertimeWork { get; set; }

        public decimal? ProjectActualRegularWork { get; set; }

        public decimal? ProjectRemainingRegularWork { get; set; }

        public decimal? ProjectRemainingDuration { get; set; }

        public decimal? ProjectCVP { get; set; }

        public decimal? ProjectSVP { get; set; }

        [StringLength(255)]
        public string ProjectOwnerName { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectCount { get; set; }

        public decimal? ProjectBaseline0Cost { get; set; }

        public decimal? ProjectBaseline0FixedCost { get; set; }

        public decimal? ProjectBaseline0Work { get; set; }

        public decimal? ProjectBaseline0BudgetCost { get; set; }

        public decimal? ProjectBaseline0BudgetWork { get; set; }

        public DateTime? ProjectBaseline0StartDate { get; set; }

        public DateTime? ProjectBaseline0FinishDate { get; set; }

        public decimal? ProjectBaseline0Duration { get; set; }

        public decimal? ProjectBaseline1Cost { get; set; }

        public decimal? ProjectBaseline1FixedCost { get; set; }

        public decimal? ProjectBaseline1Work { get; set; }

        public decimal? ProjectBaseline1BudgetCost { get; set; }

        public decimal? ProjectBaseline1BudgetWork { get; set; }

        public DateTime? ProjectBaseline1StartDate { get; set; }

        public DateTime? ProjectBaseline1FinishDate { get; set; }

        public decimal? ProjectBaseline1Duration { get; set; }

        public decimal? ProjectBaseline2Cost { get; set; }

        public decimal? ProjectBaseline2FixedCost { get; set; }

        public decimal? ProjectBaseline2Work { get; set; }

        public decimal? ProjectBaseline2BudgetCost { get; set; }

        public decimal? ProjectBaseline2BudgetWork { get; set; }

        public DateTime? ProjectBaseline2StartDate { get; set; }

        public DateTime? ProjectBaseline2FinishDate { get; set; }

        public decimal? ProjectBaseline2Duration { get; set; }

        public decimal? ProjectBaseline3Cost { get; set; }

        public decimal? ProjectBaseline3FixedCost { get; set; }

        public decimal? ProjectBaseline3Work { get; set; }

        public decimal? ProjectBaseline3BudgetCost { get; set; }

        public decimal? ProjectBaseline3BudgetWork { get; set; }

        public DateTime? ProjectBaseline3StartDate { get; set; }

        public DateTime? ProjectBaseline3FinishDate { get; set; }

        public decimal? ProjectBaseline3Duration { get; set; }

        public decimal? ProjectBaseline4Cost { get; set; }

        public decimal? ProjectBaseline4FixedCost { get; set; }

        public decimal? ProjectBaseline4Work { get; set; }

        public decimal? ProjectBaseline4BudgetCost { get; set; }

        public decimal? ProjectBaseline4BudgetWork { get; set; }

        public DateTime? ProjectBaseline4StartDate { get; set; }

        public DateTime? ProjectBaseline4FinishDate { get; set; }

        public decimal? ProjectBaseline4Duration { get; set; }

        public decimal? ProjectBaseline5Cost { get; set; }

        public decimal? ProjectBaseline5FixedCost { get; set; }

        public decimal? ProjectBaseline5Work { get; set; }

        public decimal? ProjectBaseline5BudgetCost { get; set; }

        public decimal? ProjectBaseline5BudgetWork { get; set; }

        public DateTime? ProjectBaseline5StartDate { get; set; }

        public DateTime? ProjectBaseline5FinishDate { get; set; }

        public decimal? ProjectBaseline5Duration { get; set; }

        public decimal? ProjectBaseline6Cost { get; set; }

        public decimal? ProjectBaseline6FixedCost { get; set; }

        public decimal? ProjectBaseline6Work { get; set; }

        public decimal? ProjectBaseline6BudgetCost { get; set; }

        public decimal? ProjectBaseline6BudgetWork { get; set; }

        public DateTime? ProjectBaseline6StartDate { get; set; }

        public DateTime? ProjectBaseline6FinishDate { get; set; }

        public decimal? ProjectBaseline6Duration { get; set; }

        public decimal? ProjectBaseline7Cost { get; set; }

        public decimal? ProjectBaseline7FixedCost { get; set; }

        public decimal? ProjectBaseline7Work { get; set; }

        public decimal? ProjectBaseline7BudgetCost { get; set; }

        public decimal? ProjectBaseline7BudgetWork { get; set; }

        public DateTime? ProjectBaseline7StartDate { get; set; }

        public DateTime? ProjectBaseline7FinishDate { get; set; }

        public decimal? ProjectBaseline7Duration { get; set; }

        public decimal? ProjectBaseline8Cost { get; set; }

        public decimal? ProjectBaseline8FixedCost { get; set; }

        public decimal? ProjectBaseline8Work { get; set; }

        public decimal? ProjectBaseline8BudgetCost { get; set; }

        public decimal? ProjectBaseline8BudgetWork { get; set; }

        public DateTime? ProjectBaseline8StartDate { get; set; }

        public DateTime? ProjectBaseline8FinishDate { get; set; }

        public decimal? ProjectBaseline8Duration { get; set; }

        public decimal? ProjectBaseline9Cost { get; set; }

        public decimal? ProjectBaseline9FixedCost { get; set; }

        public decimal? ProjectBaseline9Work { get; set; }

        public decimal? ProjectBaseline9BudgetCost { get; set; }

        public decimal? ProjectBaseline9BudgetWork { get; set; }

        public DateTime? ProjectBaseline9StartDate { get; set; }

        public DateTime? ProjectBaseline9FinishDate { get; set; }

        public decimal? ProjectBaseline9Duration { get; set; }

        public decimal? ProjectBaseline10Cost { get; set; }

        public decimal? ProjectBaseline10FixedCost { get; set; }

        public decimal? ProjectBaseline10Work { get; set; }

        public decimal? ProjectBaseline10BudgetCost { get; set; }

        public decimal? ProjectBaseline10BudgetWork { get; set; }

        public DateTime? ProjectBaseline10StartDate { get; set; }

        public DateTime? ProjectBaseline10FinishDate { get; set; }

        public decimal? ProjectBaseline10Duration { get; set; }

        [StringLength(4000)]
        public string State { get; set; }

        [Column("Project ID")]
        [StringLength(4000)]
        public string Project_ID { get; set; }

        [Column("Schedule Status")]
        [StringLength(4000)]
        public string Schedule_Status { get; set; }

        [Column("Cost Status")]
        [StringLength(4000)]
        public string Cost_Status { get; set; }

        [Column("Scope Status")]
        [StringLength(4000)]
        public string Scope_Status { get; set; }

        [StringLength(4000)]
        public string Phase { get; set; }

        [StringLength(4000)]
        public string Program { get; set; }

        [StringLength(4000)]
        public string Organization { get; set; }

        [Column("Executive Sponsor")]
        [StringLength(4000)]
        public string Executive_Sponsor { get; set; }

        [Column("Project Prob of Success")]
        public decimal? Project_Prob_of_Success { get; set; }

        [Column("Primary Benefit Actual")]
        public decimal? Primary_Benefit_Actual { get; set; }

        [Column("Primary Benefit Estimate")]
        public decimal? Primary_Benefit_Estimate { get; set; }

        [Column("Primary Benefit Metric")]
        [StringLength(4000)]
        public string Primary_Benefit_Metric { get; set; }

        [Column("Primary Benefit Risk Assessed")]
        public decimal? Primary_Benefit_Risk_Assessed { get; set; }

        [Column("State of Project")]
        [StringLength(4000)]
        public string State_of_Project { get; set; }

        [Column("Project Sponsor")]
        [StringLength(4000)]
        public string Project_Sponsor { get; set; }

        [Column("Portfolio Priority")]
        public decimal? Portfolio_Priority { get; set; }

        [Column("Project Departments")]
        [StringLength(4000)]
        public string Project_Departments { get; set; }

        [Column("Benefits Comment")]
        [StringLength(4000)]
        public string Benefits_Comment { get; set; }

        [StringLength(4000)]
        public string Billing { get; set; }

        [Column("Billing Site")]
        [StringLength(4000)]
        public string Billing_Site { get; set; }

        [Column("Cost Comment")]
        [StringLength(4000)]
        public string Cost_Comment { get; set; }

        [Column("Geographic Scope")]
        [StringLength(4000)]
        public string Geographic_Scope { get; set; }

        [Column("IS Budget Capital")]
        public decimal? IS_Budget_Capital { get; set; }

        [Column("IS Budget Consulting")]
        public decimal? IS_Budget_Consulting { get; set; }

        [Column("IS Budget Expense")]
        public decimal? IS_Budget_Expense { get; set; }

        [Column("IS Budget FTE")]
        public decimal? IS_Budget_FTE { get; set; }

        [Column("IS Remaining Capital")]
        public decimal? IS_Remaining_Capital { get; set; }

        [Column("IS Remaining Consulting")]
        public decimal? IS_Remaining_Consulting { get; set; }

        [Column("IS Remaining Expense")]
        public decimal? IS_Remaining_Expense { get; set; }

        [Column("IS Remaining FTE")]
        public decimal? IS_Remaining_FTE { get; set; }

        [Column("Key Stakeholders")]
        [StringLength(4000)]
        public string Key_Stakeholders { get; set; }

        [Column("Lead Architect")]
        [StringLength(4000)]
        public string Lead_Architect { get; set; }

        [Column("Org Unit")]
        [StringLength(4000)]
        public string Org_Unit { get; set; }

        [Column("Org Subunit")]
        [StringLength(4000)]
        public string Org_Subunit { get; set; }

        [Column("Post Project Impact")]
        [StringLength(4000)]
        public string Post_Project_Impact { get; set; }

        [Column("Primary Objective")]
        [StringLength(4000)]
        public string Primary_Objective { get; set; }

        [Column("Primary Service")]
        [StringLength(4000)]
        public string Primary_Service { get; set; }

        [Column("Problem Opportunity Statement")]
        [StringLength(4000)]
        public string Problem_Opportunity_Statement { get; set; }

        [Column("Project Constraints")]
        [StringLength(4000)]
        public string Project_Constraints { get; set; }

        [Column("Project Deliverables")]
        [StringLength(4000)]
        public string Project_Deliverables { get; set; }

        [Column("Project Description")]
        [StringLength(4000)]
        public string Project_Description { get; set; }

        [Column("Project Exclusions")]
        [StringLength(4000)]
        public string Project_Exclusions { get; set; }

        [Column("Project Scope")]
        [StringLength(4000)]
        public string Project_Scope { get; set; }

        [Column("Proposal Authors")]
        [StringLength(4000)]
        public string Proposal_Authors { get; set; }

        [Column("Proposed Finish")]
        public DateTime? Proposed_Finish { get; set; }

        [Column("Proposed Start")]
        public DateTime? Proposed_Start { get; set; }

        [Column("Reference ID")]
        [StringLength(4000)]
        public string Reference_ID { get; set; }

        [Column("Benefits Finish")]
        public DateTime? Benefits_Finish { get; set; }

        [Column("IS Start Estimate")]
        public DateTime? IS_Start_Estimate { get; set; }

        [Column("IS Finish Estimate")]
        public DateTime? IS_Finish_Estimate { get; set; }

        [Column("Schedule Status Details")]
        [StringLength(4000)]
        public string Schedule_Status_Details { get; set; }

        [Column("Cost Status Details")]
        [StringLength(4000)]
        public string Cost_Status_Details { get; set; }

        [Column("Scope Status Details")]
        [StringLength(4000)]
        public string Scope_Status_Details { get; set; }

        [Column("Resource Status")]
        [StringLength(4000)]
        public string Resource_Status { get; set; }

        [Column("Resource Status Detail")]
        [StringLength(4000)]
        public string Resource_Status_Detail { get; set; }

        [Column("Risks Status")]
        [StringLength(4000)]
        public string Risks_Status { get; set; }

        [Column("Risks Status Detail")]
        [StringLength(4000)]
        public string Risks_Status_Detail { get; set; }

        [Column("Business Driver Comments")]
        [StringLength(4000)]
        public string Business_Driver_Comments { get; set; }

        [Key]
        [Column("Continuous Improvement", Order = 16)]
        public bool Continuous_Improvement { get; set; }

        [Column("Proposed PM")]
        [StringLength(4000)]
        public string Proposed_PM { get; set; }

        [Column("Business Process")]
        [StringLength(4000)]
        public string Business_Process { get; set; }

        [Column("First Portfolio Submital")]
        public DateTime? First_Portfolio_Submital { get; set; }

        [Key]
        [Column("IS Cost Project", Order = 17)]
        public bool IS_Cost_Project { get; set; }

        [Column("IS Cost Site")]
        [StringLength(4000)]
        public string IS_Cost_Site { get; set; }

        [Key]
        [Column("Unproven Technology", Order = 18)]
        public bool Unproven_Technology { get; set; }

        [Column("BPM Phase")]
        [StringLength(4000)]
        public string BPM_Phase { get; set; }

        [Column("Deliverables Comment")]
        [StringLength(4000)]
        public string Deliverables_Comment { get; set; }

        [Column("Area Requesting Project")]
        [StringLength(4000)]
        public string Area_Requesting_Project { get; set; }

        [Key]
        [Column("IS System Impact", Order = 19)]
        public bool IS_System_Impact { get; set; }

        [Column("Sustaining Resource")]
        [StringLength(4000)]
        public string Sustaining_Resource { get; set; }

        [Column("Project Core Team")]
        [StringLength(4000)]
        public string Project_Core_Team { get; set; }

        [Column("PIR Date")]
        public DateTime? PIR_Date { get; set; }

        [Column("Executive Summary")]
        [StringLength(4000)]
        public string Executive_Summary { get; set; }

        [Column("PLM-BLM")]
        [StringLength(4000)]
        public string PLM_BLM { get; set; }

        [Column("Core Team")]
        [StringLength(4000)]
        public string Core_Team { get; set; }

        [Column("Team Status")]
        [StringLength(4000)]
        public string Team_Status { get; set; }

        [Column("HR Business Value Score")]
        public decimal? HR_Business_Value_Score { get; set; }

        [Column("HR Efficiency Score")]
        public decimal? HR_Efficiency_Score { get; set; }

        [Column("HR Financial Score")]
        public decimal? HR_Financial_Score { get; set; }

        public decimal? NPV { get; set; }

        [Column("Payback Period")]
        public decimal? Payback_Period { get; set; }

        [Column("Total Project Hours")]
        public decimal? Total_Project_Hours { get; set; }

        [Column("Total HR Hours")]
        public decimal? Total_HR_Hours { get; set; }

        [Column("Total IS Hours")]
        public decimal? Total_IS_Hours { get; set; }

        [Column("Total Project Cost")]
        public decimal? Total_Project_Cost { get; set; }

        [Column("Project Tier")]
        [StringLength(4000)]
        public string Project_Tier { get; set; }

        [Column("HR SO")]
        [StringLength(4000)]
        public string HR_SO { get; set; }

        [Column("Corp SO")]
        [StringLength(4000)]
        public string Corp_SO { get; set; }

        [StringLength(4000)]
        public string HRAreaOfImpact { get; set; }

        [StringLength(4000)]
        public string HRSystemsImpacted { get; set; }

        [Key]
        [Column("HR Roadmap", Order = 20)]
        public bool HR_Roadmap { get; set; }

        [StringLength(4000)]
        public string Methodology { get; set; }

        [Column("PLM-ETM")]
        [StringLength(4000)]
        public string PLM_ETM { get; set; }

        [Column("PLM-Finance")]
        [StringLength(4000)]
        public string PLM_Finance { get; set; }

        [Column("PIR Instruction")]
        [StringLength(4000)]
        public string PIR_Instruction { get; set; }

        [Column("PIR Assigned To")]
        [StringLength(4000)]
        public string PIR_Assigned_To { get; set; }

        [Column("Target Performance")]
        [StringLength(4000)]
        public string Target_Performance { get; set; }

        [Column("Current Performance")]
        [StringLength(4000)]
        public string Current_Performance { get; set; }

        [Column("Product Owner")]
        [StringLength(4000)]
        public string Product_Owner { get; set; }

        [Column("Metric Link")]
        [StringLength(4000)]
        public string Metric_Link { get; set; }

        [Key]
        [Column("Program Object", Order = 21)]
        public bool Program_Object { get; set; }
    }
}
