namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmAssignmentBooking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSP_EpmAssignmentBooking()
        {
            MSP_EpmAssignment = new HashSet<MSP_EpmAssignment>();
        }

        public int LCID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AssignmentBookingID { get; set; }

        [Required]
        [StringLength(255)]
        public string AssignmentBookingName { get; set; }

        [Required]
        [StringLength(1000)]
        public string AssignmentBookingDescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmAssignment> MSP_EpmAssignment { get; set; }
    }
}
