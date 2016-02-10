using System;
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
            ViewBag.MetaDescription = "Услуги автосервиса в Самаре. Профессиональный ремонт автомобилей импортного и отечественного производтва. Компьютерная диагностика автомобилей старше 1995 года. Сход-развал по доступным ценам. Тарифы, цены на услуги автосервиса. Услуги автоэвакуатора в Самаре по доступным ценам и быстрой подачей.";
            ViewBag.MetaKeywords = "автосервис, Самара автосервис, автосервис Самара, автоуслуги, эвакуатор, ремонт машин, сход-развал, развал, схождение";
            ViewBag.Title = "Автосервис в Самаре | телефоны, цены, заказ такси, заказ эвакуатора - Альянс плюс";
            return View();
        }

    }
}
