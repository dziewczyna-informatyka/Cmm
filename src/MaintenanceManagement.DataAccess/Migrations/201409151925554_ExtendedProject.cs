namespace MaintenanceManagement.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExtendedProject : DbMigration
    {
        public override void Up()
        {
           this.AddColumn("dbo.Projects", "ProjectNumber", c => c.String(maxLength: 50, nullable: true));
           this.Sql("UPDATE dbo.Projects set ProjectNumber = CAST(Id as NVARCHAR(10))");
           this.AlterColumn("dbo.Projects", "ProjectNumber", c => c.String(maxLength: 50, nullable: false));
          
           this.AddColumn("dbo.Projects", "Area_Id", c => c.Int());
           this.AddColumn("dbo.Projects", "Owner_Id", c => c.Int());
           this.CreateIndex("dbo.Projects", "ProjectNumber", unique: true);
           this.CreateIndex("dbo.Projects", "Area_Id");
           this.CreateIndex("dbo.Projects", "Owner_Id");
           this.AddForeignKey("dbo.Projects", "Area_Id", "dbo.Areas", "Id");
           this.AddForeignKey("dbo.Projects", "Owner_Id", "dbo.Employees", "Id");
        }
        
        public override void Down()
        {
            this.DropForeignKey("dbo.Projects", "Owner_Id", "dbo.Employees");
            this.DropForeignKey("dbo.Projects", "Area_Id", "dbo.Areas");
            this.DropIndex("dbo.Projects", new[] { "Owner_Id" });
            this.DropIndex("dbo.Projects", new[] { "Area_Id" });
            this.DropIndex("dbo.Projects", new[] { "ProjectNumber" });
            this.DropColumn("dbo.Projects", "Owner_Id");
            this.DropColumn("dbo.Projects", "Area_Id");
            this.DropColumn("dbo.Projects", "ProjectNumber");
        }
    }
}
