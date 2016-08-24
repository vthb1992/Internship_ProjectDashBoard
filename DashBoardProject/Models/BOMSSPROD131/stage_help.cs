namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAMS.stage_help")]
    public partial class stage_help
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(31)]
        public string eMapName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(31)]
        public string eStageName { get; set; }

        [Column(TypeName = "ntext")]
        public string stageText { get; set; }

        [StringLength(200)]
        public string stageHelpUrl { get; set; }
    }
}
