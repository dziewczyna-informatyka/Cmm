namespace MaintenanceManagement.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Indexes : DbMigration
    {
        public override void Up()
        {
            this.CreateIndex("dbo.Areas", "Name", unique: true);
            this.CreateIndex("dbo.Employees", "PersonalNumber", unique: true);
            this.CreateIndex("dbo.ToolTypes", "Name", unique: true);
        }
        
        public override void Down()
        {
            this.DropIndex("dbo.ToolTypes", new[] { "Name" });
            this.DropIndex("dbo.Employees", new[] { "PersonalNumber" });
            this.DropIndex("dbo.Areas", new[] { "Name" });
        }
    }
}
