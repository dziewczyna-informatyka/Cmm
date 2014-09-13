namespace MaintenanceManagement.Web.Controllers.Api
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;

    using MaintenanceManagement.Core;
    using MaintenanceManagement.DataAccess;
    using MaintenanceManagement.DataAccess.Entities;
    using MaintenanceManagement.Web.Core;
    using MaintenanceManagement.Web.Models.Api;

    using WebGrease.Css;

    public class WorkSchedulesController : BaseApiController
    {
        public IEnumerable<IdNamePair> Get()
        {
            return EnumExtensions.GetAllIdNamePairs<WorkSchedule>();
        }
    }
}
