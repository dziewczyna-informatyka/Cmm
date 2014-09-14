namespace MaintenanceManagement.Web.Controllers
{
    using System.Web.Mvc;

    using MaintenanceManagement.Web.Core;
    using MaintenanceManagement.Web.Models;

    public class ProjectController : BaseController
    {
        // GET: ToolType
        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult Details(int id)
        {
            return this.View(new ProjectDetailsViewModel { ProjectId = id });
        }
    }
}