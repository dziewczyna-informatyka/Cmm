namespace MaintenanceManagement.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AdminRole : DbMigration
    {
        public override void Up()
        {
            this.AddColumn("dbo.Employees", "IsAdmin", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            this.DropColumn("dbo.Employees", "IsAdmin");
        }
    }
}
