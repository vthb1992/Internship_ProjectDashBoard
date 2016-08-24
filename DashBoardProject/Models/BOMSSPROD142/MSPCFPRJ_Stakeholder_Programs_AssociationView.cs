namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MSPCFPRJ_Stakeholder Programs_AssociationView")]
    public partial class MSPCFPRJ_Stakeholder_Programs_AssociationView
    {
        [Key]
        [Column(Order = 0)]
        public Guid EntityUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid LookupMemberUID { get; set; }
    }
}
