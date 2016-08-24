namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAMS.legacy_event")]
    public partial class legacy_event
    {
        [Key]
        [StringLength(31)]
        public string folderID { get; set; }

        public DateTime creationTime { get; set; }

        public DateTime? entryTime { get; set; }

        [Required]
        [StringLength(31)]
        public string stageName { get; set; }

        [Required]
        [StringLength(100)]
        public string originator { get; set; }
    }
}
