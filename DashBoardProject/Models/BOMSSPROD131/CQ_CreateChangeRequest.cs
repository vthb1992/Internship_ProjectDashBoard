namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAMS.CQ_CreateChangeRequest")]
    public partial class CQ_CreateChangeRequest
    {
        public int ID { get; set; }

        [StringLength(13)]
        public string CQID { get; set; }

        [Required]
        [StringLength(1)]
        public string Status { get; set; }

        [Required]
        [StringLength(31)]
        public string FolderId { get; set; }

        public DateTime RequestedOn { get; set; }

        public DateTime? ProcessedOn { get; set; }

        public int? FailedAttempts { get; set; }

        [Column(TypeName = "text")]
        public string Error { get; set; }

        [StringLength(30)]
        public string Department { get; set; }

        [StringLength(30)]
        public string SubGroup { get; set; }

        [StringLength(100)]
        public string MicronSystem { get; set; }

        [StringLength(150)]
        public string Submitter { get; set; }

        [StringLength(50)]
        public string Contact { get; set; }

        [StringLength(254)]
        public string Headline { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        [StringLength(50)]
        public string RBSponsor { get; set; }

        [Column(TypeName = "text")]
        public string Contact_CCList { get; set; }

        [StringLength(50)]
        public string CustomerSeverity { get; set; }

        public int? ContactEmpNo { get; set; }

        public int? ReviewBoardRanking { get; set; }

        [Column(TypeName = "text")]
        public string Keywords { get; set; }

        [Column(TypeName = "text")]
        public string Note_Entry { get; set; }

        [StringLength(150)]
        public string ReviewBoard { get; set; }

        public int? EstimatedHours { get; set; }

        [StringLength(50)]
        public string BillTo { get; set; }

        public DateTime? Date_Required { get; set; }

        [StringLength(1)]
        public string LeadOverride { get; set; }
    }
}
