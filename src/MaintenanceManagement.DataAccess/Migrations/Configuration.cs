namespace MaintenanceManagement.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;

    using MaintenanceManagement.Core;
    using MaintenanceManagement.DataAccess.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<MainContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MainContext context)
        {          
        }
    }
}
