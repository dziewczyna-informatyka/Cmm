namespace MaintenanceManagement.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeNameRenamedToFirstName : DbMigration
    {
        public override void Up()
        {
            this.RenameColumn("dbo.Employees",  "Name", "FirstName");            
        }
        
        public override void Down()
        {
            this.RenameColumn("dbo.Employees", "FirstName", "Name");
        }
    }
}
