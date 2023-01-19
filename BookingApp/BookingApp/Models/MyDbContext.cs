using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookingApp.Models
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=BookingApplication;Trusted_Connection=True;");
        }

        public DbSet<Room>? Rooms { get; set; }

        //public DbSet<Person> Persons { get; set; }
        public DbSet<Booking>? Bookings { get; set; }

    }
}
