using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers.Taxi
{
    public class TaxiController : Controller
    {

        public static string Phone = "2-758-758";

        public ActionResult Index()
        {
            ViewBag.Phone = string.Format("Служба такси : {0}", Phone);
            return View();
        }

        public ActionResult Transfer()
        {
            ViewBag.Phone = string.Format("Служба такси : {0}", Phone);
            return View();
        }

        public ActionResult MejGorod()
        {
            ViewBag.Phone = string.Format("Служба такси : {0}", Phone);
            return View();
        }

        public ActionResult Voditel()
        {
            ViewBag.Phone = string.Format("Служба заказа : {0}", Phone);
            return View();
        }
    }
}