using IntroToASPMVC.Enums;
using IntroToASPMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToASPMVC
{
    public class AspContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<Equipment> Equipment { get; set; }


        public AspContext(DbContextOptions options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Title = "The Matrix",
                    Description = "There is no spoon etc",
                    Rating = 8,
                    YearOfRelease = new DateTime(1999, 1, 1),
                    Genres = Genre.Action
                },
                new Movie
                {
                    Id = 2,
                    Title = "Treasure Planet",
                    Description = "Space surfing with pirates",
                    Rating = 10,
                    YearOfRelease = new DateTime(2002, 1, 1),
                    Genres = Genre.Animation
                },
                new Movie
                {
                    Id = 3,
                    Title = "The Lion King",
                    Description = "Lion family drama",
                    Rating = 9,
                    YearOfRelease = new DateTime(1994, 1, 1),
                    Genres = Genre.Animation
                },
                new Movie
                {
                    Id = 4,
                    Title = "Back to the Future: The actual Future",
                    Description = "Hasn't happened yet so who knows?",
                    Rating = 10,
                    YearOfRelease = new DateTime(2054, 12, 12),
                    Genres = Genre.Horror
                });

            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    Id = 1,
                    FirstName = "Frodo",
                    Name = "Baggins",  
                    ProfilePictureUrl = "http://placeimg.com/200/200/animals",
                    DateOfBirth = new DateTime(1345,12,08),
                    Email = "frodo@baggins.com",
                    TelephoneNumber = 123456789,
                    AddressId = 1,
                    Category = Category.Professional

                },
                new Contact
                {
                    Id = 2,
                    FirstName = "Bilbo",
                    Name = "Baggins", 
                    ProfilePictureUrl = "http://placeimg.com/200/200/animals",
                    DateOfBirth = new DateTime(1305, 04, 17),
                    Email = "bilbo@baggins.com",
                    TelephoneNumber = 321012345,
                    AddressId = 1,
                    Category = Category.Professional
                },
                new Contact
                {
                    Id = 3,
                    FirstName = "Gandalf",
                    Name = "the Grey",                    
                    ProfilePictureUrl = "http://placeimg.com/200/200/animals",
                    DateOfBirth = new DateTime(1178, 03, 02),
                    Email = "gandalf@thewizard.com",
                    TelephoneNumber = 987654321,
                    AddressId = 3,
                    Category = Category.Professional
                });
            modelBuilder.Entity<Address>().HasData(
                new Address
                {
                    Id = 1,
                   
                    Street = "TestLane",
                    City = "The Shire",
                    HouseNumber = 15,
                    PostalCode = 4500,
                    Unit = "A"
                }, 
                new Address
                {
                    Id = 2,
                    
                    Street = "That one room next to the waterfall",
                    City = "Rivendell",
                    HouseNumber = 146,
                    PostalCode = 3500,
                    Unit = "B"
                },
                new Address
                {
                    Id = 3,
                    
                    Street = "7th level",
                    City = "Minas Tirith",
                    HouseNumber = 813,
                    PostalCode = 2500,
                    Unit = "C"
                });
        }

        
    }
}
