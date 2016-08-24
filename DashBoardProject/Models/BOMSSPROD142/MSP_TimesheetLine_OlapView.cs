namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_TimesheetLine_OlapView
    {
        [Key]
        [Column(Order = 0)]
        public Guid TimesheetLineUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid TimesheetUID { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid ProjectNameUID { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid TaskNameUID { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid AssignmentUID { get; set; }

        [Key]
        [Column(Order = 5)]
        public Guid ClassUID { get; set; }

        public byte? ValidationType { get; set; }

        [StringLength(255)]
        public string Comment { get; set; }

        public Guid? ApproverResourceNameUID { get; set; }

        public byte? TimesheetLineStatus { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public DateTime? CreatedDate { get; set; }

        public decimal? LastSavedWork { get; set; }

        [Key]
        [Column(Order = 6)]
        public string TaskHierarchy { get; set; }
    }
}
