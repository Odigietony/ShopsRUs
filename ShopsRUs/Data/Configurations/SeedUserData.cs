using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopsRUs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Data.Configurations
{
    public class SeedUserData : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.HasData
            (
                new Users
                {
                    UserId = 1,
                    FirstName = "Sheldon",
                    MiddleName = "Lee",
                    LastName = "Cooper",
                    Email = "user1@email.com",
                    PhoneNumber = "123456789",
                    UserType = "Customer",
                    DateCreated = DateTime.Now.AddYears(-3)
                },
                new Users
                {
                    UserId = 2,
                    FirstName = "Leonard",
                    MiddleName = "Lee",
                    LastName = "Hoffsteder",
                    Email = "user2@email.com",
                    PhoneNumber = "12345678910",
                    UserType = "Customer",
                    DateCreated = DateTime.Now.AddMonths(-3)
                },
                new Users
                {
                    UserId = 3,
                    FirstName = "Penny",
                    MiddleName = "L.",
                    LastName = "Jackson",
                    Email = "user3@email.com",
                    PhoneNumber = "123456789",
                    UserType = "Affiliate",
                    DateCreated = DateTime.Now.AddYears(-1)
                },
                new Users
                {
                    UserId = 4,
                    FirstName = "Amy", 
                    LastName = "Fowler",
                    Email = "user4@email.com",
                    PhoneNumber = "123456789",
                    UserType = "Employee",
                    DateCreated = DateTime.Now.AddYears(-5)
                },
                new Users
                {
                    UserId = 5,
                    FirstName = "Raj", 
                    LastName = "Koothrappali",
                    Email = "user5@email.com",
                    PhoneNumber = "123456789",
                    UserType = "Employee",
                    DateCreated = DateTime.Now.AddYears(-3)
                }
            );
        }
    }
}
