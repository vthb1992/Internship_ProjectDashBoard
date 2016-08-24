namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_TimeByDay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSP_TimeByDay()
        {
            MSP_EpmAssignmentByDay = new HashSet<MSP_EpmAssignmentByDay>();
            MSP_EpmTaskByDay = new HashSet<MSP_EpmTaskByDay>();
        }

        [Key]
        public DateTime TimeByDay { get; set; }

        public byte TimeDayOfTheWeek { get; set; }

        public byte TimeMonthOfTheYear { get; set; }

        public short TimeYear { get; set; }

        public byte TimeDayOfTheMonth { get; set; }

        public byte TimeWeekOfTheYear { get; set; }

        public byte TimeQuarter { get; set; }

        public int? FiscalYear { get; set; }

        public int? FiscalQuarter { get; set; }

        [StringLength(255)]
        public string FiscalPeriodName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmAssignmentByDay> MSP_EpmAssignmentByDay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmTaskByDay> MSP_EpmTaskByDay { get; set; }
    }
}
