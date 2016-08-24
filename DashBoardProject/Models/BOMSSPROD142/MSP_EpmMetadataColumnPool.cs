namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmMetadataColumnPool
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSP_EpmMetadataColumnPool()
        {
            MSP_EpmMetadataAttribute = new HashSet<MSP_EpmMetadataAttribute>();
            MSP_EpmMetadataAttribute1 = new HashSet<MSP_EpmMetadataAttribute>();
        }

        [Key]
        public int ColumnID { get; set; }

        [Required]
        [StringLength(32)]
        public string TableName { get; set; }

        [Required]
        [StringLength(32)]
        public string ColumnNameForCFValue { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmMetadataAttribute> MSP_EpmMetadataAttribute { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmMetadataAttribute> MSP_EpmMetadataAttribute1 { get; set; }
    }
}
