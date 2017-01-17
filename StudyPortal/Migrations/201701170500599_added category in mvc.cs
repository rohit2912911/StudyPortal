namespace StudyPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedcategoryinmvc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mvcs", "category", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mvcs", "category");
        }
    }
}
