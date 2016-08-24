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
    public class TTMCYController : Controller
    {
        private BOMSSPROD142ProjectsDBContext db = new BOMSSPROD142ProjectsDBContext();
        private PrioritizationDBContext dbPrioritization = new PrioritizationDBContext();
        private DatabaseController dbController = new DatabaseController();

        private string programName = "WW FAB-TTMCY";

        // GET: CashCost
        public ActionResult Index()
        {
            ViewBag.CurrentView = "TTMCYield";

            var query = dbController.GetProjectInfoFromDb(programName);

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

            return View(listOfProjects);
        }

        public ActionResult Prioritize()
        {
            ViewBag.CurrentView = "TTMCYield";

            var query = dbController.GetPrioritizeProjectPacInfoFromDb(programName);

            var listOfPrioritizeProjects = query.ToList<PrioritizeProjectPAC>();

            var queryIssuesRankings = (from t in dbPrioritization.IssuesRankings
                                       select t).ToList();

            for (int i = 0; i < listOfPrioritizeProjects.Count(); i++)
            {
                string projID = listOfPrioritizeProjects[i].projectID;

                IssuesRanking result = queryIssuesRankings.Find(x => x.bscmProjectsID == projID);

                if (result != null)
                {
                    listOfPrioritizeProjects[i].pacRank = result.pacRank;
                    listOfPrioritizeProjects[i].overallRank = result.overallRank;
                    listOfPrioritizeProjects[i].ITHR = result.ITHR;
                }


                if (listOfPrioritizeProjects[i].benefit != null)
                {
                    listOfPrioritizeProjects[i].benefit = Regex.Replace(listOfPrioritizeProjects[i].benefit, "<.*?>|&.*?;", string.Empty).Trim();
                }
            }

            listOfPrioritizeProjects.Sort();

            return View(listOfPrioritizeProjects);
        }
        [HttpPost]
        public ActionResult Prioritize(List<PrioritizeProjectPAC> model)
        {
            ViewBag.CurrentView = "TTMCYield";

            //save database
            if (ModelState.IsValid)
            {
                ViewBag.UpdatePrioritiesSuccess = true;
                List<PrioritizeProjectPAC> sortedData = model;
                sortedData.Sort();

                //store issues rankings into DB
                dbController.UpdateInfoInDb(sortedData);
                ModelState.Clear();
                return View("Prioritize", sortedData);

            }
            else
            {
                return View("Index");

            }
        }

    }
}