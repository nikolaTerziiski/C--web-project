using System;
using System.Collections.Generic;
using System.Text;
using CarParadise.Models.CarInfo;
using CarParadise.Models.UserAndTopics;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gameplace.Web.Data
{
    public class CarParadiseContext : IdentityDbContext
    {
        public DbSet<Topic> Topics { get; set; }

        public DbSet<UserTopics> UserTopics { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<CarType> CarTypes { get; set; }
        
        public DbSet<RentCar> RentCars { get; set; }

        public DbSet<UserInstaller> Installers { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<InstallerServices> InstallersToServices { get; set; }

        public CarParadiseContext(DbContextOptions<CarParadiseContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasMany(e => e.WrittenTopics)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId);

            builder.Entity<Service>()
                .HasMany(e => e.Installers)
                .WithOne(e => e.Service)
                .HasForeignKey(e => e.ServiceId);
                

            builder.Entity<UserTopics>()
                .HasKey(x => new { x.UserId, x.TopicId });

            builder.Entity<InstallerServices>()
                .HasKey(x => new { x.UserInstallerId, x.ServiceId});

            base.OnModelCreating(builder);
        }
    }
}
