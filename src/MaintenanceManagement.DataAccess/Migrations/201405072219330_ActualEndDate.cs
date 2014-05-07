namespace MaintenanceManagement.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActualEndDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeTasks", "ActualEndDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmployeeTasks", "ActualEndDate");
        }
    }
}
