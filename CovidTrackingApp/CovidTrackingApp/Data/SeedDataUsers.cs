using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CovidTrackingApp;
using System;
using System.Linq;
using CovidTrackingApp.Data;

namespace CovidTrackingApp.Data
{
    public static class SeedDataUsers
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CovidTrackingContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CovidTrackingContext>>()))
            {
                // Look for any movies.
                if (context.User.Any())
                {
                    return;   // DB has been seeded
                }

                context.User.AddRange(
                    new User
                    {
                        FirstName ="Vinay",
                        LastName ="Patel",
                        Email ="vinay.Patel@hotmail.co.uk",
                        DateOfBirth = new DateTime(1996,03,25),
                        Address = "23 New Street",
                        City = "London",
                        Postcode = "SW01 3TZ",
                        PhoneNumber = "07956691463"
                    },

                    new User
                    {
                        FirstName = "Fazal",
                        LastName = "Cheema",
                        Email = "Fazal.Cheema@hotmail.co.uk",
                        DateOfBirth = new DateTime(1994, 07, 07),
                        Address = "23 Computers Avenue",
                        City = "Birmingham",
                        Postcode = "B12 3DT",
                        PhoneNumber = "07966696463"
                    },

                    new User
                    {
                        FirstName = "Sully",
                        LastName = "Miah",
                        Email = "Sully.Miah@hotmail.co.uk",
                        DateOfBirth = new DateTime(1996, 04, 05),
                        Address = "23 Regents Street",
                        City = "Birmginham",
                        Postcode = "BS01 7ZZ",
                        PhoneNumber = "77756691463"
                    },

                    new User
                    {
                        FirstName = "Darren",
                        LastName = "Jordan",
                        Email = "Darren.Jordan@hotmail.co.uk",
                        DateOfBirth = new DateTime(1996, 03, 25),
                        Address = "23 Old Street",
                        City = "Birmingham",
                        Postcode = "BS01 5ZT",
                        PhoneNumber = "07956691461"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
