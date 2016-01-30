using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers.Taxi
{
    public class TaxiController : Controller
    {
        // GET: Taxi
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Transfer()
        {
            return View();
        }

        public ActionResult MejGorod()
        {
            return View();
        }

        public ActionResult Voditel()
        {
            return View();
        }
    }
}