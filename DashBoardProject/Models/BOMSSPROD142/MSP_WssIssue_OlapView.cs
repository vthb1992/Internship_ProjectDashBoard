namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_WssIssue_OlapView
    {
        [Key]
        [Column(Order = 0)]
        public Guid ProjectUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid IssueUniqueID { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(255)]
        public string AssignedToResource { get; set; }

        public DateTime? DueDate { get; set; }

        [StringLength(255)]
        public string Category { get; set; }

        [StringLength(255)]
        public string Status { get; set; }

        [StringLength(255)]
        public string Priority { get; set; }

        [StringLength(255)]
        public string Owner { get; set; }

        [Column(TypeName = "ntext")]
        public string Discussion { get; set; }

        [Column(TypeName = "ntext")]
        public string Resolution { get; set; }

        [StringLength(255)]
        public string CreateByResource { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(1024)]
        public string ItemRelativeUrlPath { get; set; }

        public int? TasksAffectedByIssue { get; set; }

        public int? TasksToResolveThisIssue { get; set; }

        public int? TasksLinkedToIssue { get; set; }

        public int? RisksLinkedToIssue { get; set; }

        public int? IssuesLinkedToIssue { get; set; }

        public int? DocumentsAttachedToIssue { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IssueCount { get; set; }
    }
}
