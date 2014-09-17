namespace MaintenanceManagement.Web.Controllers
{
    using System.Web.Mvc;

    using MaintenanceManagement.Core;
    using MaintenanceManagement.Web.Core;

    [Authorize(Roles = CmmRoles.Administrator)]
    public class AreaController : BaseController
    {
        // GET: Area
        public ActionResult Index()
        {
            return this.View();
        }
    }
}