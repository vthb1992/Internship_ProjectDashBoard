namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmWorkflowStage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSP_EpmWorkflowStage()
        {
            MSP_EpmWorkflowStatusInformation = new HashSet<MSP_EpmWorkflowStatusInformation>();
        }

        [Key]
        public Guid StageUID { get; set; }

        public Guid PhaseUID { get; set; }

        [Required]
        [StringLength(255)]
        public string StageName { get; set; }

        [StringLength(1000)]
        public string StageDescription { get; set; }

        public virtual MSP_EpmWorkflowPhase MSP_EpmWorkflowPhase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmWorkflowStatusInformation> MSP_EpmWorkflowStatusInformation { get; set; }
    }
}
