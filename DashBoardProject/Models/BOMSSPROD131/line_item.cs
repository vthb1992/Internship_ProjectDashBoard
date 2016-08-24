namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAMS.line_item")]
    public partial class line_item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public line_item()
        {
            folder_line_item = new HashSet<folder_line_item>();
        }

        public int id { get; set; }

        public int? sequence { get; set; }

        [Required]
        [StringLength(200)]
        public string description { get; set; }

        [Required]
        [StringLength(20)]
        public string unit { get; set; }

        [StringLength(50)]
        public string itemType { get; set; }

        [Required]
        [StringLength(1)]
        public string active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<folder_line_item> folder_line_item { get; set; }

        public virtual line_item_unit line_item_unit { get; set; }
    }
}
