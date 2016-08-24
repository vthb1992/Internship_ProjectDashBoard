namespace DashBoardProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AuxITGanttChart_Items
    {
        [Key]
        [StringLength(50)]
        public string bscmProjectsID { get; set; }

        [StringLength(50)]
        public string OCLT { get; set; }

        [StringLength(50)]
        public string developer { get; set; }

        [StringLength(50)]
        public string plannedStartWW { get; set; }

        [StringLength(50)]
        public string plannedEndWW { get; set; }

        [StringLength(50)]
        public string actualStartWW { get; set; }

        [StringLength(50)]
        public string actualEndWW { get; set; }

        [StringLength(50)]
        public string needDateWW { get; set; }

        public string developerWorkload { get; set; }

        public DateTime? plannedStartDate { get; set; }
        public DateTime? plannedEndDate { get; set; }
        public DateTime? actualStartDate { get; set; }
        public DateTime? actualEndDate { get; set; }
        public DateTime? needDateDate { get; set; }

        public int numberOfHoursInASprint { get; set; }


    }
}
