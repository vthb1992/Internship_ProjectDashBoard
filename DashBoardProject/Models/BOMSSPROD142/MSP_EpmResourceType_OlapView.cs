namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmResourceType_OlapView
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ResourceType { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string TypeName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1000)]
        public string TypeDescription { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LCID { get; set; }
    }
}
