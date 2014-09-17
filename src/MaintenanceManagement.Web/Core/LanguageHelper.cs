namespace MaintenanceManagement.Web.Core
{
    using System;
    using System.Threading;
    using System.Web;

    public static class LanguageHelper
    {
        private static HttpContext Context
        {
            get
            {
                return HttpContext.Current;
            }
        }

        public static void SetLanguage(string culture)
        {
            Context.Response.Cookies.Add(new HttpCookie("cmm_lang", culture) { Expires = DateTime.Now.AddYears(10) });
        }

        public static void LoadLanguage()
        {
            var cookie = Context.Request.Cookies["cmm_lang"];
            var lang = cookie != null ? cookie.Value : "pl-PL";

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(lang);
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
        }
    }
}