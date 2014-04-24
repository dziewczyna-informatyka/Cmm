namespace MaintenanceManagement.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntitiesChanges : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "PersonalNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "PersonalNumber", c => c.Int());
        }
    }
}
