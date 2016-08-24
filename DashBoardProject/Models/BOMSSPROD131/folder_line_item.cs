namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAMS.folder_line_item")]
    public partial class folder_line_item
    {
        public int id { get; set; }

        [Required]
        [StringLength(31)]
        public string folderID { get; set; }

        public int item_ID { get; set; }

        public int value { get; set; }

        [StringLength(200)]
        public string note { get; set; }

        public virtual line_item line_item { get; set; }
    }
}
