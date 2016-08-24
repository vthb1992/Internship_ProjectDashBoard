namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAMS.completed_tasks")]
    public partial class completed_tasks
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(31)]
        public string eFolderID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime ins_date { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(250)]
        public string taskType { get; set; }

        [Required]
        [StringLength(250)]
        public string username { get; set; }

        public string taskValue { get; set; }
    }
}
