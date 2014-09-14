namespace MaintenanceManagement.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

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

            var script = string.Format("var WebCommon = {{ {0} }};", string.Join(",", properties));

            return this.JavaScript(script);
        }
    }
}