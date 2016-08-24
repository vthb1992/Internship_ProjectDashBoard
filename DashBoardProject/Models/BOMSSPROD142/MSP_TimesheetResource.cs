namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_TimesheetResource
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSP_TimesheetResource()
        {
            MSP_Timesheet = new HashSet<MSP_Timesheet>();
            MSP_TimesheetActual = new HashSet<MSP_TimesheetActual>();
            MSP_TimesheetResource1 = new HashSet<MSP_TimesheetResource>();
        }

        [Key]
        public Guid ResourceNameUID { get; set; }

        public Guid? ParentResourceNameUID { get; set; }

        public Guid ResourceUID { get; set; }

        [Required]
        [StringLength(255)]
        public string ResourceName { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LatestDate { get; set; }

        public int? LCID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_Timesheet> MSP_Timesheet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_TimesheetActual> MSP_TimesheetActual { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_TimesheetResource> MSP_TimesheetResource1 { get; set; }

        public virtual MSP_TimesheetResource MSP_TimesheetResource2 { get; set; }
    }
}
