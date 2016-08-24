using DashBoardProject.Models;
using DashBoardProject.Models.BOMSSPROD142;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DashBoardProject.Controllers
{
    public class DatabaseController : Controller
    {
        private BOMSSPROD142ProjectsDBContext db = new BOMSSPROD142ProjectsDBContext();
        private PrioritizationDBContext dbPrioritization = new PrioritizationDBContext();

        public void UpdateInfoInDb(List<PrioritizeProjectPAC> data)
        {
            var query = (from t in dbPrioritization.IssuesRankings
                         select t.bscmProjectsID).ToList();

            foreach (var item in data)
            {
                if (query.Contains(item.projectID))
                {
                    IssuesRanking foundItem = dbPrioritization.IssuesRankings.Find(item.projectID);
                    foundItem.pacRank = item.pacRank;
                    foundItem.overallRank = item.overallRank;
                    foundItem.ITHR = item.ITHR;
                   
                }
                else
                {
                    IssuesRanking temp = new IssuesRanking();
                    temp.bscmProjectsID = item.projectID;
                    temp.pacRank = item.pacRank;
                    temp.overallRank = item.overallRank;
                    temp.ITHR = item.ITHR;

                    dbPrioritization.IssuesRankings.Add(temp);
                    
                }

            }
            dbPrioritization.SaveChanges();
        }

        public IQueryable<Project> GetProjectInfoFromDb(string programName)
        {
            var query = (from t1 in db.MSP_EpmProject_UserView
                         join t2 in db.MSP_EpmResource_UserView on t1.ProjectOwnerResourceUID equals t2.ResourceUID
                         where t1.Program == programName
                         select new Project
                         {
                             projectUID = t1.ProjectUID.ToString(),
                             projectTitle = t1.ProjectTitle,
                             projectID = t1.Project_ID,
                             phase = t1.Phase,
                             keySME = t1.Sustaining_Resource,
                             projectManager = t2.ResourceNTAccount,
                             actualPercentageCompleted = t1.ProjectPercentCompleted,
                             projectStart = t1.ProjectStartDate,
                             projectFinish = t1.ProjectFinishDate,
                             baselineFinish = t1.ProjectBaseline0FinishDate,
                             stateOfProject = t1.State_of_Project
                         });

            return query;

        }

        public IQueryable<PrioritizeProjectPAC> GetPrioritizeProjectPacInfoFromDb (string programName)
        {
            var query = (from t1 in db.MSP_EpmProject_UserView
                         where t1.Program == programName && t1.State_of_Project == "Active"
                         select new PrioritizeProjectPAC
                         {
                             projectUID = t1.ProjectUID.ToString(),
                             projectTitle = t1.ProjectTitle,
                             projectID = t1.Project_ID,
                             PAC = t1.Program,
                             benefit = t1.Benefits_Comment
                         });

            return query;

        }
    }
}