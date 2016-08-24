namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_WssListItemAssociation
    {
        [Key]
        [Column(Order = 0)]
        public Guid ProjectUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ListItemUID { get; set; }

        public Guid RelatedProjectUID { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid RelatedItemUID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RelationshipTypeID { get; set; }

        public virtual MSP_WssRelationshipType MSP_WssRelationshipType { get; set; }
    }
}
