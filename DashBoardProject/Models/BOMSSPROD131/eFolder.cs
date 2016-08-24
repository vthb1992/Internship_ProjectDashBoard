namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("eFolder")]
    public partial class eFolder
    {
        [StringLength(31)]
        public string eFolderID { get; set; }

        [StringLength(31)]
        public string eParent { get; set; }

        [StringLength(31)]
        public string eFolderName { get; set; }

        [StringLength(31)]
        public string eStageName { get; set; }

        [StringLength(31)]
        public string eMapName { get; set; }

        [StringLength(31)]
        public string eServerName { get; set; }

        [StringLength(31)]
        public string eCategory { get; set; }

        [StringLength(100)]
        public string eOriginator { get; set; }

        [StringLength(250)]
        public string eSubject { get; set; }

        public short? eArchived { get; set; }

        public short? ePriority { get; set; }

        public int? eActionCount { get; set; }

        public DateTime? eCreationTime { get; set; }

        public DateTime? eEntryTime { get; set; }

        public DateTime? eUpdated { get; set; }

        public DateTime? eDeadline { get; set; }

        public DateTime? eActionTime { get; set; }

        [StringLength(31)]
        public string eActionName { get; set; }

        [StringLength(100)]
        public string eActionUser { get; set; }

        [Column(TypeName = "ntext")]
        public string eFragmentStack { get; set; }

        public short? eIsException { get; set; }

        [Column(TypeName = "money")]
        public decimal? eTotalCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? eTotalRevenue { get; set; }

        public int? eTotalWorkTimeMinutes { get; set; }
    }
}
