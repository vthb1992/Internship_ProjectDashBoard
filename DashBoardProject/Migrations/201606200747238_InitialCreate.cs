namespace DashBoardProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IssuesRankings",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        pacRank = c.Int(nullable: false),
                        overallRank = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.IssuesRankings");
        }
    }
}
