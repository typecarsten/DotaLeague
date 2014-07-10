namespace DotaLeague.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.League",
                c => new
                    {
                        LeagueID = c.Int(nullable: false, identity: true),
                        LeagueName = c.String(),
                        Description = c.String(),
                        NumberOfTeams = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LeagueID);
            
            CreateTable(
                "dbo.Team",
                c => new
                    {
                        TeamID = c.Int(nullable: false, identity: true),
                        TeamName = c.String(),
                        TeamTag = c.String(),
                        RegistrationDateTime = c.DateTime(nullable: false),
                        Approved = c.Boolean(nullable: false),
                        League_LeagueID = c.Int(),
                    })
                .PrimaryKey(t => t.TeamID)
                .ForeignKey("dbo.League", t => t.League_LeagueID)
                .Index(t => t.League_LeagueID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        NickName = c.String(),
                        Team_TeamID = c.Int(),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Team", t => t.Team_TeamID)
                .Index(t => t.Team_TeamID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "Team_TeamID", "dbo.Team");
            DropForeignKey("dbo.Team", "League_LeagueID", "dbo.League");
            DropIndex("dbo.User", new[] { "Team_TeamID" });
            DropIndex("dbo.Team", new[] { "League_LeagueID" });
            DropTable("dbo.User");
            DropTable("dbo.Team");
            DropTable("dbo.League");
        }
    }
}
