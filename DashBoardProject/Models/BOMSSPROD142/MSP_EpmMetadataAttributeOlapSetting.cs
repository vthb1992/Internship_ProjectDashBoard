namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmMetadataAttributeOlapSetting
    {
        [Key]
        [Column(Order = 0)]
        public Guid AttributeTypeUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid OlapDatabaseUID { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid OlapEntityOwner { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte OlapRole { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModificationDate { get; set; }
    }
}
