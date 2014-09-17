namespace MaintenanceManagement.Web.Controllers
{
    using System.Web.Mvc;

    using MaintenanceManagement.Web.Core;

    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return this.RedirectToAction("Index", "Project");
        }
    }
}
