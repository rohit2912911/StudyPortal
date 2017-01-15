namespace StudyPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedanswerinmvc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mvcs", "Answer", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mvcs", "Answer");
        }
    }
}
