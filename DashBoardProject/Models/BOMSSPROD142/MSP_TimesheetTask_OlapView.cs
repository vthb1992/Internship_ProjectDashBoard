namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_TimesheetTask_OlapView
    {
        [Key]
        [Column(Order = 0)]
        public Guid TaskNameUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid TaskUID { get; set; }

        public Guid? ParentTaskNameUID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string TaskName { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime CreatedDate { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime LatestDate { get; set; }
    }
}
