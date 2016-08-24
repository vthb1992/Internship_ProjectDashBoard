namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmMetadataDimension
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSP_EpmMetadataDimension()
        {
            MSP_EpmCustomFieldAssociation = new HashSet<MSP_EpmCustomFieldAssociation>();
            MSP_EpmLookupTable = new HashSet<MSP_EpmLookupTable>();
        }

        [Key]
        public Guid DimensionUID { get; set; }

        [Required]
        [StringLength(255)]
        public string DimensionName { get; set; }

        [Required]
        [StringLength(255)]
        public string DimensionTableName { get; set; }

        public bool DimensionIsIntrinsic { get; set; }

        public bool HasNoHierarchy { get; set; }

        public byte MemberType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmCustomFieldAssociation> MSP_EpmCustomFieldAssociation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmLookupTable> MSP_EpmLookupTable { get; set; }
    }
}
