namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmLookupTable
    {
        [Key]
        [Column(Order = 0)]
        public Guid LookupTableUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid MemberUID { get; set; }

        [Column(TypeName = "ntext")]
        public string MemberFullValue { get; set; }

        public Guid? ParentMemberUID { get; set; }

        [StringLength(1000)]
        public string MemberDescription { get; set; }

        public int? LCID { get; set; }

        public virtual MSP_EpmMetadataDimension MSP_EpmMetadataDimension { get; set; }
    }
}
