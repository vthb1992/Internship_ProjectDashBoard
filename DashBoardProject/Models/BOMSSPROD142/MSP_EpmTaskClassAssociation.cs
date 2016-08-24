namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmTaskClassAssociation
    {
        [Key]
        [Column(Order = 0)]
        public Guid PeriodUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid TimesheetClassUID { get; set; }

        public Guid TaskUID { get; set; }
    }
}
