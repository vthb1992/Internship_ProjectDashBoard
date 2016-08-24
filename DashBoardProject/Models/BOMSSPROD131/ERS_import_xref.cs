namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAMS.ERS_import_xref")]
    public partial class ERS_import_xref
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ERS_facility_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ERS_area_id { get; set; }

        public int fsrb_id { get; set; }

        [StringLength(50)]
        public string facility_id { get; set; }

        [StringLength(40)]
        public string fsrb_name { get; set; }
    }
}
