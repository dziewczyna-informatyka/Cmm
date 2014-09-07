namespace MaintenanceManagement.Web.Controllers
{
    using System.Web.Mvc;

    using MaintenanceManagement.Web.Core;

    public class AccountController : BaseController
    {
        [AllowAnonymous]
        public ActionResult LogIn()
        {
            return this.View();
        }
    }
}