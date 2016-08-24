using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DashBoardProject.Models
{
    public class Bscm
    {
        public string eFolderID { get; set; }
        public string bscmID { get; set; }
        public string description { get; set; }
        public string department { get; set; }
        public string currentStage { get; set; }
        public DateTime? creationTime { get; set; }
        public string creationTimeDisplay { get; set; }
        public string fsrbGroupName { get; set; }
        public int? IS_HoursEstimate { get; set; }
        public string hoursEstActual { get; set; }
        public string primaryStakeholder { get; set; }
        public string submitterUsername { get; set; }
        public string JIRA_Key { get; set; }

    }

    public class GanttChartItem : IComparable<GanttChartItem>
    {
        public string itemUID { get; set; }
        public string itemID { get; set; }
        public string itemName { get; set; }
        public string PAC { get; set; }
        [Required]
        public string rankingStatus { get; set; }
        public int overallRank { get; set; }

        public int ITHR { get; set; }
        public string developer { get; set; }
        public string plannedStartWorkWeek { get; set; }
        public string plannedEndWorkWeek { get; set; }
        public string actualStartWorkWeek { get; set; }
        public string actualEndWorkWeek { get; set; }
        public string deadlineWorkWeek { get; set; }
        public string developerWorkload { get; set; }

        public int numberOfHoursInSprint { get; set; }

        public int CompareTo(GanttChartItem i)
        {
            if(this.rankingStatus == "IF" && i.rankingStatus == "IF")
            {
                return this.overallRank.CompareTo(i.overallRank);
            }else if(this.rankingStatus == "IF")
            {
                return -1;
            }else if(i.rankingStatus == "IF")
            {
                return 1;
            }else
            {
                return this.overallRank.CompareTo(i.overallRank);
            }
        }

    }

}