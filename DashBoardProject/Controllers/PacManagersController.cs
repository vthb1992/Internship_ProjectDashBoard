using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DashBoardProject.Models;
using DashBoardProject.Models.BOMSSPROD142;

namespace DashBoardProject.Controllers
{
    public class PacManagersController : Controller
    {
        private BOMSSPROD142ProjectsDBContext db = new BOMSSPROD142ProjectsDBContext();
        private PacManagersDBContext dbPacManagers = new PacManagersDBContext();


        private string[] programNames = new string[] { "WW FAB-Cash Cost Reduction", "WW FAB-Cycle Time", "WW FAB-Quality Management", "WW FAB-TTMCY" };

        // GET: PacManager
        public ActionResult Index()
        {
            ViewBag.CurrentView = "PACManagers";

            string[] PACStatuses = new string[] { "Help Needed", "At Risk", "On Track", "Not Categorised" };
            ViewBag.PACStatuses = PACStatuses;

            var query = (from t1 in db.MSP_EpmProject_UserView
                         join t2 in db.MSP_EpmResource_UserView on t1.ProjectOwnerResourceUID equals t2.ResourceUID
                         where programNames.Contains(t1.Program)
                         select new PACManagersProject
                         {
                             projectUID = t1.ProjectUID.ToString(),
                             projectID = t1.Project_ID,
                             projectName = t1.ProjectName,
                             projectManager = t2.ResourceNTAccount,
                             phase = t1.Phase,
                             stateOfProject = t1.State_of_Project,
                             scheduleStatus = t1.Schedule_Status,
                             scheduleStatusDetails = t1.Schedule_Status_Details
                         });
            var listOfPacProjects = query.ToList<PACManagersProject>();


            var queryPacProjectStatus = (from t in dbPacManagers.PacProjectStatus
                                        select t).ToList();

            for (int i = 0; i < listOfPacProjects.Count(); i++)
            {
                listOfPacProjects[i].projectManager = listOfPacProjects[i].projectManager.Split('\\')[1];

                string projID = listOfPacProjects[i].projectID;

                PacProjectStatu result = queryPacProjectStatus.Find(x => x.projectID == projID);

                if (result != null)
                {
                    listOfPacProjects[i].PACStatus = result.status;
                }
                else
                {
                    if (listOfPacProjects[i].scheduleStatus == "Green")
                    {
                        listOfPacProjects[i].PACStatus = "On Track";
                    }
                    else if (listOfPacProjects[i].scheduleStatus == "Yellow")
                    {
                        listOfPacProjects[i].PACStatus = "At Risk";
                    }
                    else if (listOfPacProjects[i].scheduleStatus == "Red")
                    {
                        listOfPacProjects[i].PACStatus = "Help Needed";
                    }
                    else
                    {
                        listOfPacProjects[i].PACStatus = "Not Categorised";
                    }
                }

            }
            return View(listOfPacProjects);
        }

        public ActionResult Categorise()
        {
            ViewBag.CurrentView = "PACManagers";

            string[] PACStatuses = new string[] { "Help Needed", "At Risk", "On Track", "Not Categorised" };
            ViewBag.PACStatuses = PACStatuses;

            var query = (from t1 in db.MSP_EpmProject_UserView
                         join t2 in db.MSP_EpmResource_UserView on t1.ProjectOwnerResourceUID equals t2.ResourceUID
                         where programNames.Contains(t1.Program)
                         select new PACManagersProject
                         {
                             projectUID = t1.ProjectUID.ToString(),
                             projectID = t1.Project_ID,
                             projectName = t1.ProjectName,
                             projectManager = t2.ResourceNTAccount,
                             phase = t1.Phase,
                             stateOfProject = t1.State_of_Project,
                             scheduleStatus = t1.Schedule_Status,
                             scheduleStatusDetails = t1.Schedule_Status_Details
                         });

            var listOfPacProjects = query.ToList<PACManagersProject>();

            var queryPacProjectStatus = (from t in dbPacManagers.PacProjectStatus
                                    select t).ToList();

            for (int i = 0; i < listOfPacProjects.Count(); i++)
            {
                listOfPacProjects[i].projectManager = listOfPacProjects[i].projectManager.Split('\\')[1];

                string projID = listOfPacProjects[i].projectID;
     
                PacProjectStatu result = queryPacProjectStatus.Find(x => x.projectID == projID);

                if (result != null)
                {
                    listOfPacProjects[i].PACStatus = result.status;
                }
                else
                {
                    if (listOfPacProjects[i].scheduleStatus == "Green")
                    {
                        listOfPacProjects[i].PACStatus = "On Track";
                    }
                    else if (listOfPacProjects[i].scheduleStatus == "Yellow")
                    {
                        listOfPacProjects[i].PACStatus = "At Risk";
                    }
                    else if (listOfPacProjects[i].scheduleStatus == "Red")
                    {
                        listOfPacProjects[i].PACStatus = "Help Needed";
                    }
                    else
                    {
                        listOfPacProjects[i].PACStatus = "Not Categorised";
                    }
                }

            }
            return View(listOfPacProjects);
        }

        [HttpPost]
        public ActionResult Categorise(List<PACManagersProject> model)
        {
            /*
             Things to be improved: Only update the records in the database for those projects that are modified
             */
            ViewBag.CurrentView = "PACManagers";

            string[] PACStatuses = new string[] { "Help Needed", "At Risk", "On Track", "Not Categorised" };
            ViewBag.PACStatuses = PACStatuses;

            //save database
            if (ModelState.IsValid)
            {
                ViewBag.UpdateCategoriesSuccess = true;

                var query = (from t in dbPacManagers.PacProjectStatus
                             select t.projectID).ToList();

                //store issues rankings into DB
                foreach (var item in model)
                {
                    if (query.Contains(item.projectID))
                    {
                        PacProjectStatu foundItem = dbPacManagers.PacProjectStatus.Find(item.projectID);
                        foundItem.status = item.PACStatus;
                        
                    }
                    else
                    {
                        PacProjectStatu temp = new PacProjectStatu();
                        temp.projectID = item.projectID;
                        temp.status = item.PACStatus;
                        dbPacManagers.PacProjectStatus.Add(temp);
                        
                    }

                }
                dbPacManagers.SaveChanges();

                ModelState.Clear();
                return View("Categorise", model);

            }
            else
            {
                return View("Index");

            }
        }
    }
}