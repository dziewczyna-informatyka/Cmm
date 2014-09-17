namespace MaintenanceManagement.Web.Core
{
    using System.Threading;
    using System.Web.Http;
    using System.Web.Http.Controllers;

    using MaintenanceManagement.DataAccess;

    [Authorize]
    public abstract class BaseApiController : ApiController
    {
        protected BaseApiController()
        {
            MainContext = new MainContext();
        }

        protected MainContext MainContext { get; set; }

        protected override void Initialize(HttpControllerContext controllerContext)
        {
            LanguageHelper.LoadLanguage();

            base.Initialize(controllerContext);
        }

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