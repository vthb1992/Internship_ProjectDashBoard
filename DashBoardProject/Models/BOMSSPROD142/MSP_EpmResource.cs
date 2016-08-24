namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmResource
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSP_EpmResource()
        {
            MSP_EpmAssignment = new HashSet<MSP_EpmAssignment>();
            MSP_EpmAssignment1 = new HashSet<MSP_EpmAssignment>();
            MSP_EpmResourceByDay = new HashSet<MSP_EpmResourceByDay>();
        }

        [Key]
        public Guid ResourceUID { get; set; }

        [Required]
        [StringLength(255)]
        public string ResourceName { get; set; }

        public decimal ResourceStandardRate { get; set; }

        public decimal ResourceOvertimeRate { get; set; }

        public Guid ResourceStatusUID { get; set; }

        [StringLength(255)]
        public string ResourceCode { get; set; }

        public decimal ResourceCostPerUse { get; set; }

        [StringLength(255)]
        public string ResourceEmailAddress { get; set; }

        [StringLength(255)]
        public string ResourceInitials { get; set; }

        [StringLength(255)]
        public string ResourceMaterialLabel { get; set; }

        public short ResourceType { get; set; }

        [StringLength(255)]
        public string ResourceGroup { get; set; }

        public decimal ResourceMaxUnits { get; set; }

        public byte? ResourceBookingType { get; set; }

        public Guid? ResourceTimesheetManagerUID { get; set; }

        public DateTime? ResourceEarliestAvailableFrom { get; set; }

        public DateTime? ResourceLatestAvailableTo { get; set; }

        public bool ResourceCanLevel { get; set; }

        [StringLength(1024)]
        public string ResourceHyperlink { get; set; }

        [StringLength(255)]
        public string ResourceHyperlinkHref { get; set; }

        [StringLength(255)]
        public string ResourceNTAccount { get; set; }

        public bool ResourceIsActive { get; set; }

        public bool ResourceIsGeneric { get; set; }

        public bool ResourceIsTeam { get; set; }

        [StringLength(255)]
        public string ResourceBaseCalendar { get; set; }

        public short? ResourceWorkgroup { get; set; }

        public int ResourceClientUniqueId { get; set; }

        [StringLength(255)]
        public string ResourceCostCenter { get; set; }

        public int ResourceCreatedRevisionCounter { get; set; }

        public int ResourceModifiedRevisionCounter { get; set; }

        public DateTime ResourceCreatedDate { get; set; }

        public DateTime ResourceModifiedDate { get; set; }

        public int? LCID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmAssignment> MSP_EpmAssignment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmAssignment> MSP_EpmAssignment1 { get; set; }

        public virtual MSP_EpmResourceStatus MSP_EpmResourceStatus { get; set; }

        public virtual MSP_EpmResourceType MSP_EpmResourceType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmResourceByDay> MSP_EpmResourceByDay { get; set; }
    }
}
