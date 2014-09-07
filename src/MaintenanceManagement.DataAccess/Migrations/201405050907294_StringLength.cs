namespace MaintenanceManagement.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class StringLength : DbMigration
    {
        public override void Up()
        {
            this.AlterColumn("dbo.Areas", "Name", c => c.String(maxLength: 50));
            this.AlterColumn("dbo.ToolTypes", "Name", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            this.AlterColumn("dbo.Areas", "Name", c => c.String());
            this.AlterColumn("dbo.ToolTypes", "Name", c => c.String());
        }
    }
}
