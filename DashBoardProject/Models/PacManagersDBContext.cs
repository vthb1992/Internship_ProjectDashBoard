namespace DashBoardProject.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PacManagersDBContext : DbContext
    {
        public PacManagersDBContext()
            : base("name=PacManagersDBContext")
        {
            Database.SetInitializer<PacManagersDBContext>(null);
        }

        public virtual DbSet<PacProjectStatu> PacProjectStatus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
