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
        public ActionResult Common()
        {
            var webCommonScript = this.Resource<WebCommon>("WebCommon");
            var datePickerScript = this.Resource<DatePicker>("DP");

            var authScript = string.Format(
                "var CmmAuth = {{ roles: [{0}], login: '{1}' }};",
                string.Join(",", Roles.GetRolesForUser(User.Identity.Name).Select(v => string.Format("'{0}'", v))),
                User.Identity.Name);

            return this.JavaScript(string.Join(" ", webCommonScript, authScript, datePickerScript));
        }

        private string Resource<T>(string resourceName)
        {
            var properties =
                typeof(T).GetProperties()
                    .Where(pi => pi.PropertyType == typeof(string))
                    .Select(pi => string.Format("{0}:'{1}'", pi.Name, pi.GetValue(null)));

            return string.Format("var {0} = {{ {1} }};", resourceName, string.Join(",", properties));
        }
    }
}