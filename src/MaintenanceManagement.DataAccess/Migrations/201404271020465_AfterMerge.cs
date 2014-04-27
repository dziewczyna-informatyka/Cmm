namespace MaintenanceManagement.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AfterMerge : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.EmployeeTools", name: "Employee_Id", newName: "Owner_Id");
            RenameIndex(table: "dbo.EmployeeTools", name: "IX_Employee_Id", newName: "IX_Owner_Id");
            AddColumn("dbo.Employees", "Team", c => c.String());
            AddColumn("dbo.Employees", "Area_Id", c => c.Int());
            AlterColumn("dbo.Employees", "PersonalNumber", c => c.Int());
            CreateIndex("dbo.Employees", "Area_Id");
            AddForeignKey("dbo.Employees", "Area_Id", "dbo.Areas", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Area_Id", "dbo.Areas");
            DropIndex("dbo.Employees", new[] { "Area_Id" });
            AlterColumn("dbo.Employees", "PersonalNumber", c => c.Int(nullable: false));
            DropColumn("dbo.Employees", "Area_Id");
            DropColumn("dbo.Employees", "Team");
            RenameIndex(table: "dbo.EmployeeTools", name: "IX_Owner_Id", newName: "IX_Employee_Id");
            RenameColumn(table: "dbo.EmployeeTools", name: "Owner_Id", newName: "Employee_Id");
        }
    }
}
