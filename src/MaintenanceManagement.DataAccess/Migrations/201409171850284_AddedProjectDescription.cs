namespace MaintenanceManagement.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedProjectDescription : DbMigration
    {
        public override void Up()
        {
            this.AddColumn("dbo.Projects", "Description", c => c.String());
        }
        
        public override void Down()
        {
            this.DropColumn("dbo.Projects", "Description");
        }
    }
}
