namespace MaintenanceManagement.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StringLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Areas", "Name", c => c.String(maxLength: 50));
            AlterColumn("dbo.ToolTypes", "Name", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
           AlterColumn("dbo.Areas", "Name", c => c.String());
           AlterColumn("dbo.ToolTypes", "Name", c => c.String());
        }
    }
}
