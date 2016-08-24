namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MSPLT_PLM Factory Network_UserView")]
    public partial class MSPLT_PLM_Factory_Network_UserView
    {
        [Key]
        public Guid LookupMemberUID { get; set; }

        public Guid? ParentLookupMemberUID { get; set; }

        [StringLength(255)]
        public string MemberValue { get; set; }

        [Column(TypeName = "ntext")]
        public string MemberFullValue { get; set; }

        [StringLength(1000)]
        public string MemberDescription { get; set; }
    }
}
