namespace MaintenanceManagement.Web.Controllers.Api
{
    using System.Collections.Generic;

    using MaintenanceManagement.Core;
    using MaintenanceManagement.DataAccess;
    using MaintenanceManagement.Web.Core;

    public class WorkSchedulesController : BaseApiController
    {
        public IEnumerable<IdNamePair> Get()
        {
            return EnumExtensions.GetAllIdNamePairs<WorkSchedule>();
        }
    }
}
