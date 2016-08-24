namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmAssignmentBooking_OlapView
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LCID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AssignmentBookingID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string AssignmentBookingName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1000)]
        public string AssignmentBookingDescription { get; set; }
    }
}
