namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAMS.cms_stage_xref")]
    public partial class cms_stage_xref
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(31)]
        public string BAMS_stage_name { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(31)]
        public string CMS_stage_name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string CMS_name { get; set; }
    }
}
