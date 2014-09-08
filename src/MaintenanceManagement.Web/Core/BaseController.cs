namespace MaintenanceManagement.Web.Core
{
    using System.Web.Mvc;

    using MaintenanceManagement.DataAccess;

    [Authorize]
    public class BaseController : Controller
    {
        public BaseController()
        {
            MainContext = new MainContext();
        }

        protected MainContext MainContext { get; set; }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if (disposing)
            {
                MainContext.Dispose();
                MainContext = null;
            }
        }
    }
}