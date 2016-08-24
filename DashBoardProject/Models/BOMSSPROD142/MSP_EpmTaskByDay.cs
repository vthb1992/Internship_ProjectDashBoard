namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmTaskByDay
    {
        [Key]
        [Column(Order = 0)]
        public Guid TaskUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime TimeByDay { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid ProjectUID { get; set; }

        public bool TaskIsActive { get; set; }

        public virtual MSP_EpmProject MSP_EpmProject { get; set; }

        public virtual MSP_EpmTask MSP_EpmTask { get; set; }

        public virtual MSP_TimeByDay MSP_TimeByDay { get; set; }
    }
}
