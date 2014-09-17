namespace MaintenanceManagement.Web.Controllers.Api
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web.Http;

    using MaintenanceManagement.Core;
    using MaintenanceManagement.DataAccess.Entities;
    using MaintenanceManagement.Web.Core;
    using MaintenanceManagement.Web.Models.Api;

    public class ToolTypesController : BaseApiController
    {
        public IEnumerable<ToolTypeGetModel> Get()
        {
            return
                MainContext.ToolTypes.OrderBy(a => a.Name).Select(a => new ToolTypeGetModel { Id = a.Id, Name = a.Name }).ToList();
        }

        [Authorize(Roles = CmmRoles.Administrator)]
        public async Task<BasePutResponse> Put(ToolTypePutModel model)
        {
            await MainContext.Update<ToolType, ToolTypePutModel>(model, (m, e) => e.Name = m.Name);

            return new BasePutResponse();
        }

        [Authorize(Roles = CmmRoles.Administrator)]
        public async Task<BasePostResponse> Post(ToolTypePostModel model)
        {
            var id = await MainContext.Insert(new ToolType { Name = model.Name });
            return new BasePostResponse { Id = id };
        }

        [Authorize(Roles = CmmRoles.Administrator)]
        public async Task<BaseDeleteResponse> Delete(int id)
        {
            await MainContext.DeleteById<ToolType>(id);
            return new BaseDeleteResponse();
        }
    }
}
