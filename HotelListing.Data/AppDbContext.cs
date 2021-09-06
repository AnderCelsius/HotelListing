using HotelListing.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace HotelListing.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Jamaica",
                    ShortName = "JM"
                },
                new Country
                {
                    Id = 2,
                    Name = "Bahamas",
                    ShortName = "BS"
                },
                new Country
                {
                    Id = 3,
                    Name = "Cayman Island",
                    ShortName = "CI"
                }
           );

            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals Resort and Spa",
                    Address = "Negril",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "The Royal at Atlantis",
                    Address = " Paradise Island",
                    CountryId = 2,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 3,
                    Name = "The Ritz-Carlton, Grand Cayman",
                    Address = "Seven Mile Beach",
                    CountryId = 3,
                    Rating = 4.8
                }
           );
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels {  get; set;}
        
    }
}
