namespace MaintenanceManagement.Web.Controllers
{
    using System.Web.Mvc;

    using MaintenanceManagement.Web.Core;

    public class AreaController : BaseController
    {
        // GET: Area
        public ActionResult Index()
        {
            return this.View();
        }
    }
}