using System;
using System.Collections.Generic;
using System.Text;

namespace Gameplace.MyModels.ViewModels
{
    public class UserCarConsiceViewModel
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string CarModel { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }
    }
}
