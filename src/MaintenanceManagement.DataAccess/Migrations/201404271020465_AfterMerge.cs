namespace MaintenanceManagement.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AfterMerge : DbMigration
    {
        public override void Up()
        {
            this.RenameColumn(table: "dbo.EmployeeTools", name: "Employee_Id", newName: "Owner_Id");
            this.RenameIndex(table: "dbo.EmployeeTools", name: "IX_Employee_Id", newName: "IX_Owner_Id");
            this.AddColumn("dbo.Employees", "Team", c => c.String());
            this.AddColumn("dbo.Employees", "Area_Id", c => c.Int());
            this.AlterColumn("dbo.Employees", "PersonalNumber", c => c.Int());
            this.CreateIndex("dbo.Employees", "Area_Id");
            this.AddForeignKey("dbo.Employees", "Area_Id", "dbo.Areas", "Id");
        }
        
        public override void Down()
        {
            this.DropForeignKey("dbo.Employees", "Area_Id", "dbo.Areas");
            this.DropIndex("dbo.Employees", new[] { "Area_Id" });
            this.AlterColumn("dbo.Employees", "PersonalNumber", c => c.Int(nullable: false));
            this.DropColumn("dbo.Employees", "Area_Id");
            this.DropColumn("dbo.Employees", "Team");
            this.RenameIndex(table: "dbo.EmployeeTools", name: "IX_Owner_Id", newName: "IX_Employee_Id");
            this.RenameColumn(table: "dbo.EmployeeTools", name: "Owner_Id", newName: "Employee_Id");
        }
    }
}
