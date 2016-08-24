namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmProject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSP_EpmProject()
        {
            MSP_EpmAssignment = new HashSet<MSP_EpmAssignment>();
            MSP_EpmAssignmentBaseline = new HashSet<MSP_EpmAssignmentBaseline>();
            MSP_EpmAssignmentBaselineByDay = new HashSet<MSP_EpmAssignmentBaselineByDay>();
            MSP_EpmAssignmentByDay = new HashSet<MSP_EpmAssignmentByDay>();
            MSP_EpmTask = new HashSet<MSP_EpmTask>();
            MSP_EpmTaskByDay = new HashSet<MSP_EpmTaskByDay>();
            MSP_EpmWorkflowStatusInformation = new HashSet<MSP_EpmWorkflowStatusInformation>();
        }

        [Key]
        public Guid ProjectUID { get; set; }

        [Required]
        [StringLength(255)]
        public string ProjectName { get; set; }

        [StringLength(255)]
        public string ProjectAuthorName { get; set; }

        public Guid ProjectOwnerResourceUID { get; set; }

        [StringLength(255)]
        public string ProjectManagerName { get; set; }

        public int ProjectType { get; set; }

        public DateTime? ProjectStartDate { get; set; }

        public DateTime? ProjectFinishDate { get; set; }

        public DateTime? ProjectStatusDate { get; set; }

        [StringLength(1024)]
        public string ProjectWorkspaceInternalHRef { get; set; }

        public bool ProjectWbsIsStale { get; set; }

        public bool ProjectEarnedValueIsStale { get; set; }

        public bool ProjectRollupsAreStale { get; set; }

        public bool ProjectHierarchyNotSynchronized { get; set; }

        public bool ProjectCalculationsAreStale { get; set; }

        public bool ProjectGhostTaskAreStale { get; set; }

        [Required]
        [StringLength(4)]
        public string ProjectCurrency { get; set; }

        public short? ResourcePlanUtilizationType { get; set; }

        public DateTime? ResourcePlanUtilizationDate { get; set; }

        public int ProjectCreatedRevisionCounter { get; set; }

        public int ProjectModifiedRevisionCounter { get; set; }

        public DateTime ProjectCreatedDate { get; set; }

        public DateTime ProjectModifiedDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? ProjectCalendarDuration { get; set; }

        [StringLength(255)]
        public string ProjectCategoryName { get; set; }

        [StringLength(255)]
        public string ProjectCompanyName { get; set; }

        [StringLength(255)]
        public string ProjectKeywords { get; set; }

        [StringLength(255)]
        public string ProjectSubject { get; set; }

        [StringLength(255)]
        public string ProjectTitle { get; set; }

        [Column(TypeName = "ntext")]
        public string ProjectDescription { get; set; }

        public Guid? EnterpriseProjectTypeUID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmAssignment> MSP_EpmAssignment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmAssignmentBaseline> MSP_EpmAssignmentBaseline { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmAssignmentBaselineByDay> MSP_EpmAssignmentBaselineByDay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmAssignmentByDay> MSP_EpmAssignmentByDay { get; set; }

        public virtual MSP_EpmEnterpriseProjectType MSP_EpmEnterpriseProjectType { get; set; }

        public virtual MSP_EpmProjectCommit MSP_EpmProjectCommit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmTask> MSP_EpmTask { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmTaskByDay> MSP_EpmTaskByDay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmWorkflowStatusInformation> MSP_EpmWorkflowStatusInformation { get; set; }
    }
}
