namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmWorkflowStatusInformation
    {
        [Key]
        [Column(Order = 0)]
        public Guid ProjectUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid StageUID { get; set; }

        public int StageOrder { get; set; }

        public int StageStatus { get; set; }

        public DateTime? StageEntryDate { get; set; }

        public DateTime? StageCompletionDate { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        [StringLength(4000)]
        public string StageInformation { get; set; }

        public virtual MSP_EpmProject MSP_EpmProject { get; set; }

        public virtual MSP_EpmWorkflowStage MSP_EpmWorkflowStage { get; set; }
    }
}
