namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_TimesheetActual_OlapView
    {
        [Key]
        [Column(Order = 0)]
        public Guid TimesheetLineUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime TimeByDay { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid LastChangedResourceNameUID { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime CreatedDate { get; set; }

        [Key]
        [Column(Order = 4)]
        public byte TimeByDay_DayOfWeek { get; set; }

        [Key]
        [Column(Order = 5)]
        public byte TimeByDay_DayOfMonth { get; set; }

        [Key]
        [Column(Order = 6)]
        public Guid AdjustmentUID { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal ActualWorkBillable { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal ActualWorkNonBillable { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal ActualOvertimeWorkBillable { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal ActualOvertimeWorkNonBillable { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal PlannedWork { get; set; }

        [StringLength(255)]
        public string Comment { get; set; }
    }
}
