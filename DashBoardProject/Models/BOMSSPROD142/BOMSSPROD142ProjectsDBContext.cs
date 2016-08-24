namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BOMSSPROD142ProjectsDBContext : DbContext
    {
        public BOMSSPROD142ProjectsDBContext()
            : base("name=BOMSSPROD142ProjectsDBContext")
        {
        }

        public virtual DbSet<MSP_EpmAssignment> MSP_EpmAssignment { get; set; }
        public virtual DbSet<MSP_EpmAssignmentBaseline> MSP_EpmAssignmentBaseline { get; set; }
        public virtual DbSet<MSP_EpmAssignmentBaselineByDay> MSP_EpmAssignmentBaselineByDay { get; set; }
        public virtual DbSet<MSP_EpmAssignmentBooking> MSP_EpmAssignmentBooking { get; set; }
        public virtual DbSet<MSP_EpmAssignmentByDay> MSP_EpmAssignmentByDay { get; set; }
        public virtual DbSet<MSP_EpmAssignmentType> MSP_EpmAssignmentType { get; set; }
        public virtual DbSet<MSP_EpmCFValueUID> MSP_EpmCFValueUID { get; set; }
        public virtual DbSet<MSP_EpmCPAssnStr0> MSP_EpmCPAssnStr0 { get; set; }
        public virtual DbSet<MSP_EpmCPAssnUid0> MSP_EpmCPAssnUid0 { get; set; }
        public virtual DbSet<MSP_EpmCPAssnVar0> MSP_EpmCPAssnVar0 { get; set; }
        public virtual DbSet<MSP_EpmCPPrjStr0> MSP_EpmCPPrjStr0 { get; set; }
        public virtual DbSet<MSP_EpmCPPrjStr1> MSP_EpmCPPrjStr1 { get; set; }
        public virtual DbSet<MSP_EpmCPPrjStr2> MSP_EpmCPPrjStr2 { get; set; }
        public virtual DbSet<MSP_EpmCPPrjUid0> MSP_EpmCPPrjUid0 { get; set; }
        public virtual DbSet<MSP_EpmCPPrjVar0> MSP_EpmCPPrjVar0 { get; set; }
        public virtual DbSet<MSP_EpmCPResStr0> MSP_EpmCPResStr0 { get; set; }
        public virtual DbSet<MSP_EpmCPResUid0> MSP_EpmCPResUid0 { get; set; }
        public virtual DbSet<MSP_EpmCPTaskStr0> MSP_EpmCPTaskStr0 { get; set; }
        public virtual DbSet<MSP_EpmCPTaskUid0> MSP_EpmCPTaskUid0 { get; set; }
        public virtual DbSet<MSP_EpmCPTaskVar0> MSP_EpmCPTaskVar0 { get; set; }
        public virtual DbSet<MSP_EpmCustomFieldAssociation> MSP_EpmCustomFieldAssociation { get; set; }
        public virtual DbSet<MSP_EpmEnterpriseProjectType> MSP_EpmEnterpriseProjectType { get; set; }
        public virtual DbSet<MSP_EpmInternalProjectHierarchies> MSP_EpmInternalProjectHierarchies { get; set; }
        public virtual DbSet<MSP_EpmLookupTable> MSP_EpmLookupTable { get; set; }
        public virtual DbSet<MSP_EpmMetadataAttribute> MSP_EpmMetadataAttribute { get; set; }
        public virtual DbSet<MSP_EpmMetadataAttributeOlapDepartments> MSP_EpmMetadataAttributeOlapDepartments { get; set; }
        public virtual DbSet<MSP_EpmMetadataAttributeOlapSetting> MSP_EpmMetadataAttributeOlapSetting { get; set; }
        public virtual DbSet<MSP_EpmMetadataColumnPool> MSP_EpmMetadataColumnPool { get; set; }
        public virtual DbSet<MSP_EpmMetadataDimension> MSP_EpmMetadataDimension { get; set; }
        public virtual DbSet<MSP_EpmMetadataEntities> MSP_EpmMetadataEntities { get; set; }
        public virtual DbSet<MSP_EpmMetadataOlapAggregationType> MSP_EpmMetadataOlapAggregationType { get; set; }
        public virtual DbSet<MSP_EpmMetadataProjectType> MSP_EpmMetadataProjectType { get; set; }
        public virtual DbSet<MSP_EpmMetadataTransferLastKnownRevision> MSP_EpmMetadataTransferLastKnownRevision { get; set; }
        public virtual DbSet<MSP_EpmOlapDatabase> MSP_EpmOlapDatabase { get; set; }
        public virtual DbSet<MSP_EpmProject> MSP_EpmProject { get; set; }
        public virtual DbSet<MSP_EpmProjectCommit> MSP_EpmProjectCommit { get; set; }
        public virtual DbSet<MSP_EpmResource> MSP_EpmResource { get; set; }
        public virtual DbSet<MSP_EpmResourceByDay> MSP_EpmResourceByDay { get; set; }
        public virtual DbSet<MSP_EpmResourceStatus> MSP_EpmResourceStatus { get; set; }
        public virtual DbSet<MSP_EpmResourceType> MSP_EpmResourceType { get; set; }
        public virtual DbSet<MSP_EpmTask> MSP_EpmTask { get; set; }
        public virtual DbSet<MSP_EpmTaskBaseline> MSP_EpmTaskBaseline { get; set; }
        public virtual DbSet<MSP_EpmTaskBaselineByDay> MSP_EpmTaskBaselineByDay { get; set; }
        public virtual DbSet<MSP_EpmTaskByDay> MSP_EpmTaskByDay { get; set; }
        public virtual DbSet<MSP_EpmTaskClassAssociation> MSP_EpmTaskClassAssociation { get; set; }
        public virtual DbSet<MSP_EpmTimesheetClass> MSP_EpmTimesheetClass { get; set; }
        public virtual DbSet<MSP_EpmWorkflowPhase> MSP_EpmWorkflowPhase { get; set; }
        public virtual DbSet<MSP_EpmWorkflowStage> MSP_EpmWorkflowStage { get; set; }
        public virtual DbSet<MSP_EpmWorkflowStatusInformation> MSP_EpmWorkflowStatusInformation { get; set; }
        public virtual DbSet<MSP_EpmWorkflowStatusType> MSP_EpmWorkflowStatusType { get; set; }
        public virtual DbSet<MSP_LocalizedString> MSP_LocalizedString { get; set; }
        public virtual DbSet<MSP_TimeByDay> MSP_TimeByDay { get; set; }
        public virtual DbSet<MSP_Timesheet> MSP_Timesheet { get; set; }
        public virtual DbSet<MSP_TimesheetActual> MSP_TimesheetActual { get; set; }
        public virtual DbSet<MSP_TimesheetClass> MSP_TimesheetClass { get; set; }
        public virtual DbSet<MSP_TimesheetCustomFieldAssociation> MSP_TimesheetCustomFieldAssociation { get; set; }
        public virtual DbSet<MSP_TimesheetLine> MSP_TimesheetLine { get; set; }
        public virtual DbSet<MSP_TimesheetLineStatus> MSP_TimesheetLineStatus { get; set; }
        public virtual DbSet<MSP_TimesheetPeriod> MSP_TimesheetPeriod { get; set; }
        public virtual DbSet<MSP_TimesheetPeriodStatus> MSP_TimesheetPeriodStatus { get; set; }
        public virtual DbSet<MSP_TimesheetProject> MSP_TimesheetProject { get; set; }
        public virtual DbSet<MSP_TimesheetResource> MSP_TimesheetResource { get; set; }
        public virtual DbSet<MSP_TimesheetStatus> MSP_TimesheetStatus { get; set; }
        public virtual DbSet<MSP_TimesheetTask> MSP_TimesheetTask { get; set; }
        public virtual DbSet<MSP_WssDeliverable> MSP_WssDeliverable { get; set; }
        public virtual DbSet<MSP_WssInternalListChangeTokens> MSP_WssInternalListChangeTokens { get; set; }
        public virtual DbSet<MSP_WssIssue> MSP_WssIssue { get; set; }
        public virtual DbSet<MSP_WssListItemAssociation> MSP_WssListItemAssociation { get; set; }
        public virtual DbSet<MSP_WssRelationshipType> MSP_WssRelationshipType { get; set; }
        public virtual DbSet<MSP_WssRisk> MSP_WssRisk { get; set; }
        public virtual DbSet<Version> Versions { get; set; }
        public virtual DbSet<MSP_AdminStatus> MSP_AdminStatus { get; set; }
        public virtual DbSet<MSP_EpmOptimizerDecisionType> MSP_EpmOptimizerDecisionType { get; set; }
        public virtual DbSet<MSP_EpmPlannerDecisionType> MSP_EpmPlannerDecisionType { get; set; }
        public virtual DbSet<MSP_EpmAssignment_UserView> MSP_EpmAssignment_UserView { get; set; }
        public virtual DbSet<MSP_EpmAssignmentBooking_OlapView> MSP_EpmAssignmentBooking_OlapView { get; set; }
        public virtual DbSet<MSP_EpmAssignmentByDay_UserView> MSP_EpmAssignmentByDay_UserView { get; set; }
        public virtual DbSet<MSP_EpmAssignmentType_OlapView> MSP_EpmAssignmentType_OlapView { get; set; }
        public virtual DbSet<MSP_EpmFlagLookupTable_OlapView> MSP_EpmFlagLookupTable_OlapView { get; set; }
        public virtual DbSet<MSP_EpmProject_UserView> MSP_EpmProject_UserView { get; set; }
        public virtual DbSet<MSP_EpmProjectDecision_UserView> MSP_EpmProjectDecision_UserView { get; set; }
        public virtual DbSet<MSP_EpmResource_UserView> MSP_EpmResource_UserView { get; set; }
        public virtual DbSet<MSP_EpmResourceByDay_UserView> MSP_EpmResourceByDay_UserView { get; set; }
        public virtual DbSet<MSP_EpmResourceStatus_OlapView> MSP_EpmResourceStatus_OlapView { get; set; }
        public virtual DbSet<MSP_EpmResourceType_OlapView> MSP_EpmResourceType_OlapView { get; set; }
        public virtual DbSet<MSP_EpmTask_UserView> MSP_EpmTask_UserView { get; set; }
        public virtual DbSet<MSP_EpmTaskByDay_UserView> MSP_EpmTaskByDay_UserView { get; set; }
        public virtual DbSet<MSP_TimeByDay_OlapView> MSP_TimeByDay_OlapView { get; set; }
        public virtual DbSet<MSP_Timesheet_OlapView> MSP_Timesheet_OlapView { get; set; }
        public virtual DbSet<MSP_TimesheetActual_OlapView> MSP_TimesheetActual_OlapView { get; set; }
        public virtual DbSet<MSP_TimesheetClass_OlapView> MSP_TimesheetClass_OlapView { get; set; }
        public virtual DbSet<MSP_TimesheetLine_OlapView> MSP_TimesheetLine_OlapView { get; set; }
        public virtual DbSet<MSP_TimesheetLine_UserView> MSP_TimesheetLine_UserView { get; set; }
        public virtual DbSet<MSP_TimesheetLine_UserViewCF> MSP_TimesheetLine_UserViewCF { get; set; }
        public virtual DbSet<MSP_TimesheetLineStatus_OlapView> MSP_TimesheetLineStatus_OlapView { get; set; }
        public virtual DbSet<MSP_TimesheetPeriod_OlapView> MSP_TimesheetPeriod_OlapView { get; set; }
        public virtual DbSet<MSP_TimesheetPeriodStatus_OlapView> MSP_TimesheetPeriodStatus_OlapView { get; set; }
        public virtual DbSet<MSP_TimesheetProject_OlapView> MSP_TimesheetProject_OlapView { get; set; }
        public virtual DbSet<MSP_TimesheetResource_OlapView> MSP_TimesheetResource_OlapView { get; set; }
        public virtual DbSet<MSP_TimesheetStatus_OlapView> MSP_TimesheetStatus_OlapView { get; set; }
        public virtual DbSet<MSP_TimesheetTask_OlapView> MSP_TimesheetTask_OlapView { get; set; }
        public virtual DbSet<MSP_WssDeliverable_OlapView> MSP_WssDeliverable_OlapView { get; set; }
        public virtual DbSet<MSP_WssDeliverableToProjectLinks_UserView> MSP_WssDeliverableToProjectLinks_UserView { get; set; }
        public virtual DbSet<MSP_WssDeliverableToTaskLinks_UserView> MSP_WssDeliverableToTaskLinks_UserView { get; set; }
        public virtual DbSet<MSP_WssIssue_OlapView> MSP_WssIssue_OlapView { get; set; }
        public virtual DbSet<MSP_WssIssueToIssueLinks_UserView> MSP_WssIssueToIssueLinks_UserView { get; set; }
        public virtual DbSet<MSP_WssIssueToRiskLinks_UserView> MSP_WssIssueToRiskLinks_UserView { get; set; }
        public virtual DbSet<MSP_WssIssueToTaskLinks_UserView> MSP_WssIssueToTaskLinks_UserView { get; set; }
        public virtual DbSet<MSP_WssRisk_OlapView> MSP_WssRisk_OlapView { get; set; }
        public virtual DbSet<MSP_WssRiskToIssueLinks_UserView> MSP_WssRiskToIssueLinks_UserView { get; set; }
        public virtual DbSet<MSP_WssRiskToRiskLinks_UserView> MSP_WssRiskToRiskLinks_UserView { get; set; }
        public virtual DbSet<MSP_WssRiskToTaskLinks_UserView> MSP_WssRiskToTaskLinks_UserView { get; set; }
        public virtual DbSet<MSPCFASSN_Component1_Network_T_AssociationView> MSPCFASSN_Component1_Network_T_AssociationView { get; set; }
        public virtual DbSet<MSPCFASSN_Component2_Network_T_AssociationView> MSPCFASSN_Component2_Network_T_AssociationView { get; set; }
        public virtual DbSet<MSPCFASSN_Component3_Network_T_AssociationView> MSPCFASSN_Component3_Network_T_AssociationView { get; set; }
        public virtual DbSet<MSPCFASSN_Component4_Network_T_AssociationView> MSPCFASSN_Component4_Network_T_AssociationView { get; set; }
        public virtual DbSet<MSPCFASSN_Component5_Network_T_AssociationView> MSPCFASSN_Component5_Network_T_AssociationView { get; set; }
        public virtual DbSet<MSPCFASSN_Component6_Network_T_AssociationView> MSPCFASSN_Component6_Network_T_AssociationView { get; set; }
        public virtual DbSet<MSPCFASSN_Fab_Generic_T_AssociationView> MSPCFASSN_Fab_Generic_T_AssociationView { get; set; }
        public virtual DbSet<MSPCFASSN_PLM_Factory_Network_T_AssociationView> MSPCFASSN_PLM_Factory_Network_T_AssociationView { get; set; }
        public virtual DbSet<MSPCFASSN_Product_Network_T_AssociationView> MSPCFASSN_Product_Network_T_AssociationView { get; set; }
        public virtual DbSet<MSPCFPRJ_Additional_Programs_AssociationView> MSPCFPRJ_Additional_Programs_AssociationView { get; set; }
        public virtual DbSet<MSPCFPRJ_Benefit_Metrics_AssociationView> MSPCFPRJ_Benefit_Metrics_AssociationView { get; set; }
        public virtual DbSet<MSPCFPRJ_Benefits_Metrics_AssociationView> MSPCFPRJ_Benefits_Metrics_AssociationView { get; set; }
        public virtual DbSet<MSPCFPRJ_Finance_area_of_impact_AssociationView> MSPCFPRJ_Finance_area_of_impact_AssociationView { get; set; }
        public virtual DbSet<MSPCFPRJ_Network_Priorities_AssociationView> MSPCFPRJ_Network_Priorities_AssociationView { get; set; }
        public virtual DbSet<MSPCFPRJ_OCT_Programs_AssociationView> MSPCFPRJ_OCT_Programs_AssociationView { get; set; }
        public virtual DbSet<MSPCFPRJ_Region_AssociationView> MSPCFPRJ_Region_AssociationView { get; set; }
        public virtual DbSet<MSPCFPRJ_Sample_Primary_Objectives_AssociationView> MSPCFPRJ_Sample_Primary_Objectives_AssociationView { get; set; }
        public virtual DbSet<MSPCFPRJ_Stakeholder_Programs_AssociationView> MSPCFPRJ_Stakeholder_Programs_AssociationView { get; set; }
        public virtual DbSet<MSPCFTASK_Component1_Network_AssociationView> MSPCFTASK_Component1_Network_AssociationView { get; set; }
        public virtual DbSet<MSPCFTASK_Component2_Network_AssociationView> MSPCFTASK_Component2_Network_AssociationView { get; set; }
        public virtual DbSet<MSPCFTASK_Component3_Network_AssociationView> MSPCFTASK_Component3_Network_AssociationView { get; set; }
        public virtual DbSet<MSPCFTASK_Component4_Network_AssociationView> MSPCFTASK_Component4_Network_AssociationView { get; set; }
        public virtual DbSet<MSPCFTASK_Component5_Network_AssociationView> MSPCFTASK_Component5_Network_AssociationView { get; set; }
        public virtual DbSet<MSPCFTASK_Component6_Network_AssociationView> MSPCFTASK_Component6_Network_AssociationView { get; set; }
        public virtual DbSet<MSPCFTASK_Fab_Generic_AssociationView> MSPCFTASK_Fab_Generic_AssociationView { get; set; }
        public virtual DbSet<MSPCFTASK_PLM_Factory_Network_AssociationView> MSPCFTASK_PLM_Factory_Network_AssociationView { get; set; }
        public virtual DbSet<MSPCFTASK_Product_Network_AssociationView> MSPCFTASK_Product_Network_AssociationView { get; set; }
        public virtual DbSet<MSPLT_Budget_Type_OlapView> MSPLT_Budget_Type_OlapView { get; set; }
        public virtual DbSet<MSPLT_Budget_Type_UserView> MSPLT_Budget_Type_UserView { get; set; }
        public virtual DbSet<MSPLT_Business_Process_OlapView> MSPLT_Business_Process_OlapView { get; set; }
        public virtual DbSet<MSPLT_Business_Process_UserView> MSPLT_Business_Process_UserView { get; set; }
        public virtual DbSet<MSPLT_Cost_Type_OlapView> MSPLT_Cost_Type_OlapView { get; set; }
        public virtual DbSet<MSPLT_Cost_Type_UserView> MSPLT_Cost_Type_UserView { get; set; }
        public virtual DbSet<MSPLT_Department_Cost_Center_OlapView> MSPLT_Department_Cost_Center_OlapView { get; set; }
        public virtual DbSet<MSPLT_Department_Cost_Center_UserView> MSPLT_Department_Cost_Center_UserView { get; set; }
        public virtual DbSet<MSPLT_Department_OlapView> MSPLT_Department_OlapView { get; set; }
        public virtual DbSet<MSPLT_Department_UserView> MSPLT_Department_UserView { get; set; }
        public virtual DbSet<MSPLT_Executive_Sponsor_OlapView> MSPLT_Executive_Sponsor_OlapView { get; set; }
        public virtual DbSet<MSPLT_Executive_Sponsor_UserView> MSPLT_Executive_Sponsor_UserView { get; set; }
        public virtual DbSet<MSPLT_Fab_Generic_OlapView> MSPLT_Fab_Generic_OlapView { get; set; }
        public virtual DbSet<MSPLT_Fab_Generic_UserView> MSPLT_Fab_Generic_UserView { get; set; }
        public virtual DbSet<MSPLT_Fac_Activity_Code_OlapView> MSPLT_Fac_Activity_Code_OlapView { get; set; }
        public virtual DbSet<MSPLT_Fac_Activity_Code_UserView> MSPLT_Fac_Activity_Code_UserView { get; set; }
        public virtual DbSet<MSPLT_FIAreaOfImpact_OlapView> MSPLT_FIAreaOfImpact_OlapView { get; set; }
        public virtual DbSet<MSPLT_FIAreaOfImpact_UserView> MSPLT_FIAreaOfImpact_UserView { get; set; }
        public virtual DbSet<MSPLT_Geographic_Scope_OlapView> MSPLT_Geographic_Scope_OlapView { get; set; }
        public virtual DbSet<MSPLT_Geographic_Scope_UserView> MSPLT_Geographic_Scope_UserView { get; set; }
        public virtual DbSet<MSPLT_Health_OlapView> MSPLT_Health_OlapView { get; set; }
        public virtual DbSet<MSPLT_Health_UserView> MSPLT_Health_UserView { get; set; }
        public virtual DbSet<MSPLT_HR_Strategic_Objectives_OlapView> MSPLT_HR_Strategic_Objectives_OlapView { get; set; }
        public virtual DbSet<MSPLT_HR_Strategic_Objectives_UserView> MSPLT_HR_Strategic_Objectives_UserView { get; set; }
        public virtual DbSet<MSPLT_HRAreaOfImpact_OlapView> MSPLT_HRAreaOfImpact_OlapView { get; set; }
        public virtual DbSet<MSPLT_HRAreaOfImpact_UserView> MSPLT_HRAreaOfImpact_UserView { get; set; }
        public virtual DbSet<MSPLT_HRSystemsImpacted_OlapView> MSPLT_HRSystemsImpacted_OlapView { get; set; }
        public virtual DbSet<MSPLT_HRSystemsImpacted_UserView> MSPLT_HRSystemsImpacted_UserView { get; set; }
        public virtual DbSet<MSPLT_Methodology_OlapView> MSPLT_Methodology_OlapView { get; set; }
        public virtual DbSet<MSPLT_Methodology_UserView> MSPLT_Methodology_UserView { get; set; }
        public virtual DbSet<MSPLT_Metric_OlapView> MSPLT_Metric_OlapView { get; set; }
        public virtual DbSet<MSPLT_Metric_UserView> MSPLT_Metric_UserView { get; set; }
        public virtual DbSet<MSPLT_Network_Priorities_OlapView> MSPLT_Network_Priorities_OlapView { get; set; }
        public virtual DbSet<MSPLT_Network_Priorities_UserView> MSPLT_Network_Priorities_UserView { get; set; }
        public virtual DbSet<MSPLT_Org_Subunit_OlapView> MSPLT_Org_Subunit_OlapView { get; set; }
        public virtual DbSet<MSPLT_Org_Subunit_UserView> MSPLT_Org_Subunit_UserView { get; set; }
        public virtual DbSet<MSPLT_Org_Unit_OlapView> MSPLT_Org_Unit_OlapView { get; set; }
        public virtual DbSet<MSPLT_Org_Unit_UserView> MSPLT_Org_Unit_UserView { get; set; }
        public virtual DbSet<MSPLT_Organization_OlapView> MSPLT_Organization_OlapView { get; set; }
        public virtual DbSet<MSPLT_Organization_UserView> MSPLT_Organization_UserView { get; set; }
        public virtual DbSet<MSPLT_PLM_Factory_Network_OlapView> MSPLT_PLM_Factory_Network_OlapView { get; set; }
        public virtual DbSet<MSPLT_PLM_Factory_Network_UserView> MSPLT_PLM_Factory_Network_UserView { get; set; }
        public virtual DbSet<MSPLT_PLM_Milestone_OlapView> MSPLT_PLM_Milestone_OlapView { get; set; }
        public virtual DbSet<MSPLT_PLM_Milestone_UserView> MSPLT_PLM_Milestone_UserView { get; set; }
        public virtual DbSet<MSPLT_PLM_Segment_OlapView> MSPLT_PLM_Segment_OlapView { get; set; }
        public virtual DbSet<MSPLT_PLM_Segment_UserView> MSPLT_PLM_Segment_UserView { get; set; }
        public virtual DbSet<MSPLT_Portfolio_Domain_OlapView> MSPLT_Portfolio_Domain_OlapView { get; set; }
        public virtual DbSet<MSPLT_Portfolio_Domain_UserView> MSPLT_Portfolio_Domain_UserView { get; set; }
        public virtual DbSet<MSPLT_Portfolio_Service_UserView> MSPLT_Portfolio_Service_UserView { get; set; }
        public virtual DbSet<MSPLT_Portfolio_UserView> MSPLT_Portfolio_UserView { get; set; }
        public virtual DbSet<MSPLT_Primary_Objective_OlapView> MSPLT_Primary_Objective_OlapView { get; set; }
        public virtual DbSet<MSPLT_Primary_Objective_UserView> MSPLT_Primary_Objective_UserView { get; set; }
        public virtual DbSet<MSPLT_Primary_Service_OlapView> MSPLT_Primary_Service_OlapView { get; set; }
        public virtual DbSet<MSPLT_Primary_Service_UserView> MSPLT_Primary_Service_UserView { get; set; }
        public virtual DbSet<MSPLT_Program_OlapView> MSPLT_Program_OlapView { get; set; }
        public virtual DbSet<MSPLT_Program_UserView> MSPLT_Program_UserView { get; set; }
        public virtual DbSet<MSPLT_Project_Impact_OlapView> MSPLT_Project_Impact_OlapView { get; set; }
        public virtual DbSet<MSPLT_Project_Impact_UserView> MSPLT_Project_Impact_UserView { get; set; }
        public virtual DbSet<MSPLT_Project_Phase_OlapView> MSPLT_Project_Phase_OlapView { get; set; }
        public virtual DbSet<MSPLT_Project_Phase_UserView> MSPLT_Project_Phase_UserView { get; set; }
        public virtual DbSet<MSPLT_Project_State_OlapView> MSPLT_Project_State_OlapView { get; set; }
        public virtual DbSet<MSPLT_Project_State_UserView> MSPLT_Project_State_UserView { get; set; }
        public virtual DbSet<MSPLT_Project_Tier_OlapView> MSPLT_Project_Tier_OlapView { get; set; }
        public virtual DbSet<MSPLT_Project_Tier_UserView> MSPLT_Project_Tier_UserView { get; set; }
        public virtual DbSet<MSPLT_RBS_OlapView> MSPLT_RBS_OlapView { get; set; }
        public virtual DbSet<MSPLT_RBS_UserView> MSPLT_RBS_UserView { get; set; }
        public virtual DbSet<MSPLT_Region_OlapView> MSPLT_Region_OlapView { get; set; }
        public virtual DbSet<MSPLT_Region_UserView> MSPLT_Region_UserView { get; set; }
        public virtual DbSet<MSPLT_Relative_Importance_OlapView> MSPLT_Relative_Importance_OlapView { get; set; }
        public virtual DbSet<MSPLT_Relative_Importance_UserView> MSPLT_Relative_Importance_UserView { get; set; }
        public virtual DbSet<MSPLT_Sample_Areas_Impacted_OlapView> MSPLT_Sample_Areas_Impacted_OlapView { get; set; }
        public virtual DbSet<MSPLT_Sample_Areas_Impacted_UserView> MSPLT_Sample_Areas_Impacted_UserView { get; set; }
        public virtual DbSet<MSPLT_Sample_Primary_Objective_OlapView> MSPLT_Sample_Primary_Objective_OlapView { get; set; }
        public virtual DbSet<MSPLT_Sample_Primary_Objective_UserView> MSPLT_Sample_Primary_Objective_UserView { get; set; }
        public virtual DbSet<MSPLT_Site_OlapView> MSPLT_Site_OlapView { get; set; }
        public virtual DbSet<MSPLT_Site_UserView> MSPLT_Site_UserView { get; set; }
        public virtual DbSet<MSPLT_State_of_Project_OlapView> MSPLT_State_of_Project_OlapView { get; set; }
        public virtual DbSet<MSPLT_State_of_Project_UserView> MSPLT_State_of_Project_UserView { get; set; }
        public virtual DbSet<MSPLT_State_OlapView> MSPLT_State_OlapView { get; set; }
        public virtual DbSet<MSPLT_State_UserView> MSPLT_State_UserView { get; set; }
        public virtual DbSet<MSPLT_Strategic_Objective_OlapView> MSPLT_Strategic_Objective_OlapView { get; set; }
        public virtual DbSet<MSPLT_Strategic_Objective_UserView> MSPLT_Strategic_Objective_UserView { get; set; }
        public virtual DbSet<MSPLT_Traffic_Light_OlapView> MSPLT_Traffic_Light_OlapView { get; set; }
        public virtual DbSet<MSPLT_Traffic_Light_UserView> MSPLT_Traffic_Light_UserView { get; set; }
        public virtual DbSet<MSPLT_Worker_Role_OlapView> MSPLT_Worker_Role_OlapView { get; set; }
        public virtual DbSet<MSPLT_Worker_Role_UserView> MSPLT_Worker_Role_UserView { get; set; }
        public virtual DbSet<vw_MSP_EpmProject_IS> vw_MSP_EpmProject_IS { get; set; }
        public virtual DbSet<vw_MSP_EpmProject_IS_ProjectNames> vw_MSP_EpmProject_IS_ProjectNames { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MSP_EpmAssignment>()
                .Property(e => e.AssignmentCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment>()
                .Property(e => e.AssignmentOvertimeCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment>()
                .Property(e => e.AssignmentActualCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment>()
                .Property(e => e.AssignmentActualOvertimeCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment>()
                .Property(e => e.AssignmentWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment>()
                .Property(e => e.AssignmentOvertimeWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment>()
                .Property(e => e.AssignmentActualWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment>()
                .Property(e => e.AssignmentActualOvertimeWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment>()
                .Property(e => e.AssignmentMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment>()
                .Property(e => e.AssignmentMaterialActualWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment>()
                .Property(e => e.AssignmentDelay)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment>()
                .Property(e => e.AssignmentStartVariance)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment>()
                .Property(e => e.AssignmentFinishVariance)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment>()
                .Property(e => e.AssignmentACWP)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment>()
                .Property(e => e.AssignmentBCWP)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment>()
                .Property(e => e.AssignmentBCWS)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment>()
                .Property(e => e.AssignmentCostVariance)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment>()
                .Property(e => e.AssignmentWorkVariance)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment>()
                .Property(e => e.AssignmentCV)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment>()
                .Property(e => e.AssignmentSV)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment>()
                .Property(e => e.AssignmentVAC)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment>()
                .Property(e => e.AssignmentPeakUnits)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment>()
                .Property(e => e.AssignmentBudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment>()
                .Property(e => e.AssignmentBudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment>()
                .Property(e => e.AssignmentBudgetMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment>()
                .Property(e => e.AssignmentResourcePlanWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment>()
                .HasMany(e => e.MSP_EpmAssignmentByDay)
                .WithRequired(e => e.MSP_EpmAssignment)
                .HasForeignKey(e => new { e.AssignmentUID, e.ProjectUID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmAssignmentBaseline>()
                .Property(e => e.AssignmentBaselineCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentBaseline>()
                .Property(e => e.AssignmentBaselineWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentBaseline>()
                .Property(e => e.AssignmentBaselineMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentBaseline>()
                .Property(e => e.AssignmentBaselineBudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentBaseline>()
                .Property(e => e.AssignmentBaselineBudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentBaseline>()
                .Property(e => e.AssignmentBaselineBudgetMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentBaseline>()
                .HasMany(e => e.MSP_EpmAssignmentBaselineByDay)
                .WithRequired(e => e.MSP_EpmAssignmentBaseline)
                .HasForeignKey(e => new { e.BaselineNumber, e.AssignmentUID, e.ProjectUID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmAssignmentBaselineByDay>()
                .Property(e => e.AssignmentBaselineCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentBaselineByDay>()
                .Property(e => e.AssignmentBaselineWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentBaselineByDay>()
                .Property(e => e.AssignmentBaselineMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentBaselineByDay>()
                .Property(e => e.AssignmentBaselineBudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentBaselineByDay>()
                .Property(e => e.AssignmentBaselineBudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentBaselineByDay>()
                .Property(e => e.AssignmentBaselineBudgetMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentBooking>()
                .HasMany(e => e.MSP_EpmAssignment)
                .WithRequired(e => e.MSP_EpmAssignmentBooking)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmAssignmentByDay>()
                .Property(e => e.AssignmentCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay>()
                .Property(e => e.AssignmentOvertimeCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay>()
                .Property(e => e.AssignmentActualCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay>()
                .Property(e => e.AssignmentActualOvertimeCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay>()
                .Property(e => e.AssignmentWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay>()
                .Property(e => e.AssignmentOvertimeWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay>()
                .Property(e => e.AssignmentActualWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay>()
                .Property(e => e.AssignmentActualOvertimeWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay>()
                .Property(e => e.AssignmentMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay>()
                .Property(e => e.AssignmentMaterialActualWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay>()
                .Property(e => e.AssignmentBudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay>()
                .Property(e => e.AssignmentBudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay>()
                .Property(e => e.AssignmentBudgetMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay>()
                .Property(e => e.AssignmentResourcePlanWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentType>()
                .HasMany(e => e.MSP_EpmAssignment)
                .WithRequired(e => e.MSP_EpmAssignmentType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmMetadataAttribute>()
                .HasMany(e => e.MSP_EpmCustomFieldAssociation)
                .WithRequired(e => e.MSP_EpmMetadataAttribute)
                .HasForeignKey(e => e.CustomFieldTypeUID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmMetadataAttribute>()
                .HasMany(e => e.MSP_TimesheetCustomFieldAssociation)
                .WithRequired(e => e.MSP_EpmMetadataAttribute)
                .HasForeignKey(e => e.CustomFieldTypeUID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmMetadataColumnPool>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<MSP_EpmMetadataColumnPool>()
                .Property(e => e.ColumnNameForCFValue)
                .IsUnicode(false);

            modelBuilder.Entity<MSP_EpmMetadataColumnPool>()
                .HasMany(e => e.MSP_EpmMetadataAttribute)
                .WithOptional(e => e.MSP_EpmMetadataColumnPool)
                .HasForeignKey(e => e.CustomFieldColumnID);

            modelBuilder.Entity<MSP_EpmMetadataColumnPool>()
                .HasMany(e => e.MSP_EpmMetadataAttribute1)
                .WithOptional(e => e.MSP_EpmMetadataColumnPool1)
                .HasForeignKey(e => e.CustomFieldWeightColumnID);

            modelBuilder.Entity<MSP_EpmMetadataDimension>()
                .HasMany(e => e.MSP_EpmCustomFieldAssociation)
                .WithRequired(e => e.MSP_EpmMetadataDimension)
                .HasForeignKey(e => e.LookupTableUID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmMetadataDimension>()
                .HasMany(e => e.MSP_EpmLookupTable)
                .WithRequired(e => e.MSP_EpmMetadataDimension)
                .HasForeignKey(e => e.LookupTableUID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmMetadataEntities>()
                .HasMany(e => e.MSP_EpmMetadataAttribute)
                .WithRequired(e => e.MSP_EpmMetadataEntities)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmMetadataOlapAggregationType>()
                .HasMany(e => e.MSP_EpmMetadataAttribute)
                .WithRequired(e => e.MSP_EpmMetadataOlapAggregationType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmMetadataProjectType>()
                .HasMany(e => e.MSP_EpmMetadataAttribute)
                .WithRequired(e => e.MSP_EpmMetadataProjectType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmProject>()
                .HasMany(e => e.MSP_EpmAssignment)
                .WithRequired(e => e.MSP_EpmProject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmProject>()
                .HasMany(e => e.MSP_EpmAssignmentBaseline)
                .WithRequired(e => e.MSP_EpmProject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmProject>()
                .HasMany(e => e.MSP_EpmAssignmentBaselineByDay)
                .WithRequired(e => e.MSP_EpmProject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmProject>()
                .HasMany(e => e.MSP_EpmAssignmentByDay)
                .WithRequired(e => e.MSP_EpmProject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmProject>()
                .HasOptional(e => e.MSP_EpmProjectCommit)
                .WithRequired(e => e.MSP_EpmProject);

            modelBuilder.Entity<MSP_EpmProject>()
                .HasMany(e => e.MSP_EpmTask)
                .WithRequired(e => e.MSP_EpmProject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmProject>()
                .HasMany(e => e.MSP_EpmTaskByDay)
                .WithRequired(e => e.MSP_EpmProject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmProject>()
                .HasMany(e => e.MSP_EpmWorkflowStatusInformation)
                .WithRequired(e => e.MSP_EpmProject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmResource>()
                .Property(e => e.ResourceStandardRate)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmResource>()
                .Property(e => e.ResourceOvertimeRate)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmResource>()
                .Property(e => e.ResourceCostPerUse)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmResource>()
                .Property(e => e.ResourceMaxUnits)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmResource>()
                .HasMany(e => e.MSP_EpmAssignment)
                .WithRequired(e => e.MSP_EpmResource)
                .HasForeignKey(e => e.ResourceOwnerUID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmResource>()
                .HasMany(e => e.MSP_EpmAssignment1)
                .WithRequired(e => e.MSP_EpmResource1)
                .HasForeignKey(e => e.ResourceUID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmResource>()
                .HasMany(e => e.MSP_EpmResourceByDay)
                .WithRequired(e => e.MSP_EpmResource)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmResourceByDay>()
                .Property(e => e.BaseCapacity)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmResourceByDay>()
                .Property(e => e.Capacity)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmResourceStatus>()
                .HasMany(e => e.MSP_EpmResource)
                .WithRequired(e => e.MSP_EpmResourceStatus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmResourceType>()
                .HasMany(e => e.MSP_EpmResource)
                .WithRequired(e => e.MSP_EpmResourceType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskFixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskActualFixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskOvertimeCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskActualCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskActualOvertimeCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskOvertimeWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskActualWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskActualOvertimeWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskDurationVariance)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskStartVariance)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskFinishVariance)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskTotalSlack)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskFreeSlack)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskDuration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskActualDuration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskACWP)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskBCWP)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskBCWS)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskLevelingDelay)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskSPI)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskTCPI)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskVAC)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskEAC)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskCostVariance)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskCV)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskCPI)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskSV)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskWorkVariance)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskBudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskBudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .Property(e => e.TaskResourcePlanWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask>()
                .HasMany(e => e.MSP_EpmAssignment)
                .WithRequired(e => e.MSP_EpmTask)
                .HasForeignKey(e => new { e.TaskUID, e.ProjectUID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmTask>()
                .HasMany(e => e.MSP_EpmAssignmentBaseline)
                .WithRequired(e => e.MSP_EpmTask)
                .HasForeignKey(e => new { e.TaskUID, e.ProjectUID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmTask>()
                .HasMany(e => e.MSP_EpmAssignmentBaselineByDay)
                .WithRequired(e => e.MSP_EpmTask)
                .HasForeignKey(e => new { e.TaskUID, e.ProjectUID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmTask>()
                .HasMany(e => e.MSP_EpmAssignmentByDay)
                .WithRequired(e => e.MSP_EpmTask)
                .HasForeignKey(e => new { e.TaskUID, e.ProjectUID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmTask>()
                .HasMany(e => e.MSP_EpmTaskBaseline)
                .WithRequired(e => e.MSP_EpmTask)
                .HasForeignKey(e => new { e.TaskUID, e.ProjectUID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmTask>()
                .HasMany(e => e.MSP_EpmTaskBaselineByDay)
                .WithRequired(e => e.MSP_EpmTask)
                .HasForeignKey(e => new { e.TaskUID, e.ProjectUID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmTask>()
                .HasMany(e => e.MSP_EpmTaskByDay)
                .WithRequired(e => e.MSP_EpmTask)
                .HasForeignKey(e => new { e.TaskUID, e.ProjectUID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmTaskBaseline>()
                .Property(e => e.TaskBaselineCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskBaseline>()
                .Property(e => e.TaskBaselineFixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskBaseline>()
                .Property(e => e.TaskBaselineWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskBaseline>()
                .Property(e => e.TaskBaselineBudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskBaseline>()
                .Property(e => e.TaskBaselineBudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskBaseline>()
                .Property(e => e.TaskBaselineDuration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskBaselineByDay>()
                .Property(e => e.TaskBaselineCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskBaselineByDay>()
                .Property(e => e.TaskBaselineFixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskBaselineByDay>()
                .Property(e => e.TaskBaselineWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskBaselineByDay>()
                .Property(e => e.TaskBaselineBudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskBaselineByDay>()
                .Property(e => e.TaskBaselineBudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTimesheetClass>()
                .HasMany(e => e.MSP_EpmAssignment)
                .WithRequired(e => e.MSP_EpmTimesheetClass)
                .HasForeignKey(e => e.TimesheetClassUID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmWorkflowPhase>()
                .HasMany(e => e.MSP_EpmWorkflowStage)
                .WithRequired(e => e.MSP_EpmWorkflowPhase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmWorkflowStage>()
                .HasMany(e => e.MSP_EpmWorkflowStatusInformation)
                .WithRequired(e => e.MSP_EpmWorkflowStage)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_TimeByDay>()
                .HasMany(e => e.MSP_EpmAssignmentByDay)
                .WithRequired(e => e.MSP_TimeByDay)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_TimeByDay>()
                .HasMany(e => e.MSP_EpmTaskByDay)
                .WithRequired(e => e.MSP_TimeByDay)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_Timesheet>()
                .HasMany(e => e.MSP_TimesheetLine)
                .WithRequired(e => e.MSP_Timesheet)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_TimesheetActual>()
                .Property(e => e.ActualWorkBillable)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_TimesheetActual>()
                .Property(e => e.ActualWorkNonBillable)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_TimesheetActual>()
                .Property(e => e.ActualOvertimeWorkBillable)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_TimesheetActual>()
                .Property(e => e.ActualOvertimeWorkNonBillable)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_TimesheetActual>()
                .Property(e => e.PlannedWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_TimesheetClass>()
                .HasMany(e => e.MSP_TimesheetLine)
                .WithRequired(e => e.MSP_TimesheetClass)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_TimesheetLine>()
                .Property(e => e.LastSavedWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_TimesheetLine>()
                .HasMany(e => e.MSP_TimesheetActual)
                .WithRequired(e => e.MSP_TimesheetLine)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_TimesheetLineStatus>()
                .HasMany(e => e.MSP_TimesheetLine)
                .WithOptional(e => e.MSP_TimesheetLineStatus)
                .HasForeignKey(e => e.TimesheetLineStatus);

            modelBuilder.Entity<MSP_TimesheetPeriod>()
                .HasMany(e => e.MSP_Timesheet)
                .WithRequired(e => e.MSP_TimesheetPeriod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_TimesheetPeriodStatus>()
                .HasMany(e => e.MSP_TimesheetPeriod)
                .WithRequired(e => e.MSP_TimesheetPeriodStatus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_TimesheetProject>()
                .HasMany(e => e.MSP_TimesheetLine)
                .WithRequired(e => e.MSP_TimesheetProject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_TimesheetProject>()
                .HasMany(e => e.MSP_TimesheetProject1)
                .WithOptional(e => e.MSP_TimesheetProject2)
                .HasForeignKey(e => e.ParentProjectNameUID);

            modelBuilder.Entity<MSP_TimesheetResource>()
                .HasMany(e => e.MSP_Timesheet)
                .WithRequired(e => e.MSP_TimesheetResource)
                .HasForeignKey(e => e.OwnerResourceNameUID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_TimesheetResource>()
                .HasMany(e => e.MSP_TimesheetActual)
                .WithRequired(e => e.MSP_TimesheetResource)
                .HasForeignKey(e => e.LastChangedResourceNameUID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_TimesheetResource>()
                .HasMany(e => e.MSP_TimesheetResource1)
                .WithOptional(e => e.MSP_TimesheetResource2)
                .HasForeignKey(e => e.ParentResourceNameUID);

            modelBuilder.Entity<MSP_TimesheetStatus>()
                .HasMany(e => e.MSP_Timesheet)
                .WithRequired(e => e.MSP_TimesheetStatus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_TimesheetTask>()
                .HasMany(e => e.MSP_TimesheetLine)
                .WithRequired(e => e.MSP_TimesheetTask)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_TimesheetTask>()
                .HasMany(e => e.MSP_TimesheetTask1)
                .WithOptional(e => e.MSP_TimesheetTask2)
                .HasForeignKey(e => e.ParentTaskNameUID);

            modelBuilder.Entity<MSP_WssRelationshipType>()
                .HasMany(e => e.MSP_WssListItemAssociation)
                .WithRequired(e => e.MSP_WssRelationshipType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentOvertimeCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentActualCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentActualOvertimeCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentOvertimeWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentActualWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentActualOvertimeWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentMaterialActualWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentDelay)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentStartVariance)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentFinishVariance)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentACWP)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBCWP)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBCWS)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentCostVariance)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentWorkVariance)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentCV)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentSV)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentVAC)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentPeakUnits)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBudgetMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentResourcePlanWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentRegularCost)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentRemainingCost)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentRemainingOvertimeCost)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentActualRegularCost)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentRemainingRegularCost)
                .HasPrecision(27, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentRegularWork)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentRemainingWork)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentRemainingOvertimeWork)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentActualRegularWork)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentRemainingRegularWork)
                .HasPrecision(27, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline0Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline0Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline0MaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline0BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline0BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline0BudgetMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline1Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline1Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline1MaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline1BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline1BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline1BudgetMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline2Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline2Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline2MaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline2BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline2BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline2BudgetMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline3Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline3Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline3MaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline3BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline3BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline3BudgetMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline4Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline4Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline4MaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline4BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline4BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline4BudgetMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline5Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline5Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline5MaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline5BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline5BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline5BudgetMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline6Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline6Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline6MaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline6BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline6BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline6BudgetMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline7Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline7Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline7MaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline7BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline7BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline7BudgetMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline8Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline8Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline8MaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline8BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline8BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline8BudgetMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline9Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline9Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline9MaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline9BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline9BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline9BudgetMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline10Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline10Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline10MaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline10BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline10BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.AssignmentBaseline10BudgetMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignment_UserView>()
                .Property(e => e.TargetPercentComplete_T)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentOvertimeCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentActualCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentActualOvertimeCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentOvertimeWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentActualWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentActualOvertimeWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentMaterialActualWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBudgetMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentResourcePlanWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentRegularCost)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentRemainingCost)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentRemainingOvertimeCost)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentActualRegularCost)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentRemainingRegularCost)
                .HasPrecision(27, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentRegularWork)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentRemainingWork)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentRemainingOvertimeWork)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentActualRegularWork)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentRemainingRegularWork)
                .HasPrecision(27, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentCombinedWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline0Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline0Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline0MaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline0BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline0BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline0BudgetMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline1Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline1Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline1MaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline1BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline1BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline1BudgetMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline2Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline2Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline2MaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline2BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline2BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline2BudgetMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline3Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline3Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline3MaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline3BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline3BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline3BudgetMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline4Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline4Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline4MaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline4BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline4BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline4BudgetMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline5Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline5Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline5MaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline5BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline5BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline5BudgetMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline6Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline6Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline6MaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline6BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline6BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline6BudgetMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline7Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline7Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline7MaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline7BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline7BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline7BudgetMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline8Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline8Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline8MaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline8BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline8BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline8BudgetMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline9Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline9Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline9MaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline9BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline9BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline9BudgetMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline10Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline10Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline10MaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline10BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline10BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmAssignmentByDay_UserView>()
                .Property(e => e.AssignmentBaseline10BudgetMaterialWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectFixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectOvertimeCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectActualCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectActualOvertimeCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectOvertimeWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectActualWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectActualOvertimeWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectDurationVariance)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectStartVariance)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectFinishVariance)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectDuration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectActualDuration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectACWP)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBCWP)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBCWS)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectSPI)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectTCPI)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectVAC)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectEAC)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectCostVariance)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectCV)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectCPI)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectSV)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectWorkVariance)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectResourcePlanWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectRegularCost)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectRemainingCost)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectRemainingOvertimeCost)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectActualRegularCost)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectRemainingRegularCost)
                .HasPrecision(27, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectRegularWork)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectRemainingWork)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectRemainingOvertimeWork)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectActualRegularWork)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectRemainingRegularWork)
                .HasPrecision(27, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectRemainingDuration)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectCVP)
                .HasPrecision(38, 13);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectSVP)
                .HasPrecision(38, 13);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline0Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline0FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline0Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline0BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline0BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline0Duration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline1Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline1FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline1Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline1BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline1BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline1Duration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline2Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline2FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline2Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline2BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline2BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline2Duration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline3Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline3FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline3Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline3BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline3BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline3Duration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline4Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline4FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline4Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline4BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline4BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline4Duration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline5Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline5FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline5Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline5BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline5BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline5Duration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline6Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline6FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline6Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline6BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline6BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline6Duration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline7Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline7FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline7Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline7BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline7BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline7Duration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline8Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline8FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline8Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline8BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline8BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline8Duration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline9Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline9FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline9Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline9BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline9BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline9Duration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline10Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline10FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline10Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline10BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline10BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.ProjectBaseline10Duration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.Project_Prob_of_Success)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.Primary_Benefit_Actual)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.Primary_Benefit_Estimate)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.Primary_Benefit_Risk_Assessed)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.Portfolio_Priority)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.IS_Budget_Capital)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.IS_Budget_Consulting)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.IS_Budget_Expense)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.IS_Budget_FTE)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.IS_Remaining_Capital)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.IS_Remaining_Consulting)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.IS_Remaining_Expense)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.IS_Remaining_FTE)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.HR_Business_Value_Score)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.HR_Efficiency_Score)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.HR_Financial_Score)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.NPV)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.Payback_Period)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.Total_Project_Hours)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.Total_HR_Hours)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.Total_IS_Hours)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmProject_UserView>()
                .Property(e => e.Total_Project_Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmResource_UserView>()
                .Property(e => e.ResourceStandardRate)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmResource_UserView>()
                .Property(e => e.ResourceOvertimeRate)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmResource_UserView>()
                .Property(e => e.ResourceCostPerUse)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmResource_UserView>()
                .Property(e => e.ResourceMaxUnits)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmResourceByDay_UserView>()
                .Property(e => e.BaseCapacity)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmResourceByDay_UserView>()
                .Property(e => e.Capacity)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskFixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskActualFixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskOvertimeCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskActualCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskActualOvertimeCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskOvertimeWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskActualWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskActualOvertimeWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskDurationVariance)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskStartVariance)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskFinishVariance)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskTotalSlack)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskFreeSlack)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskDuration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskActualDuration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskACWP)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBCWP)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBCWS)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskLevelingDelay)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskSPI)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskTCPI)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskVAC)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskEAC)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskCostVariance)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskCV)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskCPI)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskSV)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskWorkVariance)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskResourcePlanWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskRegularCost)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskRemainingCost)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskRemainingOvertimeCost)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskActualRegularCost)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskRemainingRegularCost)
                .HasPrecision(27, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskRegularWork)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskRemainingWork)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskRemainingOvertimeWork)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskActualRegularWork)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskRemainingRegularWork)
                .HasPrecision(27, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskRemainingDuration)
                .HasPrecision(26, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskCVP)
                .HasPrecision(38, 13);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskSVP)
                .HasPrecision(38, 13);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline0Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline0FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline0Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline0BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline0BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline0Duration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline1Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline1FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline1Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline1BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline1BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline1Duration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline2Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline2FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline2Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline2BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline2BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline2Duration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline3Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline3FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline3Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline3BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline3BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline3Duration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline4Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline4FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline4Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline4BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline4BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline4Duration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline5Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline5FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline5Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline5BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline5BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline5Duration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline6Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline6FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline6Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline6BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline6BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline6Duration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline7Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline7FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline7Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline7BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline7BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline7Duration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline8Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline8FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline8Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline8BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline8BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline8Duration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline9Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline9FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline9Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline9BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline9BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline9Duration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline10Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline10FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline10Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline10BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline10BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TaskBaseline10Duration)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTask_UserView>()
                .Property(e => e.TargetPercentComplete)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline0Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline0FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline0Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline0BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline0BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline1Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline1FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline1Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline1BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline1BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline2Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline2FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline2Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline2BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline2BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline3Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline3FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline3Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline3BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline3BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline4Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline4FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline4Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline4BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline4BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline5Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline5FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline5Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline5BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline5BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline6Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline6FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline6Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline6BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline6BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline7Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline7FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline7Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline7BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline7BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline8Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline8FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline8Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline8BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline8BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline9Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline9FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline9Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline9BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline9BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline10Cost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline10FixedCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline10Work)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline10BudgetCost)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_EpmTaskByDay_UserView>()
                .Property(e => e.TaskBaseline10BudgetWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_TimeByDay_OlapView>()
                .Property(e => e.CalendarMemberNameYear)
                .IsUnicode(false);

            modelBuilder.Entity<MSP_TimeByDay_OlapView>()
                .Property(e => e.CalendarMemberNameQuarter)
                .IsUnicode(false);

            modelBuilder.Entity<MSP_TimeByDay_OlapView>()
                .Property(e => e.CalendarMemberNameMonth)
                .IsUnicode(false);

            modelBuilder.Entity<MSP_TimeByDay_OlapView>()
                .Property(e => e.CalendarMemberNameWeek)
                .IsUnicode(false);

            modelBuilder.Entity<MSP_TimeByDay_OlapView>()
                .Property(e => e.CalendarMemberNameDay)
                .IsUnicode(false);

            modelBuilder.Entity<MSP_TimeByDay_OlapView>()
                .Property(e => e.FiscalMemberNameDay)
                .IsUnicode(false);

            modelBuilder.Entity<MSP_TimesheetActual_OlapView>()
                .Property(e => e.ActualWorkBillable)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_TimesheetActual_OlapView>()
                .Property(e => e.ActualWorkNonBillable)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_TimesheetActual_OlapView>()
                .Property(e => e.ActualOvertimeWorkBillable)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_TimesheetActual_OlapView>()
                .Property(e => e.ActualOvertimeWorkNonBillable)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_TimesheetActual_OlapView>()
                .Property(e => e.PlannedWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_TimesheetLine_OlapView>()
                .Property(e => e.LastSavedWork)
                .HasPrecision(25, 6);

            modelBuilder.Entity<MSP_TimesheetLine_UserView>()
                .Property(e => e.PlannedWork)
                .HasPrecision(38, 6);

            modelBuilder.Entity<MSP_TimesheetLine_UserView>()
                .Property(e => e.ActualWorkBillable)
                .HasPrecision(38, 6);

            modelBuilder.Entity<MSP_TimesheetLine_UserView>()
                .Property(e => e.ActualWorkNonBillable)
                .HasPrecision(38, 6);

            modelBuilder.Entity<MSP_TimesheetLine_UserView>()
                .Property(e => e.ActualOvertimeWorkBillable)
                .HasPrecision(38, 6);

            modelBuilder.Entity<MSP_TimesheetLine_UserView>()
                .Property(e => e.ActualOvertimeWorkNonBillable)
                .HasPrecision(38, 6);

            modelBuilder.Entity<MSP_TimesheetLine_UserViewCF>()
                .Property(e => e.PlannedWork)
                .HasPrecision(38, 6);

            modelBuilder.Entity<MSP_TimesheetLine_UserViewCF>()
                .Property(e => e.ActualWorkBillable)
                .HasPrecision(38, 6);

            modelBuilder.Entity<MSP_TimesheetLine_UserViewCF>()
                .Property(e => e.ActualWorkNonBillable)
                .HasPrecision(38, 6);

            modelBuilder.Entity<MSP_TimesheetLine_UserViewCF>()
                .Property(e => e.ActualOvertimeWorkBillable)
                .HasPrecision(38, 6);

            modelBuilder.Entity<MSP_TimesheetLine_UserViewCF>()
                .Property(e => e.ActualOvertimeWorkNonBillable)
                .HasPrecision(38, 6);

            modelBuilder.Entity<vw_MSP_EpmProject_IS>()
                .Property(e => e.First_Portfolio_Submittal)
                .IsUnicode(false);

            modelBuilder.Entity<vw_MSP_EpmProject_IS>()
                .Property(e => e.Proposed_Start)
                .IsUnicode(false);

            modelBuilder.Entity<vw_MSP_EpmProject_IS>()
                .Property(e => e.Proposed_Finish)
                .IsUnicode(false);

            modelBuilder.Entity<vw_MSP_EpmProject_IS>()
                .Property(e => e.Project_Start_Date)
                .IsUnicode(false);

            modelBuilder.Entity<vw_MSP_EpmProject_IS>()
                .Property(e => e.Project_Finish_Date)
                .IsUnicode(false);
        }
    }
}
