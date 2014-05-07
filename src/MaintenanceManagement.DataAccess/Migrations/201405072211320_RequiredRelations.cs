namespace MaintenanceManagement.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredRelations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EmployeeTasks", "Assignee_Id", "dbo.Employees");
            DropIndex("dbo.EmployeeTasks", new[] { "Assignee_Id" });
            AlterColumn("dbo.EmployeeTasks", "Assignee_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.EmployeeTasks", "Assignee_Id");
            AddForeignKey("dbo.EmployeeTasks", "Assignee_Id", "dbo.Employees", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeTasks", "Assignee_Id", "dbo.Employees");
            DropIndex("dbo.EmployeeTasks", new[] { "Assignee_Id" });
            AlterColumn("dbo.EmployeeTasks", "Assignee_Id", c => c.Int());
            CreateIndex("dbo.EmployeeTasks", "Assignee_Id");
            AddForeignKey("dbo.EmployeeTasks", "Assignee_Id", "dbo.Employees", "Id");
        }
    }
}
