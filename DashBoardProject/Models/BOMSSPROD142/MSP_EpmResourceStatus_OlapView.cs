namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmResourceStatus_OlapView
    {
        [Key]
        [Column(Order = 0)]
        public Guid ResourceStatusUID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string ResourceStatusName { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LCID { get; set; }
    }
}
