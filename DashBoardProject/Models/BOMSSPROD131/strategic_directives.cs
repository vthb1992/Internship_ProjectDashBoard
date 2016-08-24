namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAMS.strategic_directives")]
    public partial class strategic_directives
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public strategic_directives()
        {
            departments = new HashSet<department>();
        }

        [Key]
        public int directive_id { get; set; }

        [Required]
        [StringLength(255)]
        public string directive { get; set; }

        [Column(TypeName = "ntext")]
        public string description { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ins_datetime { get; set; }

        public int ins_worker { get; set; }

        [Required]
        [StringLength(1)]
        public string active_flag { get; set; }

        public int? sponsor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<department> departments { get; set; }
    }
}
