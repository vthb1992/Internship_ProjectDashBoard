namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAMS.fsrbs")]
    public partial class fsrb
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fsrb()
        {
            department_fsrb_xref = new HashSet<department_fsrb_xref>();
            fsrb_factory_system_xref = new HashSet<fsrb_factory_system_xref>();
            fsrb_members = new HashSet<fsrb_members>();
        }

        [Key]
        public int fsrb_id { get; set; }

        [Required]
        [StringLength(40)]
        public string fsrb_group_name { get; set; }

        [Required]
        [StringLength(255)]
        public string fsrb_desc { get; set; }

        [Required]
        [StringLength(1)]
        public string active_flag { get; set; }

        public int? fsrb_aging_threshold { get; set; }

        [StringLength(1)]
        public string fsrbOverrideAging { get; set; }

        public int? fsrb_backlog_aging { get; set; }

        [StringLength(1)]
        public string auto_route_hours_est { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<department_fsrb_xref> department_fsrb_xref { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fsrb_factory_system_xref> fsrb_factory_system_xref { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fsrb_members> fsrb_members { get; set; }
    }
}
