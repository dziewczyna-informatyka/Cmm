namespace MaintenanceManagement.Web.Controllers.Api
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;

    using MaintenanceManagement.Web.Core;
    using MaintenanceManagement.Web.Models;

    public class AreasController : BaseApiController
    {
        public IEnumerable<AreaModel> Get()
        {
            return
                MainContext.Areas.OrderBy(a => a.Name).Select(a => new AreaModel { Id = a.Id, Name = a.Name }).ToList();
        }

        public async Task<int> Delete(int id)
        {
            var entity = await MainContext.Areas.SingleOrDefaultAsync(e => e.Id == id);
            MainContext.Areas.Remove(entity);
            await MainContext.SaveChangesAsync();

            return id;
        }
    }
}
