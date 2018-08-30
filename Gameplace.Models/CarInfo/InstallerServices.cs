using CarParadise.Models.UserAndTopics;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarParadise.Models.CarInfo
{
    public class InstallerServices
    {
        public int UserInstallerId { get; set; }

        public UserInstaller  UserInstaller { get; set; }
        
        public int ServiceId { get; set; }

        public Service Service { get; set; }
    }
}
