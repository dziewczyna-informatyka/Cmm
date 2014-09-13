namespace MaintenanceManagement.Web.Controllers.Api
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;

    using MaintenanceManagement.DataAccess.Entities;
    using MaintenanceManagement.Web.Core;
    using MaintenanceManagement.Web.Models.Api;

    using WebGrease.Css;

    public class EmployeesController : BaseApiController
    {
        public IEnumerable<EmployeeGetModel> Get()
        {
            return
                MainContext.Employees.OrderBy(a => a.Surname).Select(a => new EmployeeGetModel { Id = a.Id, Name = a.Name }).ToList();
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
