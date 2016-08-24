namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MSPCFASSN_Fab Generic_T_AssociationView")]
    public partial class MSPCFASSN_Fab_Generic_T_AssociationView
    {
        [Key]
        [Column(Order = 0)]
        public Guid EntityUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid LookupMemberUID { get; set; }
    }
}
