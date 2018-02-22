namespace EFStudent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TestName = c.String(nullable: false, maxLength: 50),
                        Score = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StudentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tests", "StudentID", "dbo.Students");
            DropIndex("dbo.Tests", new[] { "StudentID" });
            DropTable("dbo.Tests");
        }
    }
}
