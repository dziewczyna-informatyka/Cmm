namespace MaintenanceManagement.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class RequiredRelations : DbMigration
    {
        public override void Up()
        {
            this.DropForeignKey("dbo.EmployeeTasks", "Assignee_Id", "dbo.Employees");
            this.DropIndex("dbo.EmployeeTasks", new[] { "Assignee_Id" });
            this.AlterColumn("dbo.EmployeeTasks", "Assignee_Id", c => c.Int(nullable: false));
            this.CreateIndex("dbo.EmployeeTasks", "Assignee_Id");
            this.AddForeignKey("dbo.EmployeeTasks", "Assignee_Id", "dbo.Employees", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            this.DropForeignKey("dbo.EmployeeTasks", "Assignee_Id", "dbo.Employees");
            this.DropIndex("dbo.EmployeeTasks", new[] { "Assignee_Id" });
            this.AlterColumn("dbo.EmployeeTasks", "Assignee_Id", c => c.Int());
            this.CreateIndex("dbo.EmployeeTasks", "Assignee_Id");
            this.AddForeignKey("dbo.EmployeeTasks", "Assignee_Id", "dbo.Employees", "Id");
        }
    }
}
