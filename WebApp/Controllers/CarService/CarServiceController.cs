using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Taxi.Web.Controllers.CarService
{
    public class CarServiceController : Controller
    {
        //
        // GET: /CarService/

        public static string Phone = "(846) 274-71-71";
        public static string Adress = "7-я просека, 3-й проезд, 3";

        public ActionResult Index()
        {
            ViewBag.Phone = string.Format("Автосервис : {0} - {1}", Phone, Adress);
            return View();
        }

        public ActionResult PriceInomarki()
        {
            ViewBag.Phone = string.Format("Автосервис : {0} - {1}", Phone, Adress);
            return View();
        }

        public ActionResult PriceRusskie()
        {
            ViewBag.Phone = string.Format("Автосервис : {0} - {1}", Phone, Adress);
            return View();
        }

        public ActionResult Diagnostika()
        {
            ViewBag.Phone = string.Format("Автосервис : {0} - {1}", Phone, Adress);
            return View();
        }

        public ActionResult CompDiagnostika()
        {
            ViewBag.Phone = string.Format("Автосервис : {0} - {1}", Phone, Adress);
            return View();
        }

        public ActionResult Motory()
        {
            ViewBag.Phone = string.Format("Автосервис : {0} - {1}", Phone, Adress);
            return View();
        }

        public ActionResult MehKpp()
        {
            ViewBag.Phone = string.Format("Автосервис : {0} - {1}", Phone, Adress);
            return View();
        }

        public ActionResult Akpp()
        {
            ViewBag.Phone = string.Format("Автосервис : {0} - {1}", Phone, Adress);
            return View();
        }

        public ActionResult Hodovaya()
        {
            ViewBag.Phone = string.Format("Автосервис : {0} - {1}", Phone, Adress);
            return View();
        }

        public ActionResult BreakSystem()
        {
            ViewBag.Phone = string.Format("Автосервис : {0} - {1}", Phone, Adress);
            return View();
        }

        public ActionResult Slesar()
        {
            ViewBag.Phone = string.Format("Автосервис : {0} - {1}", Phone, Adress);
            return View();
        }

        public ActionResult Parts()
        {
            ViewBag.Phone = string.Format("Автосервис : {0} - {1}", Phone, Adress);
            return View();
        }

        public ActionResult DiagHodovka()
        {
            ViewBag.Phone = string.Format("Автосервис : {0} - {1}", Phone, Adress);
            return View();
        }

        public ActionResult MasloAkpp()
        {
            ViewBag.Phone = string.Format("Автосервис : {0} - {1}", Phone, Adress);
            return View();
        }

        public ActionResult TO()
        {
            ViewBag.Phone = string.Format("Автосервис : {0} - {1}", Phone, Adress);
            return View();
        }

    }
}
