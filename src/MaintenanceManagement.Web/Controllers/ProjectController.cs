namespace MaintenanceManagement.Web.Controllers
{
    using System.Linq;
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
            var project = this.MainContext.Projects.Single(x => x.Id == id);

            return
                this.View(
                    new ProjectDetailsViewModel
                    {
                        ProjectId = id,
                        ProjectNumber = project.ProjectNumber,
                        ProjectName = project.Name
                    });
        }
    }
}