namespace MaintenanceManagement.Web.Controllers
{
    using System.Web.Mvc;

    using MaintenanceManagement.Web.Core;

    public class ProjectController : BaseController
    {
        // GET: ToolType
        public ActionResult Index()
        {
            return this.View();
        }
    }
}