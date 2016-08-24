namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmResourceStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSP_EpmResourceStatus()
        {
            MSP_EpmResource = new HashSet<MSP_EpmResource>();
        }

        [Key]
        public Guid ResourceStatusUID { get; set; }

        [Required]
        [StringLength(255)]
        public string ResourceStatusName { get; set; }

        public int LCID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmResource> MSP_EpmResource { get; set; }
    }
}
