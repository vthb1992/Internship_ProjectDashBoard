using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Atlassian.Jira;
using System.Text;
using DashBoardProject.Models.BOMSSPROD131;
using DashBoardProject.Models;
using System.Net;
using System.IO;
using DashBoardProject.Models.BOMSSPROD142;
using System.Globalization;

namespace DashBoardProject.Controllers
{
    public class AuxITController : Controller
    {
        private BOMSSPROD131BscmDBContext db131 = new BOMSSPROD131BscmDBContext();
        private BOMSSPROD142ProjectsDBContext db142 = new BOMSSPROD142ProjectsDBContext();
        private WorkWeekDBContext dbWW = new WorkWeekDBContext();
        private PrioritizationDBContext dbPrioritization = new PrioritizationDBContext();
        private GanttChartDBContext dbGanttChart = new GanttChartDBContext();

        private string[] programNames = new string[] { "WW FAB-Cash Cost Reduction", "WW FAB-Cycle Time", "WW FAB-Quality Management", "WW FAB-TTMCY" };
        
        private Jira jc = new Jira(@"https://jira.micron.com/jira", "OCTBI_USER", "cifd99dsfssccEE");

        // GET: AuxIT
        public ActionResult Index()
        {
            ViewBag.CurrentView = "AuxIT";

            return View();
        }

        public ActionResult GanttChart(int numOfSprintsBefore = 5, int numOfSprintsAfter = 26)
        {
            int numberOfHoursInASprint = 72; //default
            int numberOfSprintsBefore = numOfSprintsBefore;
            int numberOfSprintsAfter = numOfSprintsAfter;

            PopulateViewBagWorkWeekRange(numberOfSprintsBefore, numberOfSprintsAfter);
            
            //Query gantt chart items
            var query = (from t1 in db142.MSP_EpmProject_UserView
                         where programNames.Contains(t1.Program) && t1.State_of_Project == "Active"
                         select new GanttChartItem
                         {
                            itemUID = t1.ProjectUID.ToString(),
                            itemID = t1.Project_ID,
                            itemName = t1.ProjectTitle,
                            PAC = t1.Program
                         });

            var listOfGanttChartItem = query.ToList<GanttChartItem>();

            var queryIssuesRankings = (from t in dbPrioritization.IssuesRankings
                                       where t.overallRank != 0 && t.ITHR.StartsWith("a")
                                       select t).ToList();

            var queryGanttChartDetails = (from t in dbGanttChart.AuxITGanttChart_Items
                                          select t).ToList();

            for (int i = 0; i < listOfGanttChartItem.Count(); i++)
            {
                string itemID = listOfGanttChartItem[i].itemID;

                IssuesRanking result = queryIssuesRankings.Find(x => x.bscmProjectsID == itemID);
                AuxITGanttChart_Items resultGanttChart = queryGanttChartDetails.Find(x => x.bscmProjectsID == itemID);

                if (result != null)
                {
                    listOfGanttChartItem[i].overallRank = result.overallRank;
                    listOfGanttChartItem[i].rankingStatus = result.overallRank.ToString();
                    listOfGanttChartItem[i].ITHR = Int32.Parse(result.ITHR.Split('-')[1]);
                    if (resultGanttChart != null)
                    {
                        numberOfHoursInASprint = resultGanttChart.numberOfHoursInASprint;

                        listOfGanttChartItem[i].rankingStatus = resultGanttChart.OCLT;
                       
                        listOfGanttChartItem[i].developer = resultGanttChart.developer;
                        listOfGanttChartItem[i].plannedStartWorkWeek = resultGanttChart.plannedStartWW;
                        listOfGanttChartItem[i].plannedEndWorkWeek = resultGanttChart.plannedEndWW;
                        listOfGanttChartItem[i].actualStartWorkWeek = resultGanttChart.actualStartWW;
                        listOfGanttChartItem[i].actualEndWorkWeek = resultGanttChart.actualEndWW;
                        listOfGanttChartItem[i].deadlineWorkWeek = resultGanttChart.needDateWW;
                        listOfGanttChartItem[i].developerWorkload = resultGanttChart.developerWorkload;
                    }
                }else
                {
                    listOfGanttChartItem.RemoveAt(i);
                    i--;
                }
            }

            listOfGanttChartItem.Sort();

            ViewBag.numberOfHoursInASprint = numberOfHoursInASprint;
            ViewBag.numberOfSprintsBefore = numberOfSprintsBefore;
            ViewBag.numberOfSprintsAfter = numberOfSprintsAfter;

            return View(listOfGanttChartItem);
        }
        [HttpPost]
        public ActionResult GanttChart(List<GanttChartItem> model, int numOfSprintsBefore, int numOfSprintsAfter)
        {
            int sprintDay = 1; // fri = 1, sat = 2, sun = 3, mon = 4, tue = 5, wed = 6, thurs = 7

            int numberOfSprintsBefore = numOfSprintsBefore;
            int numberOfSprintsAfter = numOfSprintsAfter;
            PopulateViewBagWorkWeekRange(numberOfSprintsBefore, numberOfSprintsAfter);

            ViewBag.numberOfSprintsBefore = numberOfSprintsBefore;
            ViewBag.numberOfSprintsAfter = numberOfSprintsAfter;
            ViewBag.numberOfHoursInASprint = model.First().numberOfHoursInSprint;

            if (ModelState.IsValid)
            {
                ViewBag.UpdateGanttChartSuccess = true;
                List<GanttChartItem> sortedData = model;
                sortedData.Sort();

                //store gantt chart details into DB
                UpdateInfoInDb(sortedData, sprintDay);
                ModelState.Clear();
                return View("GanttChart", sortedData);

            }else
            {
                ViewBag.UpdateGanttChartValidationFail = true;
                return View("GanttChart", model);
            }
        }

