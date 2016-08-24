using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using DashBoardProject.Models.BOMSSPROD142;
using DashBoardProject.Models;
using System.Data.Entity;
using System.Text.RegularExpressions;

namespace DashBoardProject.Controllers
{
    public class PrioritizationController : Controller
    {
        private BOMSSPROD142ProjectsDBContext db = new BOMSSPROD142ProjectsDBContext();
        private PrioritizationDBContext dbPrioritization = new PrioritizationDBContext();
        private DatabaseController dbController = new DatabaseController();

        private string[] programNames = new string[] { "WW FAB-Cash Cost Reduction", "WW FAB-Cycle Time", "WW FAB-Quality Management", "WW FAB-TTMCY" };
        
        private void PopulateViewBag()
        {
            List<SelectListItem> BscmProjectList = new List<SelectListItem>()
            {
                new SelectListItem() {Value = "1", Text="Bscm" },
                new SelectListItem() {Value = "2", Text="Project" },

            };
            ViewBag.BscmProjectGroups = new SelectList(BscmProjectList, "Value", "Text");

        }
        // GET: Prioritization
        public ActionResult Index()
        {
            ViewBag.CurrentView = "Prioritization";

            return View();
        }

        public ActionResult Create()
        {
            ViewBag.CurrentView = "Prioritization";
            IssuesModel objIssue = new IssuesModel();

            PopulateViewBag();

            return View(objIssue);
        }

        [HttpPost]
        public ActionResult Create(IssuesModel model)
        {
            ViewBag.CurrentView = "Prioritization";
            if (ModelState.IsValid)
            {
                //dbPrioritization.Set<IssuesModel>().Add(model);
                dbPrioritization.IssuesModels.Add(model);
                dbPrioritization.SaveChanges();
                
               
                return View("Index");

            }else
            {
                PopulateViewBag();
                return View(model);
            }

        }

        public ActionResult ViewListOfIssues()
        {
            ViewBag.CurrentView = "Prioritization";

            var query = (from t1 in db.MSP_EpmProject_UserView
                         where programNames.Contains(t1.Program) && t1.State_of_Project == "Active"
                         select new PrioritizeProjectOverall
                         {
                             projectUID = t1.ProjectUID.ToString(),
                             projectTitle = t1.ProjectTitle,
                             projectID = t1.Project_ID,
                             PAC = t1.Program,
                             benefit = t1.Benefits_Comment
                         });

            var listOfPrioritizeProjects = query.ToList<PrioritizeProjectOverall>();

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

            return View(listOfPrioritizeProjects);
        }

        public ActionResult Prioritize()
        {
            ViewBag.CurrentView = "Prioritization";

            var query = (from t1 in db.MSP_EpmProject_UserView
                         where programNames.Contains(t1.Program) && t1.State_of_Project == "Active"
                         select new PrioritizeProjectOverall
                         {
                             projectUID = t1.ProjectUID.ToString(),
                             projectTitle = t1.ProjectTitle,
                             projectID = t1.Project_ID,
                             PAC = t1.Program,
                             benefit = t1.Benefits_Comment
                         });

            var listOfPrioritizeProjects = query.ToList<PrioritizeProjectOverall>();

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Prioritize(List<PrioritizeProjectOverall> model)
        {
            ViewBag.CurrentView = "Prioritization";

            //save database
            if (ModelState.IsValid)
            {
                ViewBag.UpdatePrioritiesSuccess = true;
                List<PrioritizeProjectOverall> sortedData = model;
                sortedData.Sort();

                //store issues rankings into DB
                UpdateInfoInDb(sortedData);
                ModelState.Clear();
                return View("Prioritize", sortedData);
               
            }
            else
            {
                return View("Index");

            }
               
        }

        public void UpdateInfoInDb(List<PrioritizeProjectOverall> data)
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

        //public List<Issues> ReturnListOfIssues() //temp taking issues from XML file
        //{
        //    string xmlData = HttpContext.Server.MapPath("~/App_Data/prioritizationXML.xml");
        //    DataSet ds = new DataSet();
        //    ds.ReadXml(xmlData);
        //    var issues = new List<Issues>();
        //    issues = (from rows in ds.Tables[0].AsEnumerable()
        //              select new Issues
        //              {
        //                  bscmProjectsID = rows[0].ToString(),
        //                  bscmProjectsName = rows[1].ToString(),
        //                  PAC = rows[2].ToString(),
        //                  pacRank = Int32.Parse(rows[3].ToString()),
        //                  ITHR = rows[4].ToString(),
        //                  benefit = rows[5].ToString(),
        //                  overallRank = 0

        //              }).ToList();

        //    return issues;
        //}
    }
}