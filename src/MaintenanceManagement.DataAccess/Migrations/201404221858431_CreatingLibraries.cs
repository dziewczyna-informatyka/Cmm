namespace MaintenanceManagement.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class CreatingLibraries : DbMigration
    {
        public override void Up()
        {
            this.AlterColumn("dbo.Employees", "PersonalNumber", c => c.Int());
            this.AlterColumn("dbo.Employees", "EmploymentStart", c => c.DateTime());
            this.AlterColumn("dbo.Employees", "JobTitle", c => c.Int());
            this.AlterColumn("dbo.Employees", "EmploymentType", c => c.Int());
            this.AlterColumn("dbo.Employees", "WorkSchedule", c => c.Int());
        }
        
        public override void Down()
        {
            this.AlterColumn("dbo.Employees", "WorkSchedule", c => c.Int(nullable: false));
            this.AlterColumn("dbo.Employees", "EmploymentType", c => c.Int(nullable: false));
            this.AlterColumn("dbo.Employees", "JobTitle", c => c.Int(nullable: false));
            this.AlterColumn("dbo.Employees", "EmploymentStart", c => c.DateTime(nullable: false));
            this.AlterColumn("dbo.Employees", "PersonalNumber", c => c.Int(nullable: false));
        }
    }
}
