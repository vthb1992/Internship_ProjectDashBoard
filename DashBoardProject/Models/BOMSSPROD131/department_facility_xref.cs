namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAMS.department_facility_xref")]
    public partial class department_facility_xref
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string department { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string facility_id { get; set; }

        [StringLength(255)]
        public string site_coordinator { get; set; }

        [StringLength(255)]
        public string submitter_group { get; set; }

        [Required]
        [StringLength(1)]
        public string require_approval { get; set; }

        [Required]
        [StringLength(1)]
        public string supervisor_bypass { get; set; }

        [StringLength(255)]
        public string role_router { get; set; }

        public virtual department department1 { get; set; }

        public virtual facility facility { get; set; }
    }
}
