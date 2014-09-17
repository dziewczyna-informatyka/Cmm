namespace MaintenanceManagement.Web.Core
{
    using System;
    using System.Threading;
    using System.Web.Mvc;

    using MaintenanceManagement.DataAccess;

    [Authorize]
    public abstract class BaseController : Controller
    {
        protected BaseController()
        {
            MainContext = new MainContext();
        }

        protected MainContext MainContext { get; set; }

        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            LanguageHelper.LoadLanguage();

            return base.BeginExecuteCore(callback, state);
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