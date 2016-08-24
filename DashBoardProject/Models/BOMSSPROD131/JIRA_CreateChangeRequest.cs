namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAMS.JIRA_CreateChangeRequest")]
    public partial class JIRA_CreateChangeRequest
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string ProjectName { get; set; }

        public int? JIRA_ID { get; set; }

        [StringLength(50)]
        public string JIRA_Key { get; set; }

        [StringLength(20)]
        public string issueType { get; set; }

        [StringLength(20)]
        public string Priority { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; }

        [Required]
        [StringLength(31)]
        public string FolderId { get; set; }

        public DateTime RequestedOn { get; set; }

        public DateTime? ProcessedOn { get; set; }

        public int? FailedAttempts { get; set; }

        [Column(TypeName = "text")]
        public string Error { get; set; }

        [StringLength(20)]
        public string Submitter { get; set; }

        [StringLength(255)]
        public string Watchlist { get; set; }

        [StringLength(50)]
        public string Reporter { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        [StringLength(255)]
        public string Summary { get; set; }

        [Required]
        [StringLength(20)]
        public string Assignee { get; set; }

        public DateTime? Date_Required { get; set; }

        [StringLength(1)]
        public string LeadOverride { get; set; }
    }
}
