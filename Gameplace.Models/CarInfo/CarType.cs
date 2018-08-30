using System.ComponentModel.DataAnnotations;

namespace CarParadise.Models.CarInfo
{
    public class CarType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }
    }
}