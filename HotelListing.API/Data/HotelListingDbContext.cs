﻿//contract between database and program

using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext:DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        //create entities and class, add to database
        //add tables 
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // how to enter the data
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Jamaica",
                    ShortName="JM"
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
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id= 1,
                    Name="Sandals Resort and Spa",
                    Address="Negril",
                    CountryId=1,
                    Rating=4.5
                },
                 new Hotel
                 {
                     Id = 2,
                     Name = "Comfort Suits",
                     Address = "George Town",
                     CountryId = 3,
                     Rating = 4.3
                 },
                  new Hotel
                  {
                      Id = 3,
                      Name = "Grand Palldium",
                      Address = "Nassua",
                      CountryId = 2,
                      Rating = 4
                  }
               );
        }
    }
}
