namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_TimesheetResource_OlapView
    {
        [Key]
        [Column(Order = 0)]
        public Guid ResourceNameUID { get; set; }

        public Guid? ParentResourceNameUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ResourceUID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string ResourceName { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime CreatedDate { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime LatestDate { get; set; }

        public int? LCID { get; set; }
    }
}
