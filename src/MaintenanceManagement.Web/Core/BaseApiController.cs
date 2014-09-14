namespace MaintenanceManagement.Web.Core
{
    using System.Web.Http;

    using MaintenanceManagement.DataAccess;

    [Authorize]
    public abstract class BaseApiController : ApiController
    {
        protected BaseApiController()
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