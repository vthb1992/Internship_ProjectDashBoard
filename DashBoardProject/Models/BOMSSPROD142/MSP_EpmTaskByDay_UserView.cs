namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmTaskByDay_UserView
    {
        public Guid? TaskUID { get; set; }

        public DateTime? TimeByDay { get; set; }

        public Guid? ProjectUID { get; set; }

        public bool? TaskIsActive { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TaskCount { get; set; }

        public decimal? TaskBaseline0Cost { get; set; }

        public decimal? TaskBaseline0FixedCost { get; set; }

        public decimal? TaskBaseline0Work { get; set; }

        public decimal? TaskBaseline0BudgetCost { get; set; }

        public decimal? TaskBaseline0BudgetWork { get; set; }

        public decimal? TaskBaseline1Cost { get; set; }

        public decimal? TaskBaseline1FixedCost { get; set; }

        public decimal? TaskBaseline1Work { get; set; }

        public decimal? TaskBaseline1BudgetCost { get; set; }

        public decimal? TaskBaseline1BudgetWork { get; set; }

        public decimal? TaskBaseline2Cost { get; set; }

        public decimal? TaskBaseline2FixedCost { get; set; }

        public decimal? TaskBaseline2Work { get; set; }

        public decimal? TaskBaseline2BudgetCost { get; set; }

        public decimal? TaskBaseline2BudgetWork { get; set; }

        public decimal? TaskBaseline3Cost { get; set; }

        public decimal? TaskBaseline3FixedCost { get; set; }

        public decimal? TaskBaseline3Work { get; set; }

        public decimal? TaskBaseline3BudgetCost { get; set; }

        public decimal? TaskBaseline3BudgetWork { get; set; }

        public decimal? TaskBaseline4Cost { get; set; }

        public decimal? TaskBaseline4FixedCost { get; set; }

        public decimal? TaskBaseline4Work { get; set; }

        public decimal? TaskBaseline4BudgetCost { get; set; }

        public decimal? TaskBaseline4BudgetWork { get; set; }

        public decimal? TaskBaseline5Cost { get; set; }

        public decimal? TaskBaseline5FixedCost { get; set; }

        public decimal? TaskBaseline5Work { get; set; }

        public decimal? TaskBaseline5BudgetCost { get; set; }

        public decimal? TaskBaseline5BudgetWork { get; set; }

        public decimal? TaskBaseline6Cost { get; set; }

        public decimal? TaskBaseline6FixedCost { get; set; }

        public decimal? TaskBaseline6Work { get; set; }

        public decimal? TaskBaseline6BudgetCost { get; set; }

        public decimal? TaskBaseline6BudgetWork { get; set; }

        public decimal? TaskBaseline7Cost { get; set; }

        public decimal? TaskBaseline7FixedCost { get; set; }

        public decimal? TaskBaseline7Work { get; set; }

        public decimal? TaskBaseline7BudgetCost { get; set; }

        public decimal? TaskBaseline7BudgetWork { get; set; }

        public decimal? TaskBaseline8Cost { get; set; }

        public decimal? TaskBaseline8FixedCost { get; set; }

        public decimal? TaskBaseline8Work { get; set; }

        public decimal? TaskBaseline8BudgetCost { get; set; }

        public decimal? TaskBaseline8BudgetWork { get; set; }

        public decimal? TaskBaseline9Cost { get; set; }

        public decimal? TaskBaseline9FixedCost { get; set; }

        public decimal? TaskBaseline9Work { get; set; }

        public decimal? TaskBaseline9BudgetCost { get; set; }

        public decimal? TaskBaseline9BudgetWork { get; set; }

        public decimal? TaskBaseline10Cost { get; set; }

        public decimal? TaskBaseline10FixedCost { get; set; }

        public decimal? TaskBaseline10Work { get; set; }

        public decimal? TaskBaseline10BudgetCost { get; set; }

        public decimal? TaskBaseline10BudgetWork { get; set; }
    }
}
