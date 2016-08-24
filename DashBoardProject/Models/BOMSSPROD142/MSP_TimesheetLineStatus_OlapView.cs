namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_TimesheetLineStatus_OlapView
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LCID { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte TimesheetLineStatusID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1000)]
        public string Description { get; set; }
    }
}
