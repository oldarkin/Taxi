using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class CarServicePrice
    {
        public Guid GroupId { get; set; }

        public string GroupName
        { get; set; }

        public List<CarServicePriceItem> PriceItems { get; set; }
    }
}