namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmAssignment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSP_EpmAssignment()
        {
            MSP_EpmAssignmentByDay = new HashSet<MSP_EpmAssignmentByDay>();
        }

        [Key]
        [Column(Order = 0)]
        public Guid AssignmentUID { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid ProjectUID { get; set; }

        public Guid ResourceUID { get; set; }
        [Column(Order = 1)]
        public Guid TaskUID { get; set; }

        public Guid ResourceOwnerUID { get; set; }

        public decimal? AssignmentCost { get; set; }

        public decimal? AssignmentOvertimeCost { get; set; }

        public decimal? AssignmentActualCost { get; set; }

        public decimal? AssignmentActualOvertimeCost { get; set; }

        public decimal? AssignmentWork { get; set; }

        public decimal? AssignmentOvertimeWork { get; set; }

        public decimal? AssignmentActualWork { get; set; }

        public decimal? AssignmentActualOvertimeWork { get; set; }

        public decimal? AssignmentMaterialWork { get; set; }

        public decimal? AssignmentMaterialActualWork { get; set; }

        public short? AssignmentPercentWorkCompleted { get; set; }

        public DateTime? AssignmentStartDate { get; set; }

        public DateTime? AssignmentFinishDate { get; set; }

        public DateTime? AssignmentActualStartDate { get; set; }

        public DateTime? AssignmentActualFinishDate { get; set; }

        public decimal? AssignmentDelay { get; set; }

        public decimal? AssignmentStartVariance { get; set; }

        public decimal? AssignmentFinishVariance { get; set; }

        public decimal? AssignmentACWP { get; set; }

        public decimal? AssignmentBCWP { get; set; }

        public decimal? AssignmentBCWS { get; set; }

        public int AssignmentBookingID { get; set; }

        public int AssignmentType { get; set; }

        public short? AssignmentResourceType { get; set; }

        public bool IsPublic { get; set; }

        public bool AssignmentIsPublished { get; set; }

        public decimal? AssignmentCostVariance { get; set; }

        public decimal? AssignmentWorkVariance { get; set; }

        public decimal? AssignmentCV { get; set; }

        public decimal? AssignmentSV { get; set; }

        public decimal? AssignmentVAC { get; set; }

        public bool AssignmentIsOverallocated { get; set; }

        public decimal? AssignmentPeakUnits { get; set; }

        public int AssignmentCreatedRevisionCounter { get; set; }

        public int AssignmentModifiedRevisionCounter { get; set; }

        public DateTime AssignmentCreatedDate { get; set; }

        public DateTime AssignmentModifiedDate { get; set; }

        public decimal AssignmentBudgetCost { get; set; }

        public decimal AssignmentBudgetWork { get; set; }

        public decimal AssignmentBudgetMaterialWork { get; set; }

        public decimal AssignmentResourcePlanWork { get; set; }

        public bool TaskIsActive { get; set; }

        public Guid TimesheetClassUID { get; set; }

        public virtual MSP_EpmAssignmentBooking MSP_EpmAssignmentBooking { get; set; }

        public virtual MSP_EpmAssignmentType MSP_EpmAssignmentType { get; set; }

        public virtual MSP_EpmProject MSP_EpmProject { get; set; }

        public virtual MSP_EpmTask MSP_EpmTask { get; set; }

        public virtual MSP_EpmResource MSP_EpmResource { get; set; }

        public virtual MSP_EpmResource MSP_EpmResource1 { get; set; }

        public virtual MSP_EpmTimesheetClass MSP_EpmTimesheetClass { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmAssignmentByDay> MSP_EpmAssignmentByDay { get; set; }
    }
}
