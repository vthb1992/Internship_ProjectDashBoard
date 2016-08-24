namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmFlagLookupTable_OlapView
    {
        public bool? FlagID { get; set; }

        [Key]
        [StringLength(5)]
        public string FlagValue { get; set; }
    }
}
