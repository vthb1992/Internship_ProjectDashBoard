namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_WssDeliverableToProjectLinks_UserView
    {
        [Key]
        [Column(Order = 0)]
        public Guid ProjectUID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeliverableID { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? FinishDate { get; set; }

        [StringLength(255)]
        public string CreateByResource { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(255)]
        public string ModifiedByResource { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool IsFolder { get; set; }

        [StringLength(1024)]
        public string ItemRelativeUrlPath { get; set; }

        public Guid? RelatedProjectUID { get; set; }

        public int? RelationshipTypeID { get; set; }
    }
}
