namespace MaintenanceManagement.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatingLibraries : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "PersonalNumber", c => c.Int());
            AlterColumn("dbo.Employees", "EmploymentStart", c => c.DateTime());
            AlterColumn("dbo.Employees", "JobTitle", c => c.Int());
            AlterColumn("dbo.Employees", "EmploymentType", c => c.Int());
            AlterColumn("dbo.Employees", "WorkSchedule", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "WorkSchedule", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "EmploymentType", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "JobTitle", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "EmploymentStart", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Employees", "PersonalNumber", c => c.Int(nullable: false));
        }
    }
}
