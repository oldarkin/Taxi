using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Taxi.Web.Controllers.Evacuation
{
    public class EvacuationController : Controller
    {
        //
        // GET: /Evacuation/

        public ActionResult Index()
        {
            ViewBag.MetaDescription = "Эвакуаторы компании АльянсПлюс осуществляют круглосуточную эвакуацию автомобилей в Самаре и Самарской области. Нашим клиентам доступна эвакуация не только легковых автомобилей но и внедорожников с разрешенной массой до 3,5 тонн";
            ViewBag.MetaKeywords = "эвакуаторы, эвакуаторы в Самаре, эвакуаторы Самаре, эвакуаторы круглосуточно в Самаре, вызвать Эвакуатор, заказать эвакуатор, вызвать эвакуатор, эвакуатор вызвать";
            ViewBag.Title = "Эвакуаторы в Самаре: круглосуточно, без выходных, эвакуация автомобиля от 1100 руб";
            return View();
        }

    }
}
