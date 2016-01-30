using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApp.Models;

namespace WebApp.Controllers.CarService
{
    public class CarServiceApiController : ApiController
    {
        [HttpGet]
        [ActionName("GetPriceInomarki")]
        public List<CarServicePrice> GetInomarki()
        {
            List<CarServicePrice> result = new List<CarServicePrice>();

            CarServicePrice item = new CarServicePrice() { GroupName = "Group 1", GroupId = Guid.NewGuid() };
            item.PriceItems = new List<CarServicePriceItem>();
            item.PriceItems.Add(new CarServicePriceItem() { Id = Guid.NewGuid(), Name = "Ремонт 1", Price = 200 });

            result.Add(item);

            CarServicePrice item1 = new CarServicePrice() { GroupName = "Group 1", GroupId = Guid.NewGuid() };
            item1.PriceItems = new List<CarServicePriceItem>();
            item1.PriceItems.Add(new CarServicePriceItem() { Id = Guid.NewGuid(), Name = "Ремонт 2", Price = 350 });

            result.Add(item1);

            CarServicePrice item2 = new CarServicePrice() { GroupName = "Group 2", GroupId = Guid.NewGuid() };
            item2.PriceItems = new List<CarServicePriceItem>();
            item2.PriceItems.Add(new CarServicePriceItem() { Id = Guid.NewGuid(), Name = "Ремонт 3", Price = 700 });

            result.Add(item2);

            return result;
        }

        [HttpGet]
        [ActionName("GetPriceRusskie")]
        public List<CarServicePrice> GetRusskie()
        {
            List<CarServicePrice> result = new List<CarServicePrice>();

            CarServicePrice item = new CarServicePrice() { GroupName = "Group 4", GroupId = Guid.NewGuid() };
            item.PriceItems = new List<CarServicePriceItem>();
            item.PriceItems.Add(new CarServicePriceItem() { Id = Guid.NewGuid(), Name = "Ремонт 1", Price = 200 });

            result.Add(item);

            CarServicePrice item1 = new CarServicePrice() { GroupName = "Group 4", GroupId = Guid.NewGuid() };
            item1.PriceItems = new List<CarServicePriceItem>();
            item1.PriceItems.Add(new CarServicePriceItem() { Id = Guid.NewGuid(), Name = "Ремонт 2", Price = 350 });

            result.Add(item1);

            CarServicePrice item2 = new CarServicePrice() { GroupName = "Group 5", GroupId = Guid.NewGuid() };
            item2.PriceItems = new List<CarServicePriceItem>();
            item2.PriceItems.Add(new CarServicePriceItem() { Id = Guid.NewGuid(), Name = "Ремонт 3", Price = 700 });

            result.Add(item2);

            return result;
        }
    }
}
