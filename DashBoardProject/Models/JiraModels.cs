using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Atlassian.Jira;

namespace DashBoardProject.Models
{
    public class JiraIssues
    {
        public string key { get; set; }
        public string type { get; set; }
        public string summary { get; set; }
        public string status { get; set; }
        public string assignee { get; set; }
        public string priority { get; set; }
        public string resolution { get; set; }
        public string sprint { get; set; }
        

        public List<Issue> issuesInEpic { get; set; }

    }
}