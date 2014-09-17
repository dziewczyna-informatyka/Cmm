﻿namespace MaintenanceManagement.Web.Controllers
{
    using System.Web.Mvc;

    using MaintenanceManagement.Web.Core;

    public class LanguageController : BaseController
    {
        // GET: EmployeeTask
        public ActionResult Polish()
        {
            LanguageHelper.SetLanguage("pl-PL");
            return this.RedirectToAction("Index", "Home");
        }

        // GET: EmployeeTask
        public ActionResult English()
        {
            LanguageHelper.SetLanguage("en-GB");
            return this.RedirectToAction("Index", "Home");
        }
    }
}