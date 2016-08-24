namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAMS.departments")]
    public partial class department
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public department()
        {
            department_billto = new HashSet<department_billto>();
            department_facility_xref = new HashSet<department_facility_xref>();
            department_fsrb_xref = new HashSet<department_fsrb_xref>();
            strategic_directives = new HashSet<strategic_directives>();
        }

        [Key]
        [Column("department")]
        [StringLength(40)]
        public string department1 { get; set; }

        [Required]
        [StringLength(1)]
        public string active_flag { get; set; }

        [StringLength(255)]
        public string role_router { get; set; }

        [Required]
        [StringLength(1)]
        public string require_triage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<department_billto> department_billto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<department_facility_xref> department_facility_xref { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<department_fsrb_xref> department_fsrb_xref { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<strategic_directives> strategic_directives { get; set; }
    }
}
