namespace MaintenanceManagement.Web
{
    using System.Web.Optimization;

    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-ui-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/libs").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/bootstrap-datepicker.js",
                      "~/Scripts/angular.ui.sortable.js",
                      "~/Scripts/jquery.BlockUI.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/themes/base/*.css",
                      "~/Content/datepicker.css",
                      "~/Content/font-awesome.css"));

            bundles.Add(new LessBundle("~/Content/custom").Include(
                     "~/Content/Site.less"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                      "~/Scripts/app/ArrayHelper.js",
                      "~/Scripts/app/cmmApp.js",
                      "~/Scripts/app/blockuiInterceptor.js",
                      "~/Scripts/app/apiClient.js",
                      "~/Scripts/app/EditorHelper.js",                     
                      "~/Scripts/app/cmmDatePicker.js",
                      "~/Scripts/app/cmmDropDown.js",                      
                      "~/Scripts/app/cmmButton.js",
                      "~/Scripts/app/cmmEditor.js",
                      "~/Scripts/app/cmmGrid.js",
                      "~/Scripts/app/cmmTaskBoard.js",
                      "~/Scripts/app/ProjectDetailsController.js"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}
