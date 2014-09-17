namespace MaintenanceManagement.Web.Controllers.Api
{
    using System.Collections.Generic;
    using System.Linq;

    using MaintenanceManagement.Core;
    using MaintenanceManagement.DataAccess;
    using MaintenanceManagement.Web.Core;

    public class EmployeeTaskStatusesController : BaseApiController
    {
        public IEnumerable<IdNamePair> Get()
        {
            return EnumExtensions.GetAllIdNamePairs<EmployeeTaskStatus>().OrderBy(x => x.Id).ToList();
        }
    }
}
