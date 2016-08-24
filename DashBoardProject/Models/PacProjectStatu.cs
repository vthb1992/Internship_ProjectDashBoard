namespace DashBoardProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PacProjectStatu
    {
        [Key]
        [StringLength(50)]
        public string projectID { get; set; }

        [StringLength(50)]
        public string status { get; set; }
    }
}
