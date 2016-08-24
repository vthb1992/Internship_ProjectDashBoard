namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAMS.accumulated_actual_hours")]
    public partial class accumulated_actual_hours
    {
        public int id { get; set; }

        [StringLength(31)]
        public string eFolderID { get; set; }

        [StringLength(31)]
        public string eFromStage { get; set; }

        [StringLength(31)]
        public string eFolderName { get; set; }

        public int? WW { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? total_hours { get; set; }

        public double? accumulated_hours { get; set; }
    }
}
