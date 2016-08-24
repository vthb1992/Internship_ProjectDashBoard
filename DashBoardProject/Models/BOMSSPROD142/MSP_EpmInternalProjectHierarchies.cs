namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmInternalProjectHierarchies
    {
        [Key]
        public Guid ProjectHierarchyUID { get; set; }

        public Guid ParentProjectUID { get; set; }

        public Guid ChildProjectUID { get; set; }
    }
}
