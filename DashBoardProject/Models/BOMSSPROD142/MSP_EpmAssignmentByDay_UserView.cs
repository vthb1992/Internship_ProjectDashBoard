namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmAssignmentByDay_UserView
    {
        public Guid? AssignmentUID { get; set; }

        public DateTime? TimeByDay { get; set; }

        public Guid? ProjectUID { get; set; }

        public Guid? TaskUID { get; set; }

        [Key]
        [Column(Order = 0)]
        public decimal AssignmentCost { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal AssignmentOvertimeCost { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal AssignmentActualCost { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal AssignmentActualOvertimeCost { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal AssignmentWork { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal AssignmentOvertimeWork { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal AssignmentActualWork { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal AssignmentActualOvertimeWork { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal AssignmentMaterialWork { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal AssignmentMaterialActualWork { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal AssignmentBudgetCost { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal AssignmentBudgetWork { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal AssignmentBudgetMaterialWork { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal AssignmentResourcePlanWork { get; set; }

        public bool? TaskIsActive { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal AssignmentRegularCost { get; set; }

        [Key]
        [Column(Order = 15)]
        public decimal AssignmentRemainingCost { get; set; }

        [Key]
        [Column(Order = 16)]
        public decimal AssignmentRemainingOvertimeCost { get; set; }

        [Key]
        [Column(Order = 17)]
        public decimal AssignmentActualRegularCost { get; set; }

        [Key]
        [Column(Order = 18)]
        public decimal AssignmentRemainingRegularCost { get; set; }

        [Key]
        [Column(Order = 19)]
        public decimal AssignmentRegularWork { get; set; }

        [Key]
        [Column(Order = 20)]
        public decimal AssignmentRemainingWork { get; set; }

        [Key]
        [Column(Order = 21)]
        public decimal AssignmentRemainingOvertimeWork { get; set; }

        [Key]
        [Column(Order = 22)]
        public decimal AssignmentActualRegularWork { get; set; }

        [Key]
        [Column(Order = 23)]
        public decimal AssignmentRemainingRegularWork { get; set; }

        public decimal? AssignmentCombinedWork { get; set; }

        [Key]
        [Column(Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AssignmentCount { get; set; }

        public decimal? AssignmentBaseline0Cost { get; set; }

        public decimal? AssignmentBaseline0Work { get; set; }

        public decimal? AssignmentBaseline0MaterialWork { get; set; }

        public decimal? AssignmentBaseline0BudgetCost { get; set; }

        public decimal? AssignmentBaseline0BudgetWork { get; set; }

        public decimal? AssignmentBaseline0BudgetMaterialWork { get; set; }

        public decimal? AssignmentBaseline1Cost { get; set; }

        public decimal? AssignmentBaseline1Work { get; set; }

        public decimal? AssignmentBaseline1MaterialWork { get; set; }

        public decimal? AssignmentBaseline1BudgetCost { get; set; }

        public decimal? AssignmentBaseline1BudgetWork { get; set; }

        public decimal? AssignmentBaseline1BudgetMaterialWork { get; set; }

        public decimal? AssignmentBaseline2Cost { get; set; }

        public decimal? AssignmentBaseline2Work { get; set; }

        public decimal? AssignmentBaseline2MaterialWork { get; set; }

        public decimal? AssignmentBaseline2BudgetCost { get; set; }

        public decimal? AssignmentBaseline2BudgetWork { get; set; }

        public decimal? AssignmentBaseline2BudgetMaterialWork { get; set; }

        public decimal? AssignmentBaseline3Cost { get; set; }

        public decimal? AssignmentBaseline3Work { get; set; }

        public decimal? AssignmentBaseline3MaterialWork { get; set; }

        public decimal? AssignmentBaseline3BudgetCost { get; set; }

        public decimal? AssignmentBaseline3BudgetWork { get; set; }

        public decimal? AssignmentBaseline3BudgetMaterialWork { get; set; }

        public decimal? AssignmentBaseline4Cost { get; set; }

        public decimal? AssignmentBaseline4Work { get; set; }

        public decimal? AssignmentBaseline4MaterialWork { get; set; }

        public decimal? AssignmentBaseline4BudgetCost { get; set; }

        public decimal? AssignmentBaseline4BudgetWork { get; set; }

        public decimal? AssignmentBaseline4BudgetMaterialWork { get; set; }

        public decimal? AssignmentBaseline5Cost { get; set; }

        public decimal? AssignmentBaseline5Work { get; set; }

        public decimal? AssignmentBaseline5MaterialWork { get; set; }

        public decimal? AssignmentBaseline5BudgetCost { get; set; }

        public decimal? AssignmentBaseline5BudgetWork { get; set; }

        public decimal? AssignmentBaseline5BudgetMaterialWork { get; set; }

        public decimal? AssignmentBaseline6Cost { get; set; }

        public decimal? AssignmentBaseline6Work { get; set; }

        public decimal? AssignmentBaseline6MaterialWork { get; set; }

        public decimal? AssignmentBaseline6BudgetCost { get; set; }

        public decimal? AssignmentBaseline6BudgetWork { get; set; }

        public decimal? AssignmentBaseline6BudgetMaterialWork { get; set; }

        public decimal? AssignmentBaseline7Cost { get; set; }

        public decimal? AssignmentBaseline7Work { get; set; }

        public decimal? AssignmentBaseline7MaterialWork { get; set; }

        public decimal? AssignmentBaseline7BudgetCost { get; set; }

        public decimal? AssignmentBaseline7BudgetWork { get; set; }

        public decimal? AssignmentBaseline7BudgetMaterialWork { get; set; }

        public decimal? AssignmentBaseline8Cost { get; set; }

        public decimal? AssignmentBaseline8Work { get; set; }

        public decimal? AssignmentBaseline8MaterialWork { get; set; }

        public decimal? AssignmentBaseline8BudgetCost { get; set; }

        public decimal? AssignmentBaseline8BudgetWork { get; set; }

        public decimal? AssignmentBaseline8BudgetMaterialWork { get; set; }

        public decimal? AssignmentBaseline9Cost { get; set; }

        public decimal? AssignmentBaseline9Work { get; set; }

        public decimal? AssignmentBaseline9MaterialWork { get; set; }

        public decimal? AssignmentBaseline9BudgetCost { get; set; }

        public decimal? AssignmentBaseline9BudgetWork { get; set; }

        public decimal? AssignmentBaseline9BudgetMaterialWork { get; set; }

        public decimal? AssignmentBaseline10Cost { get; set; }

        public decimal? AssignmentBaseline10Work { get; set; }

        public decimal? AssignmentBaseline10MaterialWork { get; set; }

        public decimal? AssignmentBaseline10BudgetCost { get; set; }

        public decimal? AssignmentBaseline10BudgetWork { get; set; }

        public decimal? AssignmentBaseline10BudgetMaterialWork { get; set; }
    }
}
