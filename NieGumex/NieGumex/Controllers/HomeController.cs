﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NieGumex.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
            //komentarz lili
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
            //szalony loczek :O
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}