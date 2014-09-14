namespace MaintenanceManagement.Web.Controllers.Api
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using MaintenanceManagement.DataAccess.Entities;
    using MaintenanceManagement.Web.Core;
    using MaintenanceManagement.Web.Models.Api;

    public class AreasController : BaseApiController
    {
        public IEnumerable<AreaGetModel> Get()
        {
            return
                MainContext.Areas.OrderBy(a => a.Name).Select(a => new AreaGetModel { Id = a.Id, Name = a.Name }).ToList();
        }

        public async Task<BasePutResponse> Put(AreaPutModel model)
        {
            await MainContext.Update<Area, AreaPutModel>(model, (m, e) => e.Name = m.Name);

            return new BasePutResponse();
        }

        public async Task<BasePostResponse> Post(AreaPostModel model)
        {
            var id = await MainContext.Insert(new Area { Name = model.Name });
            return new BasePostResponse { Id = id };
        }

        public async Task<BaseDeleteResponse> Delete(int id)
        {
            await MainContext.DeleteById<Area>(id);
            return new BaseDeleteResponse();
        }
    }
}
