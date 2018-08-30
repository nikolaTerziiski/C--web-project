using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarParadise.Models.CarInfo
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Brand { get; set; }

        [Required]
        [MinLength(2)]
        public string CarModel { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int CarTypeId { get; set; }

        public CarType CarType { get; set; }

        [Required]
        public DateTime ProduceDate { get; set; }
    }
}
