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
                new Area { Id = 1, Name = "Kierownictwo" },
                new Area { Id = 2, Name = "Kontrolling" },
                new Area { Id = 3, Name = "Wtryskarki" },
                new Area { Id = 4, Name = "Maszyny pakuj¹ce" },
                new Area { Id = 5, Name = "Ekstruder" },
                new Area { Id = 6, Name = "Automaty" },
                new Area { Id = 7, Name = "Facility" },
                new Area { Id = 8, Name = "Strefa bia³a" },
                new Area { Id = 9, Name = "Strefa szara" });
            context.SaveChanges();

            context.ToolTypes.AddOrUpdate(
                e => e.Id,
                new ToolType { Id = 1, Name = "Nó¿" },
                new ToolType { Id = 2, Name = "Imbusy" });
            context.SaveChanges();

            context.Employees.AddOrUpdate(
                e => e.Id,
                new Employee
                {
                    Id = 1,
                    Area = context.Areas.Single(a => a.Id == 2),
                    EmploymentType = EmploymentType.Clinico,
                    Login = "marwol",
                    PersonalNumber = 3425,
                    Surname = "Wolkowska",
                    Name = "Marta",
                    PasswordHash = HashHelper.GetHash("test"),
                    IsAdmin = true
                },
                new Employee
                {
                    Id = 2,
                    Area = context.Areas.Single(a => a.Id == 1),
                    EmploymentType = EmploymentType.Clinico,
                    Login = "lucjuz",
                    PersonalNumber = 1389,
                    Surname = "Juzyk-Ró¿añska",
                    Name = "£ucja",
                    PasswordHash = HashHelper.GetHash("test"),
                    IsAdmin = true
                },
                new Employee
                {
                    Id = 3,
                    Area = context.Areas.Single(a => a.Id == 1),
                    EmploymentType = EmploymentType.Clinico,
                    Login = "jacroj",
                    PersonalNumber = 1076,
                    Surname = "Rojek",
                    Name = "Jacek",
                    PasswordHash = HashHelper.GetHash("test"),
                    IsAdmin = true
                },
                new Employee
                {
                    Id = 4,
                    Area = context.Areas.Single(a => a.Id == 1),
                    EmploymentType = EmploymentType.Clinico,
                    Login = "wojmis",
                    PersonalNumber = 1166,
                    Surname = "Miœkowski",
                    Name = "Wojciech",
                    PasswordHash = HashHelper.GetHash("test"),
                    IsAdmin = true
                });

            context.SaveChanges();
        }
    }
}
