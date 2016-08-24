namespace DashBoardProject.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PrioritizationDBContext : DbContext
    {
        public PrioritizationDBContext()
            : base("name=PrioritizationDBContext")
        {
            Database.SetInitializer<PrioritizationDBContext>(null);
        }

        public virtual DbSet<IssuesModel> IssuesModels { get; set; }
        public virtual DbSet<IssuesRanking> IssuesRankings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IssuesModel>()
                .Property(e => e.issueList)
                .IsFixedLength();

            modelBuilder.Entity<IssuesModel>()
                .Property(e => e.BscmProject)
                .IsFixedLength();

            modelBuilder.Entity<IssuesModel>()
                .Property(e => e.issueID)
                .IsFixedLength();

            modelBuilder.Entity<IssuesModel>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<IssuesModel>()
                .Property(e => e.PAC)
                .IsFixedLength();

            modelBuilder.Entity<IssuesModel>()
                .Property(e => e.ITHR)
                .IsFixedLength();

            modelBuilder.Entity<IssuesModel>()
                .Property(e => e.benefit)
                .IsFixedLength();

            modelBuilder.Entity<IssuesModel>()
                .Property(e => e.creator)
                .IsFixedLength();

        }
    }
}
