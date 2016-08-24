namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_MSP_EpmProject_IS_ProjectNames
    {
        [Key]
        [Column("Project Name", Order = 0)]
        [StringLength(255)]
        public string Project_Name { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ProjectUID { get; set; }
    }
}
