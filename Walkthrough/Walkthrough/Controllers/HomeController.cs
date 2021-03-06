﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Walkthrough.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Overview()
        {
            return View();
        }

        public ActionResult MvcOverview()
        {
            return View();
        }

        public ActionResult CreatingAProject()
        {
            return View();
        }

        public ActionResult ScaffoldedProjectCodeOverview()
        {
            return View();
        }

        public ActionResult ORMApproaches()
        {
            return View();
        }

        public ActionResult StartingCodeFirst()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}