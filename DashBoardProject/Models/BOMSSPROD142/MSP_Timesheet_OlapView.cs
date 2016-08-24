namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_Timesheet_OlapView
    {
        [Key]
        [Column(Order = 0)]
        public Guid TimesheetUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid OwnerResourceNameUID { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid PeriodUID { get; set; }

        public Guid? LastStatusChangeResourceNameUID { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte TimesheetStatusID { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime CreatedDate { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime ModifiedDate { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(255)]
        public string TimesheetName { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "ntext")]
        public string Comment { get; set; }
    }
}
