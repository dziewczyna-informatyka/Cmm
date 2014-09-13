namespace MaintenanceManagement.Web.Controllers.Api
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using MaintenanceManagement.Core;
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
            await MainContext.Update<Employee, EmployeePutModel>(model, (m, e) => e.Name = m.Name);

            return new BasePutResponse();
        }

        public async Task<BasePostResponse> Post(EmployeePostModel model)
        {
            var id = await MainContext.Insert(new Employee { Name = model.Name });
            return new BasePostResponse { Id = id };
        }

        public async Task<BaseDeleteResponse> Delete(int id)
        {
            await MainContext.DeleteById<Employee>(id);
            return new BaseDeleteResponse();
        }
    }
}