        private void UpdateInfoInDb(List<GanttChartItem> data, int sprintDay)
        {
            var query = (from t in dbGanttChart.AuxITGanttChart_Items
                         select t.bscmProjectsID).ToList();

            foreach (var item in data)
            {
                if (query.Contains(item.itemID))
                {
                    AuxITGanttChart_Items foundItem = dbGanttChart.AuxITGanttChart_Items.Find(item.itemID);
                    foundItem.OCLT = item.rankingStatus;
                    foundItem.developer = item.developer;
                    foundItem.plannedStartWW = item.plannedStartWorkWeek;
                    foundItem.plannedEndWW = item.plannedEndWorkWeek;
                    foundItem.actualStartWW = item.actualStartWorkWeek;
                    foundItem.actualEndWW = item.actualEndWorkWeek;
                    foundItem.needDateWW = item.deadlineWorkWeek;

                    foundItem.plannedStartDate = getSprintDateFromWorkWeek(item.plannedStartWorkWeek, sprintDay);
                    foundItem.plannedEndDate = getSprintDateFromWorkWeek(item.plannedEndWorkWeek, sprintDay);
                    foundItem.actualStartDate = getSprintDateFromWorkWeek(item.actualStartWorkWeek, sprintDay);
                    foundItem.actualEndDate = getSprintDateFromWorkWeek(item.actualEndWorkWeek, sprintDay);
                    foundItem.needDateDate = getSprintDateFromWorkWeek(item.deadlineWorkWeek, sprintDay);

                    foundItem.developerWorkload = item.developerWorkload;
                    foundItem.numberOfHoursInASprint = item.numberOfHoursInSprint;
                }
                else
                {
                    AuxITGanttChart_Items temp = new AuxITGanttChart_Items();
                    temp.bscmProjectsID = item.itemID;
                    temp.OCLT = item.rankingStatus;
                    temp.developer = item.developer;
                    temp.plannedStartWW = item.plannedStartWorkWeek;
                    temp.plannedEndWW = item.plannedEndWorkWeek;
                    temp.actualStartWW = item.actualStartWorkWeek;
                    temp.actualEndWW = item.actualEndWorkWeek;
                    temp.needDateWW = item.deadlineWorkWeek;

                    temp.plannedStartDate = getSprintDateFromWorkWeek(item.plannedStartWorkWeek, sprintDay);
                    temp.plannedEndDate = getSprintDateFromWorkWeek(item.plannedEndWorkWeek, sprintDay);
                    temp.actualStartDate = getSprintDateFromWorkWeek(item.actualStartWorkWeek, sprintDay);
                    temp.actualEndDate = getSprintDateFromWorkWeek(item.actualEndWorkWeek, sprintDay);
                    temp.needDateDate = getSprintDateFromWorkWeek(item.deadlineWorkWeek, sprintDay);

                    temp.developerWorkload = item.developerWorkload;
                    temp.numberOfHoursInASprint = item.numberOfHoursInSprint;

                    dbGanttChart.AuxITGanttChart_Items.Add(temp);
                }

            }
            dbGanttChart.SaveChanges();
        }

  
        public ActionResult OCTBI()
        {
            ViewBag.CurrentView = "AuxIT";

            int numIssues = 0;

            IEnumerable<Issue> octbiIssues = null;

            octbiIssues = jc.GetIssuesFromJql("project = OCTBI", Int32.MaxValue);
           
            numIssues += octbiIssues.Count();

            return View(octbiIssues.ToList());
        }
        
