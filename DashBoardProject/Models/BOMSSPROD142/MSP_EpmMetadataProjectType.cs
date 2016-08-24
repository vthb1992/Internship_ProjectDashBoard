namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmMetadataProjectType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSP_EpmMetadataProjectType()
        {
            MSP_EpmMetadataAttribute = new HashSet<MSP_EpmMetadataAttribute>();
        }

        [Key]
        public byte AttributeProjType { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        public int LCID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmMetadataAttribute> MSP_EpmMetadataAttribute { get; set; }
    }
}
