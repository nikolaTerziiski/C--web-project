using CarParadise.Models.CarInfo;
using CarParadise.Models.UserAndTopics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarParadise.Models.CarInfo
{
    public class RentCar
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        public User User { get; set; }
        [Required]
        public int CarId { get; set; }

        public Car Car { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
    }
}
