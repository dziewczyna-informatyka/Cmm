namespace MaintenanceManagement.Web.Controllers.Api
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using MaintenanceManagement.Core;
    using MaintenanceManagement.DataAccess;
    using MaintenanceManagement.DataAccess.Entities;
    using MaintenanceManagement.Web.Core;
    using MaintenanceManagement.Web.Models.Api;

    public class EmployeesController : BaseApiController
    {
        public IEnumerable<EmployeeGetModel> Get()
        {
            return
                MainContext.Employees.OrderBy(a => a.Surname)
                    .ToList()
                    .Select(
                        a =>
                        new EmployeeGetModel
                        {
                            Id = a.Id,
                            FirstName = a.FirstName,
                            Surname = a.Surname,
                            Address = a.Address,
                            Area = new IdNamePair { Id = a.Area.Id, Name = a.Area.Name },
                            EmploymentStart = a.EmploymentStart.ToCmmDate(),
                            EmploymentType = a.EmploymentType.ToIdNamePair(),
                            HomePhone = a.HomePhone,
                            IsAdmin = a.IsAdmin,
                            JobTitle = a.JobTitle.ToIdNamePair(),
                            Login = a.Login,
                            MobilePhone = a.MobilePhone,
                            PersonalNumber = a.PersonalNumber,
                            Team = a.Team.ToIdNamePair(),
                            WorkSchedule = a.WorkSchedule.ToIdNamePair()
                        });
        }

        public async Task<BasePutResponse> Put(EmployeePutModel model)
        {
            var employee = await MainContext.Update<Employee, EmployeePutModel>(
                model,
                (m, e) =>
                {
                    e.FirstName = m.FirstName;
                    e.Address = m.Address;
                    e.Area = MainContext.Areas.Single(a => a.Id == m.Area.Id);
                    e.EmploymentStart = m.EmploymentStart.ParseDateTime();
                    e.EmploymentType = EnumExtensions.FromIdNamePair<EmploymentType>(m.EmploymentType);
                    e.HomePhone = m.HomePhone;
                    e.IsAdmin = m.IsAdmin;
                    e.JobTitle = EnumExtensions.FromIdNamePair<JobTitle>(m.JobTitle);
                    e.Login = m.Login;
                    e.MobilePhone = m.MobilePhone;
                    e.FirstName = m.FirstName;
                    e.PersonalNumber = m.PersonalNumber;
                    e.Surname = m.Surname;
                    e.Team = EnumExtensions.FromIdNamePair<Team>(m.Team).GetValueOrDefault();
                    e.WorkSchedule = EnumExtensions.FromIdNamePair<WorkSchedule>(m.WorkSchedule);
                });

            this.UpdatePassword(employee, model.Password, model.ConfirmPassword);

            await MainContext.SaveChangesAsync();

            return new BasePutResponse();
        }

        public async Task<BasePostResponse> Post(EmployeePostModel model)
        {
            var employee = new Employee
            {
                Address = model.Address,
                Area = MainContext.Areas.Single(a => a.Id == model.Area.Id),
                EmploymentStart = model.EmploymentStart.ParseDateTime(),
                EmploymentType = EnumExtensions.FromIdNamePair<EmploymentType>(model.EmploymentType),
                HomePhone = model.HomePhone,
                IsAdmin = model.IsAdmin,
                JobTitle = EnumExtensions.FromIdNamePair<JobTitle>(model.JobTitle),
                Login = model.Login,
                MobilePhone = model.MobilePhone,
                FirstName = model.FirstName,
                PersonalNumber = model.PersonalNumber,
                Surname = model.Surname,
                Team = EnumExtensions.FromIdNamePair<Team>(model.Team).GetValueOrDefault(),
                WorkSchedule = EnumExtensions.FromIdNamePair<WorkSchedule>(model.WorkSchedule)
            };

            var id = await MainContext.Insert(employee);
            
            this.UpdatePassword(employee, model.Password, model.ConfirmPassword);
            
            await MainContext.SaveChangesAsync();

            return new BasePostResponse { Id = id };
        }

        public async Task<BaseDeleteResponse> Delete(int id)
        {
            await MainContext.DeleteById<Employee>(id);
            return new BaseDeleteResponse();
        }

        private void UpdatePassword(Employee employee, string password, string confirmPassword)
        {
            if (string.IsNullOrWhiteSpace(password) || password != confirmPassword)
            {
                return;
            }

            employee.PasswordHash = HashHelper.GetHash(password);
        }
    }
}
