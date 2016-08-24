namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmCustomFieldAssociation
    {
        [Key]
        [Column(Order = 0)]
        public Guid EntityTypeUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid EntityUID { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid CustomFieldTypeUID { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid CustomFieldValueUID { get; set; }

        public Guid LookupMemberUID { get; set; }

        public Guid LookupTableUID { get; set; }

        public int? Weight { get; set; }

        public virtual MSP_EpmMetadataAttribute MSP_EpmMetadataAttribute { get; set; }

        public virtual MSP_EpmMetadataDimension MSP_EpmMetadataDimension { get; set; }
    }
}
