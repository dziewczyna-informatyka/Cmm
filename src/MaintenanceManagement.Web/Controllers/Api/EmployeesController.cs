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
                            Name = a.Name,
                            Surname = a.Surname,
                            Address = a.Address,
                            Area = new IdNamePair { Id = a.Area.Id, Name = a.Area.Name },
                            EmploymentStart = a.EmploymentStart,
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
            await MainContext.Update<Employee, EmployeePutModel>(
                model,
                (m, e) =>
                {
                    e.Name = m.Name;
                    e.Address = m.Address;
                    e.Area = MainContext.Areas.Single(a => a.Id == m.Area.Id);
                    e.EmploymentStart = m.EmploymentStart;
                    e.EmploymentType = EnumExtensions.FromIdNamePair<EmploymentType>(m.EmploymentType);
                    e.HomePhone = m.HomePhone;
                    e.IsAdmin = m.IsAdmin;
                    e.JobTitle = EnumExtensions.FromIdNamePair<JobTitle>(m.JobTitle);
                    e.Login = m.Login;
                    e.MobilePhone = m.MobilePhone;
                    e.Name = m.Name;
                    e.PersonalNumber = m.PersonalNumber;
                    e.Surname = m.Surname;
                    e.Team = EnumExtensions.FromIdNamePair<Team>(m.Team).GetValueOrDefault();
                    e.WorkSchedule = EnumExtensions.FromIdNamePair<WorkSchedule>(m.WorkSchedule);
                });

            return new BasePutResponse();
        }

        public async Task<BasePostResponse> Post(EmployeePostModel model)
        {
            var id =
                await
                MainContext.Insert(
                    new Employee
                    {
                        Address = model.Address,
                        Area = MainContext.Areas.Single(a => a.Id == model.Area.Id),
                        EmploymentStart = model.EmploymentStart,
                        EmploymentType = EnumExtensions.FromIdNamePair<EmploymentType>(model.EmploymentType),
                        HomePhone = model.HomePhone,
                        IsAdmin = model.IsAdmin,
                        JobTitle = EnumExtensions.FromIdNamePair<JobTitle>(model.JobTitle),
                        Login = model.Login,
                        MobilePhone = model.MobilePhone,
                        Name = model.Name,
                        PersonalNumber = model.PersonalNumber,
                        Surname = model.Surname,
                        Team = EnumExtensions.FromIdNamePair<Team>(model.Team).GetValueOrDefault(),
                        WorkSchedule = EnumExtensions.FromIdNamePair<WorkSchedule>(model.WorkSchedule)
                    });

            return new BasePostResponse { Id = id };
        }

        public async Task<BaseDeleteResponse> Delete(int id)
        {
            await MainContext.DeleteById<Employee>(id);
            return new BaseDeleteResponse();
        }
    }
}
