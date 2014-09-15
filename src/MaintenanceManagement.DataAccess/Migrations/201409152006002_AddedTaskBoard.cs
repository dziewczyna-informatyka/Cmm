namespace MaintenanceManagement.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTaskBoard : DbMigration
    {
        public override void Up()
        {
            this.CreateTable(
                "dbo.TaskBoards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            this.AddColumn("dbo.EmployeeTasks", "Board_Id", c => c.Int());
            this.AddColumn("dbo.Projects", "BoardA_Id", c => c.Int());
            this.AddColumn("dbo.Projects", "BoardB_Id", c => c.Int());
            this.AddColumn("dbo.Projects", "BoardC_Id", c => c.Int());
            this.CreateIndex("dbo.EmployeeTasks", "Board_Id");
            this.CreateIndex("dbo.Projects", "BoardA_Id");
            this.CreateIndex("dbo.Projects", "BoardB_Id");
            this.CreateIndex("dbo.Projects", "BoardC_Id");
            this.AddForeignKey("dbo.EmployeeTasks", "Board_Id", "dbo.TaskBoards", "Id");
            this.AddForeignKey("dbo.Projects", "BoardA_Id", "dbo.TaskBoards", "Id");
            this.AddForeignKey("dbo.Projects", "BoardB_Id", "dbo.TaskBoards", "Id");
            this.AddForeignKey("dbo.Projects", "BoardC_Id", "dbo.TaskBoards", "Id");
        }
        
        public override void Down()
        {
            this.DropForeignKey("dbo.Projects", "BoardC_Id", "dbo.TaskBoards");
            this.DropForeignKey("dbo.Projects", "BoardB_Id", "dbo.TaskBoards");
            this.DropForeignKey("dbo.Projects", "BoardA_Id", "dbo.TaskBoards");
            this.DropForeignKey("dbo.EmployeeTasks", "Board_Id", "dbo.TaskBoards");
            this.DropIndex("dbo.Projects", new[] { "BoardC_Id" });
            this.DropIndex("dbo.Projects", new[] { "BoardB_Id" });
            this.DropIndex("dbo.Projects", new[] { "BoardA_Id" });
            this.DropIndex("dbo.EmployeeTasks", new[] { "Board_Id" });
            this.DropColumn("dbo.Projects", "BoardC_Id");
            this.DropColumn("dbo.Projects", "BoardB_Id");
            this.DropColumn("dbo.Projects", "BoardA_Id");
            this.DropColumn("dbo.EmployeeTasks", "Board_Id");
            this.DropTable("dbo.TaskBoards");
        }
    }
}
