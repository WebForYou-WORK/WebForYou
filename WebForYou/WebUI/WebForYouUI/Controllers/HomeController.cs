﻿using System.Web.Mvc;

namespace WebForYouUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult StartPage()
        {
            return View();
        }
    }
}