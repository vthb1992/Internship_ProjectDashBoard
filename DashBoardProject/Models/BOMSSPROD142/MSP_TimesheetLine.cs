namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_TimesheetLine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSP_TimesheetLine()
        {
            MSP_TimesheetActual = new HashSet<MSP_TimesheetActual>();
        }

        [Key]
        public Guid TimesheetLineUID { get; set; }

        public Guid TimesheetUID { get; set; }

        public Guid ProjectNameUID { get; set; }

        public Guid TaskNameUID { get; set; }

        public Guid AssignmentUID { get; set; }

        public Guid ClassUID { get; set; }

        public byte? ValidationType { get; set; }

        [StringLength(255)]
        public string Comment { get; set; }

        public Guid? ApproverResourceNameUID { get; set; }

        public byte? TimesheetLineStatus { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public DateTime? CreatedDate { get; set; }

        public decimal? LastSavedWork { get; set; }

        [Required]
        public string TaskHierarchy { get; set; }

        public virtual MSP_Timesheet MSP_Timesheet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_TimesheetActual> MSP_TimesheetActual { get; set; }

        public virtual MSP_TimesheetClass MSP_TimesheetClass { get; set; }

        public virtual MSP_TimesheetProject MSP_TimesheetProject { get; set; }

        public virtual MSP_TimesheetTask MSP_TimesheetTask { get; set; }

        public virtual MSP_TimesheetLineStatus MSP_TimesheetLineStatus { get; set; }
    }
}
