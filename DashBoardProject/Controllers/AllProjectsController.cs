using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DashBoardProject.Models.BOMSSPROD142;
using DashBoardProject.Models;
using System.Text.RegularExpressions;

namespace DashBoardProject.Controllers
{
    public class AllProjectsController : Controller
    {
        private BOMSSPROD142ProjectsDBContext db = new BOMSSPROD142ProjectsDBContext();
        private PrioritizationDBContext dbPrioritization = new PrioritizationDBContext();
        private DatabaseController dbController = new DatabaseController();

        private string[] programNames = new string[] { "WW FAB-Cash Cost Reduction", "WW FAB-Cycle Time", "WW FAB-Quality Management", "WW FAB-TTMCY" };
        // GET: AllProjects
        public ActionResult Index(string searchTitle, string searchPhase, string searchManager)
        {
            ViewBag.CurrentView = "AllProjects";

            var query = (from t1 in db.MSP_EpmProject_UserView
                         join t2 in db.MSP_EpmResource_UserView on t1.ProjectOwnerResourceUID equals t2.ResourceUID
                         where programNames.Contains(t1.Program)
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

            

            if (!String.IsNullOrEmpty(searchTitle))
            {
                query = query.Where(s => s.projectTitle.Contains(searchTitle));
            }

            if (!String.IsNullOrEmpty(searchPhase))
            {
                query = query.Where(s => s.phase.Contains(searchPhase));
            }
            if (!String.IsNullOrEmpty(searchManager))
            {
                query = query.Where(s => s.projectManager.Contains(searchManager));
            }


            var allStatesOfProject = query.Select(o => o.stateOfProject).Distinct().ToList<string>();

            var listOfProjects = query.ToList<Project>();

            for (int i = 0; i < listOfProjects.Count(); i++)
            {
                //trim
                listOfProjects[i].projectManager = listOfProjects[i].projectManager.Split('\\')[1];

                if (listOfProjects[i].baselineFinish.HasValue)
                {
                    listOfProjects[i].daysBehindAhead = (listOfProjects[i].projectFinish.Value - listOfProjects[i].baselineFinish.Value).Days;
                }
                else
                {
                    listOfProjects[i].daysBehindAhead = 0;
                }

                if (listOfProjects[i].projectStart.HasValue)
                {
                    listOfProjects[i].projectStartDisplay = listOfProjects[i].projectStart.Value.ToShortDateString();
                }
                if (listOfProjects[i].projectFinish.HasValue)
                {
                    listOfProjects[i].projectFinishDisplay = listOfProjects[i].projectFinish.Value.ToShortDateString();
                }
                if (listOfProjects[i].baselineFinish.HasValue)
                {
                    listOfProjects[i].baselineFinishDisplay = listOfProjects[i].baselineFinish.Value.ToShortDateString();
                }
            }

            ViewBag.statesOfProjects = allStatesOfProject;
            if(listOfProjects.Count() == 0)
            {
                ViewBag.haveSearchResults = false;
            }
            else
            {
                ViewBag.haveSearchResults = true;
            }
             
            return View(listOfProjects);
        }
    }
}