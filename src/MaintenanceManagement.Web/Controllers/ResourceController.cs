namespace MaintenanceManagement.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using System.Web.Security;

    using MaintenanceManagement.Core;
    using MaintenanceManagement.Web.Core;
    using MaintenanceManagement.Web.Resources;

    public class ResourceController : BaseController
    {
        [AllowAnonymous]
        public ActionResult WebCommon()
        {
            var properties =
                typeof(WebCommon).GetProperties()
                    .Where(pi => pi.PropertyType == typeof(string))
                    .Select(pi => string.Format("{0}: '{1}'", pi.Name, pi.GetValue(null)));

            var webCommonScript = string.Format("var WebCommon = {{ {0} }};", string.Join(",", properties));
            var authScript = string.Format(
                "var CmmAuth = {{ roles: [{0}], login: '{1}' }};",
                string.Join(",", Roles.GetRolesForUser(User.Identity.Name).Select(v => string.Format("'{0}'", v))),
                User.Identity.Name);

            return this.JavaScript(string.Join(" ", webCommonScript, authScript));
        }
    }
}