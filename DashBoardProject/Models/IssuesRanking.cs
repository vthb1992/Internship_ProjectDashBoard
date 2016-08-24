namespace DashBoardProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IssuesRanking
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string bscmProjectsID { get; set; }

        
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pacRank { get; set; }

        
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int overallRank { get; set; }
 
        [Column(Order = 3)]
        [StringLength(50)]
        public string ITHR { get; set; }
    }
}
