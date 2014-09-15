namespace MaintenanceManagement.Web.Controllers
{
    using System.Web.Mvc;

    using MaintenanceManagement.Web.Core;

    public class TemplateController : BaseController
    {
        public ActionResult Grid()
        {
            return this.View();
        }

        public ActionResult Editor()
        {
            return this.View();
        }

        public ActionResult DropDown()
        {
            return this.View();
        }

        public ActionResult TaskBoard()
        {
            return this.View();
        }
    }
}