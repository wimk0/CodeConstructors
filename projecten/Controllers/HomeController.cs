﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projecten.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Index";
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "over";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "contact";

            return View();
        }
      
    }
}
