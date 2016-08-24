namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmMetadataEntities
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSP_EpmMetadataEntities()
        {
            MSP_EpmMetadataAttribute = new HashSet<MSP_EpmMetadataAttribute>();
        }

        [Key]
        public Guid EntityTypeUID { get; set; }

        [StringLength(255)]
        public string EntityName { get; set; }

        public bool EntityIsIntrinsic { get; set; }

        [Required]
        [StringLength(255)]
        public string EntityNonTimephasedTableName { get; set; }

        [Required]
        [StringLength(255)]
        public string PrimaryColumnName { get; set; }

        [StringLength(255)]
        public string EntityTimephasedTableName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmMetadataAttribute> MSP_EpmMetadataAttribute { get; set; }
    }
}
