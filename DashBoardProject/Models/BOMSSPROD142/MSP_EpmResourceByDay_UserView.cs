namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmResourceByDay_UserView
    {
        [Key]
        [Column(Order = 0)]
        public Guid ResourceUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime TimeByDay { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal BaseCapacity { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal Capacity { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ResourceCount { get; set; }
    }
}
