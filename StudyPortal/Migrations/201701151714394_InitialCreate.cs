namespace StudyPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mvcs",
                c => new
                    {
                        MvcId = c.Int(nullable: false, identity: true),
                        Question = c.String(),
                        OptionA = c.String(),
                        OptionB = c.String(),
                        OptionC = c.String(),
                        OptionD = c.String(),
                    })
                .PrimaryKey(t => t.MvcId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Mvcs");
        }
    }
}
