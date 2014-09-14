namespace MaintenanceManagement.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class InitialTables : DbMigration
    {
        public override void Up()
        {
            this.CreateTable(
                "dbo.Areas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            this.CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonalNumber = c.Int(nullable: false),
                        Name = c.String(),
                        Surname = c.String(),
                        EmploymentStart = c.DateTime(nullable: false),
                        Address = c.String(),
                        MobilePhone = c.String(),
                        HomePhone = c.String(),
                        JobTitle = c.Int(nullable: false),
                        EmploymentType = c.Int(nullable: false),
                        Login = c.String(),
                        PasswordHash = c.String(),
                        WorkSchedule = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

            this.CreateTable(
                "dbo.EmployeeTasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Subject = c.String(),
                        Actions = c.String(),
                        Status = c.Int(nullable: false),
                        DueDate = c.DateTime(nullable: false),
                        Progress = c.Double(nullable: false),
                        Area_Id = c.Int(),
                        Assignee_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Areas", t => t.Area_Id)
                .ForeignKey("dbo.Employees", t => t.Assignee_Id)
                .Index(t => t.Area_Id)
                .Index(t => t.Assignee_Id);

            this.CreateTable(
                "dbo.EmployeeTools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(),
                        Quantity = c.Int(nullable: false),
                        Comment = c.String(),
                        ToolEndReason = c.Int(),
                        Employee_Id = c.Int(),
                        ToolType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .ForeignKey("dbo.ToolTypes", t => t.ToolType_Id)
                .Index(t => t.Employee_Id)
                .Index(t => t.ToolType_Id);

            this.CreateTable(
                "dbo.ToolTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);            
        }
        
        public override void Down()
        {
            this.DropForeignKey("dbo.EmployeeTools", "ToolType_Id", "dbo.ToolTypes");
            this.DropForeignKey("dbo.EmployeeTools", "Employee_Id", "dbo.Employees");
            this.DropForeignKey("dbo.EmployeeTasks", "Assignee_Id", "dbo.Employees");
            this.DropForeignKey("dbo.EmployeeTasks", "Area_Id", "dbo.Areas");
            this.DropIndex("dbo.EmployeeTools", new[] { "ToolType_Id" });
            this.DropIndex("dbo.EmployeeTools", new[] { "Employee_Id" });
            this.DropIndex("dbo.EmployeeTasks", new[] { "Assignee_Id" });
            this.DropIndex("dbo.EmployeeTasks", new[] { "Area_Id" });
            this.DropTable("dbo.ToolTypes");
            this.DropTable("dbo.EmployeeTools");
            this.DropTable("dbo.EmployeeTasks");
            this.DropTable("dbo.Employees");
            this.DropTable("dbo.Areas");
        }
    }
}
