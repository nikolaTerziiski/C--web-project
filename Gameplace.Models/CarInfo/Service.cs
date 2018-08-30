using CarParadise.Models.UserAndTopics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarParadise.Models.CarInfo
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        public int InstallersCount { get; set; }

        [Required]
        public string Address { get; set; }

        public ICollection<InstallerServices> Installers { get; set; }
    }
}
