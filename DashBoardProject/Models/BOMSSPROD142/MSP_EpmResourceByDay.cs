namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmResourceByDay
    {
        [Key]
        [Column(Order = 0)]
        public Guid ResourceUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime TimeByDay { get; set; }

        public decimal BaseCapacity { get; set; }

        public decimal Capacity { get; set; }

        public virtual MSP_EpmResource MSP_EpmResource { get; set; }
    }
}
