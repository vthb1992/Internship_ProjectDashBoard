namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MSPLT_Worker Role_UserView")]
    public partial class MSPLT_Worker_Role_UserView
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
