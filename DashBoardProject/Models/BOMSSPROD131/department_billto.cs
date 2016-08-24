namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAMS.department_billto")]
    public partial class department_billto
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string department { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string bill_to { get; set; }

        public virtual department department1 { get; set; }
    }
}
