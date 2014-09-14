namespace MaintenanceManagement.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ActualEndDate : DbMigration
    {
        public override void Up()
        {
            this.AddColumn("dbo.EmployeeTasks", "ActualEndDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            this.DropColumn("dbo.EmployeeTasks", "ActualEndDate");
        }
    }
}
