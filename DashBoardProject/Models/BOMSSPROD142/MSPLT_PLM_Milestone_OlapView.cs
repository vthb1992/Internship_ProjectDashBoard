namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MSPLT_PLM Milestone_OlapView")]
    public partial class MSPLT_PLM_Milestone_OlapView
    {
        [Key]
        public Guid LookupMemberUID { get; set; }

        [StringLength(255)]
        public string MemberValue { get; set; }

        [StringLength(1000)]
        public string MemberDescription { get; set; }
    }
}