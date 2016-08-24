namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_TimesheetPeriod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSP_TimesheetPeriod()
        {
            MSP_Timesheet = new HashSet<MSP_Timesheet>();
        }

        [Key]
        public Guid PeriodUID { get; set; }

        public byte PeriodStatusID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [Required]
        [StringLength(255)]
        public string PeriodName { get; set; }

        public int? LCID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_Timesheet> MSP_Timesheet { get; set; }

        public virtual MSP_TimesheetPeriodStatus MSP_TimesheetPeriodStatus { get; set; }
    }
}
