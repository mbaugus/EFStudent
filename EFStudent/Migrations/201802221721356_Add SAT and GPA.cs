namespace EFStudent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSATandGPA : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "SAT", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "GPA", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "GPA");
            DropColumn("dbo.Students", "SAT");
        }
    }
}
