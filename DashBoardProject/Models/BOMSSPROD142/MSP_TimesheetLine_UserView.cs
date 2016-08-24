namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_TimesheetLine_UserView
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string PeriodName { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid PeriodUID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1000)]
        public string PeriodStatus { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte PeriodStatusID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(255)]
        public string TimesheetName { get; set; }

        [Key]
        [Column(Order = 5)]
        public Guid TimesheetUID { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(1000)]
        public string TimesheetStatus { get; set; }

        [Key]
        [Column(Order = 7)]
        public byte TimesheetStatusID { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(255)]
        public string TimesheetLineClass { get; set; }

        [Key]
        [Column(Order = 9)]
        public Guid TimesheetLineClassUID { get; set; }

        [Key]
        [Column(Order = 10)]
        public byte TimesheetLineClassType { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(255)]
        public string ResourceName { get; set; }

        [Key]
        [Column(Order = 12)]
        public Guid ResourceUID { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(255)]
        public string ProjectName { get; set; }

        [Key]
        [Column(Order = 14)]
        public Guid ProjectUID { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(255)]
        public string TaskName { get; set; }

        [Key]
        [Column(Order = 16)]
        public Guid TaskUID { get; set; }

        [Key]
        [Column(Order = 17)]
        public Guid TimesheetLineUID { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(1000)]
        public string TimesheetLineStatus { get; set; }

        [Key]
        [Column(Order = 19)]
        public byte TimesheetLineStatusID { get; set; }

        public decimal? PlannedWork { get; set; }

        public decimal? ActualWorkBillable { get; set; }

        public decimal? ActualWorkNonBillable { get; set; }

        public decimal? ActualOvertimeWorkBillable { get; set; }

        public decimal? ActualOvertimeWorkNonBillable { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [Key]
        [Column(Order = 20)]
        public DateTime PeriodStartDate { get; set; }

        [Key]
        [Column(Order = 21)]
        public DateTime PeriodEndDate { get; set; }

        [StringLength(4000)]
        public string RBS { get; set; }
    }
}
