﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InvoiceDisk.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult AboutMe()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult ME()
        {
            ViewBag.Title = "Home Page Rukhsar";

            return View();
        }


        public ActionResult MEe()
        {
            ViewBag.Title = "Home Page Rukhsar";

            return View();
        }

    }
}
