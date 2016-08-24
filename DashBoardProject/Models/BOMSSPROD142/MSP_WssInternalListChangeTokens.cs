namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_WssInternalListChangeTokens
    {
        [Key]
        [Column(Order = 0)]
        public Guid ProjectUID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WssListType { get; set; }

        public Guid SPListUID { get; set; }

        [Required]
        [StringLength(1024)]
        public string ChangeToken { get; set; }

        public DateTime LastSyncDate { get; set; }

        public int LastSyncItemsCount { get; set; }

        public bool LastSyncWasIncremental { get; set; }

        public long TotalItemsCount { get; set; }

        public int IncrementalSyncCount { get; set; }

        public int FullSyncCount { get; set; }

        public int? LastSyncElapsedTime { get; set; }

        public int AverageSyncTime { get; set; }
    }
}
