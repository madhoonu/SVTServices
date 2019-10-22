using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using SVTService.Module;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace SVTService.DBContext
{
    public class SVTServiceDBContext : DbContext
    {
        public SVTServiceDBContext(DbContextOptions<SVTServiceDBContext> options) : base(options)
        {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["SVTServiceDB"].ConnectionString);
        //}
        public DbSet<SVService> SVServices { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<SVService>().HasData(
        //        new SVService
        //        {
        //            ServiceID = 1,
        //            ServiceName = "Electronics",
        //            ServiceDate = DateTime.Now,
        //            ServicePrice = 1000,
        //            Description = "Electronic Items",
        //        },
        //        new SVService
        //        {
        //            ServiceID = 2,
        //            ServiceName = "Clothes",
        //            ServiceDate = DateTime.Now,
        //            ServicePrice = 100,
        //            Description = "Dresses",
        //        },
        //        new SVService
        //        {
        //            ServiceID = 3,
        //            ServiceName = "Grocery",
        //            ServiceDate = DateTime.Now,
        //            ServicePrice = 500,
        //            Description = "Grocery Items",
        //        });
        //}
    }
}
