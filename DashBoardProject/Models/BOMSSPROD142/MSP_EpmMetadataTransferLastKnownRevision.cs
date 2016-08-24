namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmMetadataTransferLastKnownRevision
    {
        [Key]
        [Column(Order = 0)]
        public byte TransferType { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ElementUID { get; set; }

        public int LastKnownRevisionRank { get; set; }

        public int LastKnownRevisionCounter { get; set; }

        public DateTime LastTransferDate { get; set; }
    }
}
