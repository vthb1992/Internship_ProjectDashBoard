namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Version
    {
        [Key]
        [Column(Order = 0)]
        public Guid VersionId { get; set; }

        [Column("Version")]
        [Required]
        [StringLength(64)]
        public string Version1 { get; set; }

        [Key]
        [Column(Order = 1)]
        public int Id { get; set; }

        [StringLength(255)]
        public string UserName { get; set; }

        public DateTime? TimeStamp { get; set; }

        public DateTime? FinalizeTimeStamp { get; set; }

        public int? Mode { get; set; }

        public int? ModeStack { get; set; }

        public int Updates { get; set; }

        [StringLength(1024)]
        public string Notes { get; set; }
    }
}
