namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmTaskBaseline
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BaselineNumber { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid ProjectUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid TaskUID { get; set; }

        public decimal TaskBaselineCost { get; set; }

        public decimal TaskBaselineFixedCost { get; set; }

        public decimal TaskBaselineWork { get; set; }

        public decimal TaskBaselineBudgetCost { get; set; }

        public decimal TaskBaselineBudgetWork { get; set; }

        public DateTime? TaskBaselineStartDate { get; set; }

        public DateTime? TaskBaselineFinishDate { get; set; }

        public DateTime? TaskBaselineDeliverableStartDate { get; set; }

        public DateTime? TaskBaselineDeliverableFinishDate { get; set; }

        public decimal TaskBaselineDuration { get; set; }

        [StringLength(255)]
        public string TaskBaselineDurationString { get; set; }

        [StringLength(255)]
        public string TaskBaselineFinishDateString { get; set; }

        [StringLength(255)]
        public string TaskBaselineStartDateString { get; set; }

        public virtual MSP_EpmTask MSP_EpmTask { get; set; }
    }
}
