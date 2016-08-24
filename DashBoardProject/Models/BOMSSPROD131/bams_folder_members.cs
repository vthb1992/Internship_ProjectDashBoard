namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAMS.bams_folder_members")]
    public partial class bams_folder_members
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string folderID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string assignedFacility { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string eUserName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string roleName { get; set; }

        [Required]
        [StringLength(1)]
        public string lead { get; set; }

        [Required]
        [StringLength(1)]
        public string allowedToApprove { get; set; }
    }
}
