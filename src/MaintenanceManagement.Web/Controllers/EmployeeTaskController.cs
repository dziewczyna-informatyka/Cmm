namespace MaintenanceManagement.Web.Controllers
{
    using System.Web.Mvc;

    using MaintenanceManagement.Web.Core;

    public class EmployeeTaskController : BaseController
    {
        // GET: EmployeeTask
        public ActionResult Index()
        {
            return this.View();
        }
    }
}