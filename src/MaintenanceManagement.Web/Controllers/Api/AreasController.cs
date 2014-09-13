﻿namespace MaintenanceManagement.Web.Controllers.Api
{
    using System.Collections.Generic;
    using System.Data.Entity;
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

        public async Task Put(AreaPutModel model)
        {
            var entity = await MainContext.Areas.SingleOrDefaultAsync(e => e.Id == model.Id);

            entity.Name = model.Name;

            await MainContext.SaveChangesAsync();
        }

        public async Task<int> Post(AreaPostModel model)
        {
            var entity = MainContext.Areas.Add(new Area { Name = model.Name });
            await MainContext.SaveChangesAsync();

            return entity.Id;
        }

        public async Task Delete(int id)
        {
            var entity = await MainContext.Areas.SingleOrDefaultAsync(e => e.Id == id);
            MainContext.Areas.Remove(entity);
            await MainContext.SaveChangesAsync();
        }
    }
}
