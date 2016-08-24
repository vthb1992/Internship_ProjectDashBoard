namespace DashBoardProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mfg_year_month_ww
    {
        [Required]
        [MaxLength(8)]
        public byte[] mfg_year_month_ww_OID { get; set; }

        public int mfg_ww_seq_no { get; set; }

        public int mfg_year_no { get; set; }

        public int mfg_month_no { get; set; }

        public int mfg_ww_no { get; set; }

        [Key]
        public DateTime mfg_ww_begin_datetime { get; set; }

        public DateTime mfg_ww_end_datetime { get; set; }
    }
}
