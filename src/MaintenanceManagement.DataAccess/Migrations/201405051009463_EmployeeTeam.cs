namespace MaintenanceManagement.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeTeam : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.Employees SET Team = 0");
            AlterColumn("dbo.Employees", "Team", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Team", c => c.String());
        }
    }
}
