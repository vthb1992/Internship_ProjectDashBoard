namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmAssignmentByDay
    {
        [Key]
        [Column(Order = 0)]
        public Guid AssignmentUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime TimeByDay { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid ProjectUID { get; set; }
        [Column(Order = 2)]
        public Guid TaskUID { get; set; }

        public decimal? AssignmentCost { get; set; }

        public decimal? AssignmentOvertimeCost { get; set; }

        public decimal? AssignmentActualCost { get; set; }

        public decimal? AssignmentActualOvertimeCost { get; set; }

        public decimal? AssignmentWork { get; set; }

        public decimal? AssignmentOvertimeWork { get; set; }

        public decimal? AssignmentActualWork { get; set; }

        public decimal? AssignmentActualOvertimeWork { get; set; }

        public decimal? AssignmentMaterialWork { get; set; }

        public decimal? AssignmentMaterialActualWork { get; set; }

        public decimal AssignmentBudgetCost { get; set; }

        public decimal AssignmentBudgetWork { get; set; }

        public decimal AssignmentBudgetMaterialWork { get; set; }

        public decimal AssignmentResourcePlanWork { get; set; }

        public bool TaskIsActive { get; set; }

        public virtual MSP_EpmAssignment MSP_EpmAssignment { get; set; }

        public virtual MSP_EpmProject MSP_EpmProject { get; set; }

        public virtual MSP_EpmTask MSP_EpmTask { get; set; }

        public virtual MSP_TimeByDay MSP_TimeByDay { get; set; }
    }
}
