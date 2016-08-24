namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_TimesheetActual
    {
        [Key]
        [Column(Order = 0)]
        public Guid TimesheetLineUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime TimeByDay { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AdjustmentIndex { get; set; }

        public Guid LastChangedResourceNameUID { get; set; }

        public DateTime CreatedDate { get; set; }

        public byte TimeByDay_DayOfWeek { get; set; }

        public byte TimeByDay_DayOfMonth { get; set; }

        public Guid AdjustmentUID { get; set; }

        public decimal ActualWorkBillable { get; set; }

        public decimal ActualWorkNonBillable { get; set; }

        public decimal ActualOvertimeWorkBillable { get; set; }

        public decimal ActualOvertimeWorkNonBillable { get; set; }

        public decimal PlannedWork { get; set; }

        [StringLength(255)]
        public string Comment { get; set; }

        public virtual MSP_TimesheetResource MSP_TimesheetResource { get; set; }

        public virtual MSP_TimesheetLine MSP_TimesheetLine { get; set; }
    }
}
