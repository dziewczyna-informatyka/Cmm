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

    public class ToolTypesController : BaseApiController
    {
        public IEnumerable<ToolTypeGetModel> Get()
        {
            return
                MainContext.ToolTypes.OrderBy(a => a.Name).Select(a => new ToolTypeGetModel { Id = a.Id, Name = a.Name }).ToList();
        }

        public async Task<BasePutResponse> Put(ToolTypePutModel model)
        {
            await MainContext.Update<ToolType, ToolTypePutModel>(model, (m, e) => e.Name = m.Name);

            return new BasePutResponse();
        }

        public async Task<BasePostResponse> Post(ToolTypePostModel model)
        {
            var id = await MainContext.Insert(new ToolType { Name = model.Name });
            return new BasePostResponse { Id = id };
        }

        public async Task<BaseDeleteResponse> Delete(int id)
        {
            await MainContext.DeleteById<ToolType>(id);
            return new BaseDeleteResponse();
        }
    }
}
