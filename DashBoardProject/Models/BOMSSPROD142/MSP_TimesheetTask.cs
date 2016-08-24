namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_TimesheetTask
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSP_TimesheetTask()
        {
            MSP_TimesheetLine = new HashSet<MSP_TimesheetLine>();
            MSP_TimesheetTask1 = new HashSet<MSP_TimesheetTask>();
        }

        [Key]
        public Guid TaskNameUID { get; set; }

        public Guid TaskUID { get; set; }

        public Guid? ParentTaskNameUID { get; set; }

        [Required]
        [StringLength(255)]
        public string TaskName { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LatestDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_TimesheetLine> MSP_TimesheetLine { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_TimesheetTask> MSP_TimesheetTask1 { get; set; }

        public virtual MSP_TimesheetTask MSP_TimesheetTask2 { get; set; }
    }
}
