namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_WssRisk
    {
        [Key]
        [Column(Order = 0)]
        public Guid ProjectUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RiskUniqueID { get; set; }

        public int RiskID { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(255)]
        public string Status { get; set; }

        [StringLength(255)]
        public string AssignedToResource { get; set; }

        [StringLength(255)]
        public string Owner { get; set; }

        public DateTime? DueDate { get; set; }

        public double? Probability { get; set; }

        public double? Impact { get; set; }

        public double? Exposure { get; set; }

        public double? Cost { get; set; }

        public double? CostExposure { get; set; }

        [StringLength(255)]
        public string Category { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        [Column(TypeName = "ntext")]
        public string MitigationPlan { get; set; }

        [Column(TypeName = "ntext")]
        public string ContingencyPlan { get; set; }

        [StringLength(255)]
        public string TriggerTask { get; set; }

        [Column(TypeName = "ntext")]
        public string TriggerDescription { get; set; }

        public int? NumberOfAttachments { get; set; }

        [StringLength(255)]
        public string CreateByResource { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(255)]
        public string ModifiedByResource { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public bool IsFolder { get; set; }

        [StringLength(1024)]
        public string ItemRelativeUrlPath { get; set; }
    }
}
