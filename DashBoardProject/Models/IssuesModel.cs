namespace DashBoardProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IssuesModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(10)]
        public string issueList { get; set; }

        [StringLength(10)]
        public string BscmProject { get; set; }

        [StringLength(10)]
        public string issueID { get; set; }

        [StringLength(10)]
        public string name { get; set; }

        [StringLength(10)]
        public string PAC { get; set; }

        public int? rank { get; set; }

        [StringLength(10)]
        public string ITHR { get; set; }

        [StringLength(10)]
        public string benefit { get; set; }

        [StringLength(10)]
        public string creator { get; set; }
    }
}
