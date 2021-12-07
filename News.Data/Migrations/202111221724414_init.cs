namespace News.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 60),
                        SubTitle = c.String(),
                        Topic = c.String(),
                        PublicationDate = c.DateTime(nullable: false),
                        Abstract = c.String(nullable: false, maxLength: 2000),
                        Content = c.String(nullable: false),
                        AuthorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Authors", t => t.AuthorID, cascadeDelete: true)
                .Index(t => t.AuthorID);
            
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 20),
                        Tel = c.String(),
                        RegisteredOn = c.DateTime(nullable: false),
                        Bio = c.String(),
                        NewsAgencyID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.NewsAgencies", t => t.NewsAgencyID)
                .Index(t => t.NewsAgencyID);
            
            CreateTable(
                "dbo.NewsAgencies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        Address = c.String(nullable: false, maxLength: 100),
                        Country = c.String(nullable: false, maxLength: 40),
                        Email = c.String(nullable: false, maxLength: 40),
                        Tel = c.String(),
                        Description = c.String(nullable: false, maxLength: 2000),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Photos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 60),
                        Location = c.String(),
                        TakenOn = c.DateTime(nullable: false),
                        Type = c.String(),
                        PublicationDate = c.DateTime(nullable: false),
                        Description = c.String(nullable: false, maxLength: 1000),
                        Data = c.Binary(nullable: false),
                        AuthorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Authors", t => t.AuthorID, cascadeDelete: true)
                .Index(t => t.AuthorID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Photos", "AuthorID", "dbo.Authors");
            DropForeignKey("dbo.Authors", "NewsAgencyID", "dbo.NewsAgencies");
            DropForeignKey("dbo.Articles", "AuthorID", "dbo.Authors");
            DropIndex("dbo.Photos", new[] { "AuthorID" });
            DropIndex("dbo.Authors", new[] { "NewsAgencyID" });
            DropIndex("dbo.Articles", new[] { "AuthorID" });
            DropTable("dbo.Photos");
            DropTable("dbo.NewsAgencies");
            DropTable("dbo.Authors");
            DropTable("dbo.Articles");
        }
    }
}
