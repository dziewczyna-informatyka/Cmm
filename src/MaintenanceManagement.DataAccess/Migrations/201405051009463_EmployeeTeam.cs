namespace MaintenanceManagement.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeTeam : DbMigration
    {
        public override void Up()
        {
            this.Sql("UPDATE dbo.Employees SET Team = 0");
            this.AlterColumn("dbo.Employees", "Team", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            this.AlterColumn("dbo.Employees", "Team", c => c.String());
        }
    }
}
