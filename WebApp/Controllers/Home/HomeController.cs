﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Taxi.Web.Controllers.Home
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Phone = "Автоэвакуатор (круглосуточно) : (846) 274-55-66";
            return View();
        }

    }
}
