namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_TimesheetClass_OlapView
    {
        [Key]
        [Column(Order = 0)]
        public Guid ClassUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte Type { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string ClassName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1000)]
        public string Description { get; set; }

        public int? LCID { get; set; }
    }
}
