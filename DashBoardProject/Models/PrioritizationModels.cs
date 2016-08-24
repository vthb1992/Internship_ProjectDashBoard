using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DashBoardProject.Models
{
    //[Serializable]
    //[XmlRoot("Issues"), XmlType("Issues")]
    //public class Issues:IComparable<Issues>
    //{
    //    public string bscmProjectsID { get; set; }
    //    public string bscmProjectsName { get; set; }
    //    public string PAC { get; set; }
    //    public int pacRank { get; set; }
    //    public int overallRank { get; set; }
    //    public string ITHR { get; set; }
    //    public string benefit { get; set; }


    //    public int CompareTo(Issues i)
    //    {
    //        return this.overallRank.CompareTo(i.overallRank);

    //    }
    //}

   
    public class PrioritizeProjectPAC : IComparable<PrioritizeProjectPAC>
    {
        public string projectUID { get; set; }
        public string projectID { get; set; }
        public string projectTitle { get; set; }
        public string PAC { get; set; }
        public int pacRank { get; set; }
        public int overallRank { get; set; }
        public string ITHR { get; set; }
        public string benefit { get; set; }

        public int CompareTo(PrioritizeProjectPAC i)
        {
            return this.pacRank.CompareTo(i.pacRank);

        }
    }

    public class PrioritizeProjectOverall : IComparable<PrioritizeProjectOverall>
    {
        public string projectUID { get; set; }
        public string projectID { get; set; }
        public string projectTitle { get; set; }
        public string PAC { get; set; }
        public int pacRank { get; set; }
        public int overallRank { get; set; }
        public string ITHR { get; set; }
        public string benefit { get; set; }

        public int CompareTo(PrioritizeProjectOverall i)
        {
            if (this.overallRank.CompareTo(i.overallRank) == 0)
            {
                if(this.PAC.CompareTo(i.PAC) == 0)
                {
                    return this.pacRank.CompareTo(i.pacRank);
                }
                return this.PAC.CompareTo(i.PAC);
            }
            return this.overallRank.CompareTo(i.overallRank);

        }
    }


}