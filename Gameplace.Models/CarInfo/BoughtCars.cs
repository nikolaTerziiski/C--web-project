using CarParadise.Models.UserAndTopics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarParadise.Models.CarInfo
{
    public class BoughtCars
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        public User User { get; set; }

        [Required]
        public int CarId { get; set; }

        public Car Car { get; set; }

        public DateTime BoughtOn { get; set; }

        public decimal Price { get; set; }
    }
}
