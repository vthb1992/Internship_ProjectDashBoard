namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_TimesheetClass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSP_TimesheetClass()
        {
            MSP_TimesheetLine = new HashSet<MSP_TimesheetLine>();
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
        public virtual ICollection<MSP_TimesheetLine> MSP_TimesheetLine { get; set; }
    }
}
