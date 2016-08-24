namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmProjectDecision_UserView
    {
        [Key]
        [Column(Order = 0)]
        public Guid ProjectUID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string ProjectName { get; set; }

        public Guid? OptimizerSolutionUID { get; set; }

        [StringLength(255)]
        public string OptimizerSolutionName { get; set; }

        public Guid? PlannerSolutionUID { get; set; }

        [StringLength(255)]
        public string PlannerSolutionName { get; set; }

        public byte? OptimizerDecisionID { get; set; }

        public byte? PlannerDecisionID { get; set; }

        public DateTime? PlannerStartDate { get; set; }

        public DateTime? PlannerEndDate { get; set; }

        public DateTime? OptimizerCommitDate { get; set; }

        public DateTime? PlannerCommitDate { get; set; }

        public Guid? OptimizerDecisionAliasMemberUID { get; set; }

        public Guid? OptimizerDecisionAliasLookupTableUID { get; set; }

        public Guid? PlannerDecisionAliasLookupTableUID { get; set; }

        public Guid? PlannerDecisionAliasMemberUID { get; set; }
    }
}
