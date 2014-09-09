namespace MaintenanceManagement.Web.Controllers.Api
{
    using System.Collections.Generic;
    using System.Linq;

    using MaintenanceManagement.Web.Core;
    using MaintenanceManagement.Web.Models;

    public class AreasController : BaseApiController
    {
        public IEnumerable<AreaModel> Get()
        {
            return MainContext.Areas.Select(a => new AreaModel { Id = a.Id, Name = a.Name }).ToList();
        }
    }
}
