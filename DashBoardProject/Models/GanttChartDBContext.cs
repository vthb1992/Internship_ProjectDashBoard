namespace DashBoardProject.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GanttChartDBContext : DbContext
    {
        public GanttChartDBContext()
            : base("name=GanttChartDBContext")
        {
            Database.SetInitializer<GanttChartDBContext>(null);
        }

        public virtual DbSet<AuxITGanttChart_Items> AuxITGanttChart_Items { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
