using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidTrackingApp.Data
{
    public class CovidTrackerContext : DbContext
    {
        public CovidTrackerContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source = (LocalDb)\MSSQLLocalDB; Initial Catalog = CovidTracker");
            }
        }

        public DbSet<User> User { get; set; }
        public DbSet<Venue> Venue { get; set; }
        public DbSet<Booking> Booking { get; set; }

    }
}
