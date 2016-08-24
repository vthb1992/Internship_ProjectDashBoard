namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmPlannerDecisionType
    {
        [Key]
        [Column(Order = 0)]
        public byte PlannerDecisionID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LCID { get; set; }

        [StringLength(255)]
        public string PlannerDecisionName { get; set; }
    }
}
