namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_TimesheetPeriodStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSP_TimesheetPeriodStatus()
        {
            MSP_TimesheetPeriod = new HashSet<MSP_TimesheetPeriod>();
        }

        [Key]
        public byte PeriodStatusID { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        public int LCID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_TimesheetPeriod> MSP_TimesheetPeriod { get; set; }
    }
}
