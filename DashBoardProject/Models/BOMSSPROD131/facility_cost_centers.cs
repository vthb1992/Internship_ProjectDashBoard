namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAMS.facility_cost_centers")]
    public partial class facility_cost_centers
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string cost_center_desc { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string facility_id { get; set; }
    }
}
