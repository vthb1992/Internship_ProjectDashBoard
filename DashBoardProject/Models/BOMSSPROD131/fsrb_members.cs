namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAMS.fsrb_members")]
    public partial class fsrb_members
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int fsrb_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int worker_no { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string role_name { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string assigned_facility { get; set; }

        [Required]
        [StringLength(1)]
        public string fsrb_lead { get; set; }

        [Required]
        [StringLength(1)]
        public string allowed_to_approve { get; set; }

        public virtual facility facility { get; set; }

        public virtual fsrb fsrb { get; set; }
    }
}
