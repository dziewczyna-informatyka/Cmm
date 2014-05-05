namespace MaintenanceManagement.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Indexes : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Areas", "Name", unique: true);
            CreateIndex("dbo.Employees", "PersonalNumber", unique: true);
            CreateIndex("dbo.ToolTypes", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.ToolTypes", new[] { "Name" });
            DropIndex("dbo.Employees", new[] { "PersonalNumber" });
            DropIndex("dbo.Areas", new[] { "Name" });
        }
    }
}
