namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblAccounts",
                c => new
                    {
                        accountID = c.Int(nullable: false, identity: true),
                        nameAccount = c.String(nullable: false),
                        password = c.String(nullable: false),
                        userID = c.Int(),
                    })
                .PrimaryKey(t => t.accountID)
                .ForeignKey("dbo.tblUsers", t => t.userID)
                .Index(t => t.userID);
            
            CreateTable(
                "dbo.tblUsers",
                c => new
                    {
                        userID = c.Int(nullable: false, identity: true),
                        userName = c.String(nullable: false),
                        email = c.String(nullable: false),
                        phone = c.String(nullable: false),
                        role = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.userID);
            
            CreateTable(
                "dbo.tblImages",
                c => new
                    {
                        idImage = c.Int(nullable: false, identity: true),
                        nameImage = c.String(),
                    })
                .PrimaryKey(t => t.idImage);
            
            CreateTable(
                "dbo.tblLevels",
                c => new
                    {
                        levelID = c.Int(nullable: false, identity: true),
                        levelName = c.String(),
                    })
                .PrimaryKey(t => t.levelID);
            
            CreateTable(
                "dbo.tblScores",
                c => new
                    {
                        idScore = c.Int(nullable: false, identity: true),
                        userID = c.Int(nullable: false),
                        score = c.Int(nullable: false),
                        levelIdLose = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idScore)
                .ForeignKey("dbo.tblUsers", t => t.userID, cascadeDelete: true)
                .Index(t => t.userID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblScores", "userID", "dbo.tblUsers");
            DropForeignKey("dbo.tblAccounts", "userID", "dbo.tblUsers");
            DropIndex("dbo.tblScores", new[] { "userID" });
            DropIndex("dbo.tblAccounts", new[] { "userID" });
            DropTable("dbo.tblScores");
            DropTable("dbo.tblLevels");
            DropTable("dbo.tblImages");
            DropTable("dbo.tblUsers");
            DropTable("dbo.tblAccounts");
        }
    }
}
