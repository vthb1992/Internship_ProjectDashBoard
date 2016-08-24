namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmAssignmentBaselineByDay
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BaselineNumber { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid AssignmentUID { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime TimeByDay { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid ProjectUID { get; set; }
        [Column(Order = 3)]
        public Guid TaskUID { get; set; }

        public decimal AssignmentBaselineCost { get; set; }

        public decimal AssignmentBaselineWork { get; set; }

        public decimal AssignmentBaselineMaterialWork { get; set; }

        public decimal AssignmentBaselineBudgetCost { get; set; }

        public decimal AssignmentBaselineBudgetWork { get; set; }

        public decimal AssignmentBaselineBudgetMaterialWork { get; set; }

        public virtual MSP_EpmAssignmentBaseline MSP_EpmAssignmentBaseline { get; set; }

        public virtual MSP_EpmProject MSP_EpmProject { get; set; }

        public virtual MSP_EpmTask MSP_EpmTask { get; set; }
    }
}
