namespace StudyPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedcclass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.C",
                c => new
                    {
                        CId = c.Int(nullable: false, identity: true),
                        Question = c.String(),
                        OptionA = c.String(),
                        OptionB = c.String(),
                        OptionC = c.String(),
                        OptionD = c.String(),
                        Answer = c.String(),
                    })
                .PrimaryKey(t => t.CId);
            
            CreateTable(
                "dbo.CCategories",
                c => new
                    {
                        CCategoryid = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        Cid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CCategoryid)
                .ForeignKey("dbo.C", t => t.Cid, cascadeDelete: true)
                .Index(t => t.Cid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CCategories", "Cid", "dbo.C");
            DropIndex("dbo.CCategories", new[] { "Cid" });
            DropTable("dbo.CCategories");
            DropTable("dbo.C");
        }
    }
}
