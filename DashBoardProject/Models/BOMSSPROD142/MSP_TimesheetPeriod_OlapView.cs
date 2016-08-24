namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_TimesheetPeriod_OlapView
    {
        [Key]
        [Column(Order = 0)]
        public Guid PeriodUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte PeriodStatusID { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime StartDate { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime EndDate { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(255)]
        public string PeriodName { get; set; }

        public int? LCID { get; set; }
    }
}
