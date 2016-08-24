namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("eFolderPage")]
    public partial class eFolderPage
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(31)]
        public string eMapName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(31)]
        public string eStageName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(12)]
        public string eLocaleID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short eFolderPageID { get; set; }

        [StringLength(2000)]
        public string eFormName { get; set; }

        [StringLength(2000)]
        public string eCaption { get; set; }
    }
}
