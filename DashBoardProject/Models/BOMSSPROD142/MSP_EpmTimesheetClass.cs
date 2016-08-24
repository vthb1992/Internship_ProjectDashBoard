namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmTimesheetClass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSP_EpmTimesheetClass()
        {
            MSP_EpmAssignment = new HashSet<MSP_EpmAssignment>();
        }

        [Key]
        public Guid ClassUID { get; set; }

        public byte Type { get; set; }

        [Required]
        [StringLength(255)]
        public string ClassName { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        public int? LCID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmAssignment> MSP_EpmAssignment { get; set; }
    }
}
