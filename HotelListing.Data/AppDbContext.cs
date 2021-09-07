using HotelListing.Models;
using HotelListing.Shared.Configuration.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace HotelListing.Data
{
    public class AppDbContext : IdentityDbContext<ApiUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        // Seed data to database
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.ApplyConfiguration(new CountryConfiguration());
            builder.ApplyConfiguration(new HotelConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels {  get; set;}
        
    }
}
