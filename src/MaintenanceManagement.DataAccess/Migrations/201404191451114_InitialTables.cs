namespace MaintenanceManagement.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
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
            
            CreateTable(
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
            
            CreateTable(
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
            
            CreateTable(
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
            DropForeignKey("dbo.EmployeeTools", "ToolType_Id", "dbo.ToolTypes");
            DropForeignKey("dbo.EmployeeTools", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.EmployeeTasks", "Assignee_Id", "dbo.Employees");
            DropForeignKey("dbo.EmployeeTasks", "Area_Id", "dbo.Areas");
            DropIndex("dbo.EmployeeTools", new[] { "ToolType_Id" });
            DropIndex("dbo.EmployeeTools", new[] { "Employee_Id" });
            DropIndex("dbo.EmployeeTasks", new[] { "Assignee_Id" });
            DropIndex("dbo.EmployeeTasks", new[] { "Area_Id" });
            DropTable("dbo.ToolTypes");
            DropTable("dbo.EmployeeTools");
            DropTable("dbo.EmployeeTasks");
            DropTable("dbo.Employees");
            DropTable("dbo.Areas");
        }
    }
}
