namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmEnterpriseProjectType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSP_EpmEnterpriseProjectType()
        {
            MSP_EpmProject = new HashSet<MSP_EpmProject>();
        }

        [Key]
        public Guid EnterpriseProjectTypeUID { get; set; }

        [Required]
        [StringLength(255)]
        public string EnterpriseProjectTypeName { get; set; }

        public bool IsDefault { get; set; }

        [StringLength(1000)]
        public string EnterpriseProjectTypeDescription { get; set; }

        [StringLength(1000)]
        public string EnterpriseProjectTypeImageUrl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmProject> MSP_EpmProject { get; set; }
    }
}
