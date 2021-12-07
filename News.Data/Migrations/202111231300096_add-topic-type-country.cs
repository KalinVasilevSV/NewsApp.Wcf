namespace News.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtopictypecountry : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PhotoTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ArticleTopics",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Articles", "ArticleTopicID", c => c.Int(nullable: false));
            AddColumn("dbo.NewsAgencies", "CountryID", c => c.Int(nullable: false));
            AddColumn("dbo.Photos", "PhotoTypeID", c => c.Int(nullable: false));
            CreateIndex("dbo.Articles", "ArticleTopicID");
            CreateIndex("dbo.NewsAgencies", "CountryID");
            CreateIndex("dbo.Photos", "PhotoTypeID");
            AddForeignKey("dbo.NewsAgencies", "CountryID", "dbo.Countries", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Photos", "PhotoTypeID", "dbo.PhotoTypes", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Articles", "ArticleTopicID", "dbo.ArticleTopics", "ID", cascadeDelete: true);
            DropColumn("dbo.Articles", "Topic");
            DropColumn("dbo.NewsAgencies", "Country");
            DropColumn("dbo.Photos", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Photos", "Type", c => c.String());
            AddColumn("dbo.NewsAgencies", "Country", c => c.String(nullable: false, maxLength: 40));
            AddColumn("dbo.Articles", "Topic", c => c.String());
            DropForeignKey("dbo.Articles", "ArticleTopicID", "dbo.ArticleTopics");
            DropForeignKey("dbo.Photos", "PhotoTypeID", "dbo.PhotoTypes");
            DropForeignKey("dbo.NewsAgencies", "CountryID", "dbo.Countries");
            DropIndex("dbo.Photos", new[] { "PhotoTypeID" });
            DropIndex("dbo.NewsAgencies", new[] { "CountryID" });
            DropIndex("dbo.Articles", new[] { "ArticleTopicID" });
            DropColumn("dbo.Photos", "PhotoTypeID");
            DropColumn("dbo.NewsAgencies", "CountryID");
            DropColumn("dbo.Articles", "ArticleTopicID");
            DropTable("dbo.ArticleTopics");
            DropTable("dbo.PhotoTypes");
            DropTable("dbo.Countries");
        }
    }
}
