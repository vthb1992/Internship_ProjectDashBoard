using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DashBoardProject.Models
{
    public class Project
    {
        public string projectUID { get; set; }
        public string projectID { get; set; }
        public string projectTitle { get; set; }
        public string phase { get; set; }
        public string keySME { get; set; }
        public string projectManager { get; set; }
        public short? actualPercentageCompleted { get; set; }
        public int daysBehindAhead { get; set; }
        public string projectStartDisplay { get; set; }
        public string projectFinishDisplay { get; set; }
        public string baselineFinishDisplay { get; set; }
        public string stateOfProject { get; set; }


        public DateTime? projectStart { get; set; }
        public DateTime? projectFinish { get; set; }
        public DateTime? baselineFinish { get; set; }
    }

    public class ProjectCaseInfo
    {
        public string projectID { get; set; }
        public string projectDesc { get; set; }
        public string methodology { get; set; }
        public string networkPriorities { get; set; }
        public string projectName { get; set; }
        public string projectSponsor { get; set; }
        public string execSponsor { get; set; }
        public string leadArch { get; set; }
        public string refID { get; set; }
        public string program { get; set; }
        public string projectAuthorName { get; set; }
        public string projectManagerName { get; set; }
        public string projectOwner { get; set; }
        public string SME { get; set; }
        public string phase { get; set; }
        public string costStatus { get; set; }
        public string scheduleStatus { get; set; }
        public string scopeStatus { get; set; }
        public string teamStatus { get; set; }
        public DateTime? proposalStart { get; set; }
        public DateTime? proposalFinish { get; set; }
        public DateTime? projectStartDate { get; set; }
        public DateTime? projectFinishDate { get; set; }
        public string projectStartDateDisplay { get; set; }
        public string projectFinishDateDisplay { get; set; }
        public DateTime? baselineStartDate { get; set; }
        public DateTime? baselineFinishDate { get; set; }
        public string baselineStartDateDisplay { get; set; }
        public string baselineFinishDateDisplay { get; set; }
        public DateTime? firstSubmitted { get; set; }
        public decimal? projectDuration { get; set; }
        public decimal? projectRemainingWork { get; set; }
        public string projectWorkspaceInternalHref { get; set; }
        public string portfolio { get; set; } //unused
        public string portfolioDomain { get; set; } //unused
        public string portfolioService { get; set; } //unused
        public string primaryService { get; set; }
        public string projectStkholders { get; set; }
        public string projectDeliverables { get; set; }
        public string problemOpp { get; set; }
        public string projectScope { get; set; }
        public string projectExclusions { get; set; }
        public string projectConstraints { get; set; }
        public string billing { get; set; }
        public string costComment { get; set; }
        public string benefitComment { get; set; }
        public string driverComment { get; set; }

        public Boolean unprovenTechnology { get; set; }
        public string targetPerformance { get; set; }
        public string currentPerformance { get; set; }
        public string coreTeam { get; set; }
        public string projectUID { get; set; }

        public short? actualPercentageCompleted { get; set; }

        public string resourceStatus { get; set; }
        public string resourceStatusDetail { get; set; }
        public string substainingResource { get; set; }


    }

    public class ProjectCaseIssue
    {
        public string projectUID { get; set; }
        public string projectID { get; set; }
        public string projectName { get; set; }
        public string title { get; set; }
        public string actionPlan { get; set; }
        public string assignedToResource { get; set; }

    }

    public class ProjectCaseDeliverable
    {
        public string projectUID { get; set; }
        public string projectID { get; set; }
        public string projectName { get; set; }
        public string taskName { get; set; }
        public DateTime? taskStartDate { get; set; }
        public DateTime? taskFinishDate { get; set; }
        public DateTime? taskDateCompletion { get; set; } //calculated
        public short? taskPercentCompleted { get; set; }
        public decimal? taskACWP { get; set; }
        public decimal? taskBCWP { get; set; }              
        public decimal? taskBCWS { get; set; }
        public DateTime? taskBaseline0FinishDate { get; set; }
        public string taskDays { get; set; } //calculated
        public string taskDaysCompleted { get; set; } //calculated
        public string taskDaysRemaining { get; set; } //calculated
        public string taskToBaseline { get; set; } //calculated
        public string taskMilestoneStatus { get; set; } //calculated
        public string typeOfTask { get; set; } //not used
        public string minDateAxis { get; set; } //not used
        public string maxDateAxis { get; set; } //not used


        public string taskStartDateDisplay { get; set; }
        public string taskFinishDateDisplay { get; set; }
        public string taskDateCompletionDisplay { get; set; }
        public string taskBaseline0FinishDateDisplay { get; set; }
    }

    public class ProjectInfoModel
    {
        public List<ProjectCaseIssue> listOfIssues { get; set; }
        public List<ProjectCaseDeliverable> listOfDeliverables { get; set; }
    }

    public class PACManagersProject
    {
        public string projectUID { get; set; }
        public string projectID { get; set; }
        public string projectName { get; set; }
        public string projectManager { get; set; }
        public string phase { get; set; }
        public string stateOfProject { get; set; }
        public string scheduleStatus { get; set; }
        public string scheduleStatusDetails { get; set; }
        public string PACStatus { get; set; } //Help needed, At Risk, On Track
    }
}