        public ActionResult BCTBI()
        {
            ViewBag.CurrentView = "AuxIT";

            int numIssues = 0;

            IEnumerable<Issue> bctbiIssues = null;

            bctbiIssues = jc.GetIssuesFromJql("project = BCTBI", Int32.MaxValue);
            numIssues += bctbiIssues.Count();

            return View(bctbiIssues.ToList());
        }

        public ActionResult ViewListOfBscm()
        {
            ViewBag.CurrentView = "AuxIT";

            var query = (from t1 in db131.BAMS_CaseMgmt
                         join t2 in db131.eFolders on t1.EFOLDERID equals t2.eFolderID
                         join t3 in db131.fsrbs on t1.FsrbID equals t3.fsrb_id
                         where t2.eFolderName.StartsWith("BSCM") && t2.eCreationTime.Value.CompareTo(new DateTime(2016,6,1)) > 0
                         select new Bscm
                         {
                             eFolderID = t1.EFOLDERID,
                             bscmID = t2.eFolderName,
                             description = t1.Description,
                             department = t1.Department,
                             currentStage = t2.eStageName,
                             creationTime = t2.eCreationTime,
                             fsrbGroupName = t3.fsrb_group_name,
                             IS_HoursEstimate = t1.EffortEstimate,
                             primaryStakeholder = t1.PrimaryStakeholder,
                             submitterUsername = t1.SubmitterUsername,
                             JIRA_Key = t1.JIRA_Key
                         });

            var listOfBscm = query.ToList<Bscm>();


            //List<Bscm> tempList = new List<Bscm>();
            //Issue tempIssue = null;
            //bool isFound;
            //for (int i = 0; i < listOfBscm.Count; i++)
            //{
            //    isFound = true;
            //    try
            //    {
            //        tempIssue = jc.GetIssue(listOfBscm[i].JIRA_Key);
            //    }
            //    catch (Exception e)
            //    {
            //        isFound = false;
            //    }
            //    finally
            //    {
            //        if (isFound)
            //        {
            //            if (tempIssue.Type.Name == "Epic")
            //            {
            //                tempList.Add(listOfBscm[i]);
            //            }
            //        }

            //    }

            //}

            return View(listOfBscm);
        }
        [HttpGet]
        public ActionResult Details(string Id)
        {
            JiraIssues issueDetails = new JiraIssues();
            Issue issue = null;
            bool isFound = true;
            try
            {
                issue = jc.GetIssue(Id);
            }
            catch (Exception)
            {
                isFound = false;
            }
            finally
            {
                if (isFound)
                {
                    issueDetails.key = issue.Key.Value;
                    if (issue.Type.Id == "6")
                    {
                        issueDetails.type = "Sub-Task";
                    }
                    else
                    {
                        issueDetails.type = issue.Type.Name;
                    }

                    issueDetails.summary = issue.Summary;
                    issueDetails.status = issue.Status.Name;
                    if (issue.Assignee != null)
                    {
                        issueDetails.assignee = issue.Assignee;
                    }
                    else
                    {
                        issueDetails.assignee = "Not Assigned";
                    }

                    issueDetails.priority = issue.Priority.Name;

                    if (issue.Resolution != null)
                    {
                        issueDetails.resolution = issue.Resolution.Name;
                    }
                    else
                    {
                        issueDetails.resolution = "None";
                    }


                    IEnumerable<Issue> issuesInEpicEnum = null;
                    issuesInEpicEnum = jc.GetIssuesFromJql("project in (BCTBI, OCTBI) AND \"Epic Link\"=" + Id, Int32.MaxValue);
                    issueDetails.issuesInEpic = issuesInEpicEnum.ToList();
                }
                else
                {
                    issueDetails.issuesInEpic = new List<Issue>();
                }
            }


            //string url = "http://jira.micron.com/rest/agile/1.0/issue/" + Id;
            //string data = null;


            //HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;
            //req.ContentType = "application/json";
            //req.Method = "GET";

            ////req.Credentials = new NetworkCredential("OCTBI_USER", "cifd99dsfssccEE");

            //string mergedCredentials = string.Format("{0}:{1}", "OCTBI_USER", "cifd99dsfssccEE");
            //byte[] byteCredentials = UTF8Encoding.UTF8.GetBytes(mergedCredentials);
            //string base64Credentials = Convert.ToBase64String(byteCredentials);
            //req.Headers.Add("Authorization", "Basic " + base64Credentials);

            //if (data != null)
            //{
            //    using (StreamWriter writer = new StreamWriter(req.GetRequestStream()))
            //    {
            //        writer.Write(data);
            //    }
            //}


            //HttpWebResponse resp = req.GetResponse() as HttpWebResponse;

            //string result = string.Empty;
            //using (StreamReader reader = new StreamReader(resp.GetResponseStream()))
            //{

            //    result = reader.ReadToEnd();
            //}
            //var test = result;


            return PartialView("_Details", issueDetails);
        }
        private void PopulateViewBagWorkWeekRange(int numOfSprintsBefore, int numOfSprintsAfter)
        {
            //WorkWeek range
            int weeksMinus = numOfSprintsBefore * 2;
            int weeksPlus = numOfSprintsAfter * 2;

            DateTime currentDate = DateTime.Now;
            int currentDateDay = (int)currentDate.DayOfWeek;
            DateTime currentDateFriday = currentDate.AddDays(5 - currentDateDay);

            int currentDateFridayYear = currentDateFriday.Year;

            var listOfWorkWeeks = (from t in dbWW.mfg_year_month_ww
                                   where t.mfg_year_no <= currentDateFridayYear + 2 && t.mfg_year_no >= currentDateFridayYear - 1
                                   select t).ToList();

            var listOfWorkWeeksTemp = listOfWorkWeeks.FindAll(x => x.mfg_ww_begin_datetime < currentDateFriday);
            var resultWorkWeekTemp = listOfWorkWeeks.Find(x => x.mfg_ww_end_datetime > currentDateFriday);
            int currentWorkWeek = resultWorkWeekTemp.mfg_year_no * 100 + resultWorkWeekTemp.mfg_ww_no;

            if (currentWorkWeek % 2 != 0) //Sprints always starts on even weeks
            {
                currentDateFriday = currentDateFriday.AddDays(-7);
            }

            DateTime currentDateMinus = currentDateFriday.AddDays(-(weeksMinus * 7));
            listOfWorkWeeksTemp = listOfWorkWeeks.FindAll(x => x.mfg_ww_begin_datetime < currentDateMinus);
            resultWorkWeekTemp = listOfWorkWeeks.Find(x => x.mfg_ww_end_datetime > currentDateMinus);
            int currentDateMinusWW = resultWorkWeekTemp.mfg_year_no * 100 + resultWorkWeekTemp.mfg_ww_no;

            DateTime currentDatePlus = currentDateFriday.AddDays(weeksPlus * 7);

            ViewBag.currentDateMinus = currentDateMinus;
            ViewBag.currentDatePlus = currentDatePlus;
            ViewBag.currentDateMinusWW = currentDateMinusWW;

        }
        private DateTime? getSprintDateFromWorkWeek(string workWeek, int sprintDay)
        {
            if (workWeek != null)
            {
                int year = Int32.Parse(workWeek.Substring(0, 4));
                int ww = Int32.Parse(workWeek.Substring(4, 2));

                var beginDateTime = (from t in dbWW.mfg_year_month_ww
                                     where t.mfg_ww_no == ww && t.mfg_year_no == year
                                     select t.mfg_ww_begin_datetime).FirstOrDefault();
                if(beginDateTime == null)
                {
                    return null;
                }

                DateTime sprintDate = beginDateTime.AddDays(sprintDay);

                return sprintDate;
            }

            return null;

        }
    }
}