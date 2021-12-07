namespace News.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class expandemailfield : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Authors", "Email", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.NewsAgencies", "Email", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NewsAgencies", "Email", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Authors", "Email", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
