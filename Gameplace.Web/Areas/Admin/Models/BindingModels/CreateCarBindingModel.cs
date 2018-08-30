using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarParadise.Web.Areas.Admin.Models.BindingModels
{
    public class CreateCarBindingModel
    {
        [Required]
        [MinLength(3)]
        public string Brand { get; set; }
        
        [Required]
        [MinLength(2)]
        public string CarModel { get; set; }
        
        [Required]
        [DataType(DataType.Url)]
        public string ImageUrl { get; set; }

        [Required]
        [MinLength(5)]
        public string TypeOfCar { get; set; }
    }
}
