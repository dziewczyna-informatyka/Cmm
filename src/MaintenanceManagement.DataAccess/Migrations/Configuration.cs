using MaintenanceManagement.Core;
using MaintenanceManagement.DataAccess.Entities;

namespace MaintenanceManagement.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MainContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MainContext context)
        {
            context.Areas.AddOrUpdate(
                e => e.Id,
                new Area { Id = 1, Name = "Controlling" },
                new Area { Id = 2, Name = "Wtryskarki" });
            context.SaveChanges();

            context.ToolTypes.AddOrUpdate(
                e => e.Id,
                new ToolType { Id = 1, Name = "Mlotek" },
                new ToolType { Id = 2, Name = "Srubokret" });
            context.SaveChanges();

            context.Employees.AddOrUpdate(
                e => e.Id,
                new Employee
                {
                    Id = 1,
                    Area = context.Areas.Single(a => a.Id == 1),
                    EmploymentType = EmploymentType.Clinico,
                    Login = "marwol",
                    PersonalNumber = 3554,
                    Surname = "Wolkowska",
                    Name = "Marta",
                },
                new Employee
                {
                    Id = 2,
                    Area = context.Areas.Single(a => a.Id == 1),
                    EmploymentType = EmploymentType.Manpower,
                    Login = "marmiel",
                    PersonalNumber = 3333,
                    Surname = "Mielnik",
                    Name = "Mariusz",
                    PasswordHash = HashHelper.GetHash("test")
                },
                new Employee
                {
                    Id = 3,
                    Area = context.Areas.Single(a => a.Id == 2),
                    EmploymentType = EmploymentType.Clinico,
                    Login = "arkmul",
                    PersonalNumber = 2222,
                    Surname = "Mulak",
                    Name = "Arkadiusz",
                });

            context.SaveChanges();
        }
    }
}
