namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAMS.fsrb_folder_priority")]
    public partial class fsrb_folder_priority
    {
        [Key]
        [StringLength(50)]
        public string folderID { get; set; }

        public int case_build_priority { get; set; }

        public DateTime upd_datetime { get; set; }
    }
}
