namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAMS.factory_systems")]
    public partial class factory_systems
    {
        [Key]
        [Column(Order = 0)]
        public int factory_system_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string factory_system_name { get; set; }

        public int service_manager { get; set; }

        [StringLength(30)]
        public string cq_department { get; set; }

        [StringLength(30)]
        public string cq_group { get; set; }

        [StringLength(100)]
        public string cq_system { get; set; }

        [StringLength(255)]
        public string cq_keywords { get; set; }

        [StringLength(255)]
        public string cq_cc_list { get; set; }

        [StringLength(50)]
        public string cq_review_board_sponsor { get; set; }

        [StringLength(50)]
        public string cq_review_board { get; set; }

        [Required]
        [StringLength(1)]
        public string active_flag { get; set; }

        [Column(TypeName = "ntext")]
        public string fs_description { get; set; }

        [StringLength(50)]
        public string cmsSystem { get; set; }

        [StringLength(50)]
        public string JIRAProject { get; set; }

        [StringLength(50)]
        public string JIRAProjectFilter { get; set; }

        [StringLength(50)]
        public string JIRALabel { get; set; }

        [StringLength(50)]
        public string JIRAReporter { get; set; }

        public int? cq_hours_threshold { get; set; }

        public int? JIRAStoryPointsThreshold { get; set; }

        public DateTime? CQThresholdEffectiveDate { get; set; }

        public DateTime? JIRAThresholdEffectiveDate { get; set; }
    }
}
