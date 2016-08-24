namespace DashBoardProject.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WorkWeekDBContext : DbContext
    {
        public WorkWeekDBContext()
            : base("name=WorkWeekDBContext")
        {
        }

        public virtual DbSet<mfg_year_month_ww> mfg_year_month_ww { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<mfg_year_month_ww>()
                .Property(e => e.mfg_year_month_ww_OID)
                .IsFixedLength();
        }
    }
}
