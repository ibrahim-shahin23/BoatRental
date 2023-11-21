using BoatRental.core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.ef
{
    public class ApplicationDbContext:DbContext
        {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleService>()
                .HasKey(e => new { e.ServiceId, e.vechicleId });
            modelBuilder.Entity<ServicePackage>()
                .HasKey(e => new { e.serviceId, e.packageId });
        }

        public DbSet<Vehicle> vehicles { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<VehicleService> vehicleServices { get; set; }
        public DbSet<Service>services { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Staff> staffs { get; set; }
        public DbSet<Reservation>reservations { get; set; }
        public DbSet<Package> packages { get; set; }
        public DbSet<Owner> owners { get; set; }
        public DbSet<Offer> offers { get; set; }
    }
}
