using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DashBoardProject.Models;
using DashBoardProject.Models.BOMSSPROD142;
using System.Text.RegularExpressions;

using Atlassian.Jira;
using System.Text;

namespace DashBoardProject.Controllers
{
    
    public class ProjectsController : Controller
    {
        private BOMSSPROD142ProjectsDBContext db = new BOMSSPROD142ProjectsDBContext();

        private string[] departmentNames = new string[] { "WW FE", "WW BE", "OCT" };

        // GET: Projects
        public ActionResult Index()
        {
        

            return View();
        }

        public ActionResult Info(string id)
        {
            var query1 = (from t1 in db.MSP_EpmProject_UserView
                         join t2 in db.MSP_EpmResource_UserView on t1.ProjectOwnerResourceUID equals t2.ResourceUID
                         join oct in db.MSPCFPRJ_Network_Priorities_AssociationView on t1.ProjectUID equals oct.EntityUID into temp1
                         from t3 in temp1.DefaultIfEmpty()
                         join it in db.MSP_EpmLookupTable on t3.LookupMemberUID equals it.MemberUID into temp2
                         from t4 in temp2.DefaultIfEmpty()
                         where departmentNames.Contains(t1.Project_Departments) && t1.ProjectUID.ToString() == id
                         select new ProjectCaseInfo
                         {
                             projectID = t1.Project_ID,
                             projectDesc = t1.Project_Description,
                             methodology = t1.Methodology,
                             networkPriorities = t4.MemberFullValue,
                             projectName = t1.ProjectName,
                             projectSponsor = t1.Project_Sponsor,
                             execSponsor = t1.Executive_Sponsor,
                             leadArch = t1.Lead_Architect,
                             refID = t1.Reference_ID,
                             program = t1.Program,
                             projectAuthorName = t1.Proposal_Authors,
                             projectManagerName = t1.ProjectOwnerName,
                             projectOwner = t2.ResourceNTAccount,
                             SME = t1.Sustaining_Resource,
                             phase = t1.Phase,
                             costStatus = t1.Cost_Status,
                             scheduleStatus = t1.Schedule_Status,
                             scopeStatus = t1.Scope_Status,
                             teamStatus = t1.Team_Status,
                             proposalStart = t1.Proposed_Start,
                             proposalFinish = t1.Proposed_Finish,
                             projectStartDate = t1.ProjectStartDate,
                             projectFinishDate = t1.ProjectFinishDate,
                             firstSubmitted = t1.First_Portfolio_Submital,
                             projectDuration = t1.ProjectDuration,
                             projectRemainingWork = t1.ProjectRemainingWork,
                             projectWorkspaceInternalHref = t1.ProjectWorkspaceInternalHRef,
                             

                             //primaryService = t1.Primary_Service,
                             projectStkholders = t1.Key_Stakeholders,
                             projectDeliverables = t1.Deliverables_Comment,
                             problemOpp = t1.Problem_Opportunity_Statement,
                             projectScope = t1.Project_Scope,
                             projectExclusions = t1.Project_Exclusions,
                             projectConstraints = t1.Project_Constraints,
                             billing = t1.Billing,
                             costComment = t1.Cost_Comment,
                             benefitComment = t1.Benefits_Comment,
                             driverComment = t1.Business_Driver_Comments,
                             unprovenTechnology = t1.Unproven_Technology,
                             targetPerformance = t1.Target_Performance,
                             currentPerformance = t1.Current_Performance,
                             coreTeam = t1.Core_Team,
                             projectUID = t1.ProjectUID.ToString(),

                             baselineStartDate = t1.ProjectBaseline0StartDate,
                             baselineFinishDate = t1.ProjectBaseline0FinishDate,
                             actualPercentageCompleted = t1.ProjectPercentCompleted,
                             resourceStatus = t1.Resource_Status,
                             resourceStatusDetail = t1.Resource_Status_Detail,
                             substainingResource = t1.Sustaining_Resource

                         }).FirstOrDefault();

            if(query1 != null)
            {
                if (query1.projectStartDate.HasValue)
                {
                    query1.projectStartDateDisplay = query1.projectStartDate.Value.ToShortDateString();
                }
                if (query1.projectFinishDate.HasValue)
                {
                    query1.projectFinishDateDisplay = query1.projectFinishDate.Value.ToShortDateString();
                }
                if (query1.baselineStartDate.HasValue)
                {
                    query1.baselineStartDateDisplay = query1.baselineStartDate.Value.ToShortDateString();
                }
                if (query1.baselineFinishDate.HasValue)
                {
                    query1.baselineFinishDateDisplay = query1.baselineFinishDate.Value.ToShortDateString();
                }

                //if (query1.projectDesc != null)
                //{
                //    query1.projectDesc = Regex.Replace(query1.projectDesc, "<.*?>|&.*?;", string.Empty).Trim();
                //}

                //if (query1.projectScope != null)
                //{
                //    query1.projectScope = Regex.Replace(query1.projectScope, "<.*?>|&.*?;", string.Empty).Trim();
                //}

                //if (query1.projectDeliverables != null)
                //{
                //    query1.projectDeliverables = Regex.Replace(query1.projectDeliverables, "<.*?>|&.*?;", string.Empty).Trim();
                //}

                ViewBag.projectInfo = query1;
            }else
            {
                ViewBag.projectInfo = new ProjectCaseInfo();
            }

            var query2 = (from t1 in db.MSP_EpmProject_UserView
                          join t2 in db.MSP_WssIssueToIssueLinks_UserView on t1.ProjectUID equals t2.ProjectUID
                          where departmentNames.Contains(t1.Project_Departments) && t1.ProjectUID.ToString() == id
                          && t2.Status.EndsWith("Active") && t2.Priority.EndsWith("High")
                          select new ProjectCaseIssue
                          {
                              projectUID = t1.ProjectUID.ToString(),
                              projectID = t1.Project_ID,
                              projectName = t1.ProjectName,
                              title = t2.Title,
                              actionPlan = t2.Resolution,
                              assignedToResource = t2.AssignedToResource
                          });
            var issuesData = query2.ToList<ProjectCaseIssue>();

            var query3 = (from t1 in db.MSP_EpmProject_UserView
                          join t2 in db.MSP_EpmTask_UserView on t1.ProjectUID equals t2.ProjectUID
                          where departmentNames.Contains(t1.Project_Departments) && t1.ProjectUID.ToString() == id && t2.ReportTask == true
                          orderby t2.TaskIndex
                          select new ProjectCaseDeliverable
                          {
                              projectUID = t1.ProjectUID.ToString(),
                              projectID = t1.Project_ID,
                              projectName = t1.ProjectName,
                              taskName = t2.TaskName,
                              taskStartDate = t2.TaskStartDate,
                              taskFinishDate = t2.TaskFinishDate,
                              taskPercentCompleted = t2.TaskPercentCompleted,
                              taskACWP = t2.TaskACWP,
                              taskBCWP = t2.TaskBCWP,
                              taskBCWS = t2.TaskBCWS,
                              taskBaseline0FinishDate = t2.TaskBaseline0FinishDate,
                          });
            var deliverablesData = query3.ToList<ProjectCaseDeliverable>();

            for (int i = 0; i < deliverablesData.Count(); i++)
            {

                if (deliverablesData[i].taskStartDate.HasValue)
                {
                    deliverablesData[i].taskStartDateDisplay = deliverablesData[i].taskStartDate.Value.ToShortDateString();
                }
                if (deliverablesData[i].taskFinishDate.HasValue)
                {
                    deliverablesData[i].taskFinishDateDisplay = deliverablesData[i].taskFinishDate.Value.ToShortDateString();
                }
                if (deliverablesData[i].taskBaseline0FinishDate.HasValue)
                {
                    deliverablesData[i].taskBaseline0FinishDateDisplay = deliverablesData[i].taskBaseline0FinishDate.Value.ToShortDateString();
                }
            }

            ProjectInfoModel modelData = new ProjectInfoModel();
            modelData.listOfIssues = issuesData;
            modelData.listOfDeliverables = deliverablesData;

            return View(modelData);
        }
    }
}