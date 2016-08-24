namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAMS.department_fsrb_xref")]
    public partial class department_fsrb_xref
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string department { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string fsrb_group_name { get; set; }

        public int fsrb_id { get; set; }

        public virtual department department1 { get; set; }

        public virtual fsrb fsrb { get; set; }
    }
}
