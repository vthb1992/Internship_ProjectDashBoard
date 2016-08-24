namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_Timesheet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSP_Timesheet()
        {
            MSP_TimesheetLine = new HashSet<MSP_TimesheetLine>();
        }

        [Key]
        public Guid TimesheetUID { get; set; }

        public Guid OwnerResourceNameUID { get; set; }

        public Guid PeriodUID { get; set; }

        public Guid? LastStatusChangeResourceNameUID { get; set; }

        public byte TimesheetStatusID { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        [Required]
        [StringLength(255)]
        public string TimesheetName { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Comment { get; set; }

        public virtual MSP_TimesheetPeriod MSP_TimesheetPeriod { get; set; }

        public virtual MSP_TimesheetResource MSP_TimesheetResource { get; set; }

        public virtual MSP_TimesheetStatus MSP_TimesheetStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_TimesheetLine> MSP_TimesheetLine { get; set; }
    }
}
