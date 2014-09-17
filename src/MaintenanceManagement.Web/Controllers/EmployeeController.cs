namespace MaintenanceManagement.Web.Controllers
{
    using System.Web.Mvc;

    using MaintenanceManagement.Core;
    using MaintenanceManagement.Web.Core;

    [Authorize(Roles = CmmRoles.Administrator)]
    public class EmployeeController : BaseController
    {
        // GET: ToolType
        public ActionResult Index()
        {
            return this.View();
        }
    }
}