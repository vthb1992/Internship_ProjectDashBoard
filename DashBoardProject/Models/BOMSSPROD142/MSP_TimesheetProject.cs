namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_TimesheetProject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSP_TimesheetProject()
        {
            MSP_TimesheetLine = new HashSet<MSP_TimesheetLine>();
            MSP_TimesheetProject1 = new HashSet<MSP_TimesheetProject>();
        }

        [Key]
        public Guid ProjectNameUID { get; set; }

        public Guid ProjectUID { get; set; }

        public Guid? ParentProjectNameUID { get; set; }

        [Required]
        [StringLength(255)]
        public string ProjectName { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LatestDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_TimesheetLine> MSP_TimesheetLine { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_TimesheetProject> MSP_TimesheetProject1 { get; set; }

        public virtual MSP_TimesheetProject MSP_TimesheetProject2 { get; set; }
    }
}
