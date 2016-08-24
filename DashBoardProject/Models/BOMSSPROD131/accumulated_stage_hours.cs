namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAMS.accumulated_stage_hours")]
    public partial class accumulated_stage_hours
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(31)]
        public string eFolderID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(31)]
        public string eFromStage { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WW { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? total_hours { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? accumulated_hours { get; set; }
    }
}
