namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAMS.bams_lookup")]
    public partial class bams_lookup
    {
        public int id { get; set; }

        public int? sequence { get; set; }

        [Required]
        [StringLength(20)]
        public string groupName { get; set; }

        [Required]
        [StringLength(200)]
        public string lookupName { get; set; }

        public int? lookupValueInt { get; set; }

        [StringLength(200)]
        public string lookupValueString { get; set; }
    }
}
