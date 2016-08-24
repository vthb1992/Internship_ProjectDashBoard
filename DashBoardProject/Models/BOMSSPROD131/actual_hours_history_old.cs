namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAMS.actual_hours_history_old")]
    public partial class actual_hours_history_old
    {
        [Key]
        [Column(Order = 0)]
        public int entryID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(31)]
        public string eFolderID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mfg_ww_seq_no { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int work_week_no { get; set; }

        [StringLength(31)]
        public string eStageName { get; set; }

        public DateTime? eStartStageTime { get; set; }

        public DateTime? eEndStageTime { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ActualHours { get; set; }
    }
}
