namespace MaintenanceManagement.Web.Controllers
{
    using System.Data.Entity;
    using System.Threading.Tasks;
    using System.Web.Mvc;
    using System.Web.Security;

    using MaintenanceManagement.Core;
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
        public async Task<ActionResult> LogIn(AccountLogInModel model)
        {
            var user = await MainContext.Employees.SingleOrDefaultAsync(x => x.Login == model.Username);

            if (user != null && user.PasswordHash == HashHelper.GetHash(model.Password))
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
            return this.RedirectToAction("Index", "Home");
        }
    }
}