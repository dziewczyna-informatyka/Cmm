namespace MaintenanceManagement.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddedProject : DbMigration
    {
        public override void Up()
        {
            this.CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        DueDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
        }

        public override void Down()
        {
            this.DropIndex("dbo.Projects", new[] { "Name" });
            this.DropTable("dbo.Projects");
        }
    }
}
