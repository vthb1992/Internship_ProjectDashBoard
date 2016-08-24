namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_TimesheetPeriodStatus_OlapView
    {
        [Key]
        [Column(Order = 0)]
        public byte PeriodStatusID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1000)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LCID { get; set; }
    }
}
