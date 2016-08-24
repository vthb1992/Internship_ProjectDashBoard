namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAMS.bams_folder_approvals")]
    public partial class bams_folder_approvals
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string folderID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string facility { get; set; }

        public int approvalStatus { get; set; }

        public int? deployVow { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string eUserName { get; set; }

        public DateTime? approvalTime { get; set; }

        [Column(TypeName = "ntext")]
        public string approvalComment { get; set; }
    }
}
