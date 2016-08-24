namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAMS.fsrb_factory_system_xref")]
    public partial class fsrb_factory_system_xref
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int fsrb_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int factory_system_id { get; set; }

        public virtual fsrb fsrb { get; set; }
    }
}
