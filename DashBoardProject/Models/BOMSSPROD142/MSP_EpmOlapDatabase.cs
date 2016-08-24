namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmOlapDatabase
    {
        [Key]
        public Guid OlapDatabaseUID { get; set; }

        public bool IsInactiveTasksEnabled { get; set; }

        public DateTime MOD_DATE { get; set; }

        public DateTime CREATED_DATE { get; set; }
    }
}
