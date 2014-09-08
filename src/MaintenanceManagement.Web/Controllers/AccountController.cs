namespace MaintenanceManagement.Web.Controllers
{
    using System.Web.Mvc;
    using System.Web.Security;

    using MaintenanceManagement.Web.Core;
    using MaintenanceManagement.Web.Models;
    using MaintenanceManagement.Web.Resources;

    public class AccountController : BaseController
    {
        [AllowAnonymous]
        public ActionResult LogIn(string redirectUrl)
        {
            return this.View(new AccountLogInModel { RedirectUrl = redirectUrl });
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult LogIn(AccountLogInModel model)
        {
            if (model.Username == "test" && model.Password == "test")
            {
                FormsAuthentication.SetAuthCookie(model.Username, true);
                return this.Redirect(model.RedirectUrl ?? FormsAuthentication.DefaultUrl);
            }

            ModelState.AddModelError(string.Empty, WebCommon.InvalidUserOrPassword);

            return this.View(model);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}