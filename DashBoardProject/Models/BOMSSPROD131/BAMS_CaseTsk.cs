namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BAMS_CaseTsk
    {
        [Key]
        [StringLength(31)]
        public string EFOLDERID { get; set; }

        [StringLength(250)]
        public string taskType { get; set; }

        [StringLength(250)]
        public string pAssigned { get; set; }

        [StringLength(5)]
        public string completionMode { get; set; }
    }
}
