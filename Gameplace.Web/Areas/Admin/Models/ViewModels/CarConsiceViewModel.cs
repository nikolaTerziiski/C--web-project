using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarParadise.Web.Areas.Admin.Models.ViewModels
{
    public class CarConsiceViewModel
    {
        public string Brand { get; set; }

        public string CarModel { get; set; }

        public string ImageUrl { get; set; }

        public string TypeOfCar { get; set; }

        public DateTime ProduceDate { get; set; }
    }
}
