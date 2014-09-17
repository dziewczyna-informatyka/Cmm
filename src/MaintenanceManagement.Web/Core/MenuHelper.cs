namespace MaintenanceManagement.Web.Core
{
    using System.Text;
    using System.Web.Mvc;
    using System.Web.Security;

    using MaintenanceManagement.Core;
    using MaintenanceManagement.Web.Resources;

    public static class MenuHelper
    {
        public static MvcHtmlString CmmMenuItems(this HtmlHelper helper)
        {
            var sb = new StringBuilder();

            sb.AppendFormat(RenderLine(helper, WebCommon.ProjectPageTitle, "Project", CmmRoles.User));
            sb.AppendFormat(RenderLine(helper, WebCommon.EmployeeTaskPageTitle, "EmployeeTask", CmmRoles.User));
            sb.AppendFormat(RenderLine(helper, WebCommon.EmployeePageTitle, "Employee", CmmRoles.Administrator));
            sb.AppendFormat(RenderLine(helper, WebCommon.ToolTypePageTitle, "ToolType", CmmRoles.Administrator));
            sb.AppendFormat(RenderLine(helper, WebCommon.AreasPageTitle, "Area", CmmRoles.Administrator));

            return new MvcHtmlString(sb.ToString());
        }

        private static string RenderLine(HtmlHelper helper, string title, string controller, string role)
        {
            return !helper.ViewContext.HttpContext.User.IsInRole(role)
                       ? string.Empty
                       : string.Format(
                           "<li class='{2}'><a href='/{0}'>{1}</a></li>",
                           controller,
                           title,
                           helper.ViewContext.RouteData.Values["controller"].ToString() == controller ? "active" : string.Empty);
        }
    }
}