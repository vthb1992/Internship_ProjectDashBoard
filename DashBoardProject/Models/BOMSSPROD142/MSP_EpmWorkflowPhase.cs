namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmWorkflowPhase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSP_EpmWorkflowPhase()
        {
            MSP_EpmWorkflowStage = new HashSet<MSP_EpmWorkflowStage>();
        }

        [Key]
        public Guid PhaseUID { get; set; }

        [Required]
        [StringLength(255)]
        public string PhaseName { get; set; }

        [StringLength(1000)]
        public string PhaseDescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmWorkflowStage> MSP_EpmWorkflowStage { get; set; }
    }
}
