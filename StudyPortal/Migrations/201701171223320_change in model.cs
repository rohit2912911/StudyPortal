namespace StudyPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeinmodel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CCategories", "Cid", "dbo.C");
            DropIndex("dbo.CCategories", new[] { "Cid" });
            AddColumn("dbo.C", "category", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.C", "category");
            CreateIndex("dbo.CCategories", "Cid");
            AddForeignKey("dbo.CCategories", "Cid", "dbo.C", "CId", cascadeDelete: true);
        }
    }
}
