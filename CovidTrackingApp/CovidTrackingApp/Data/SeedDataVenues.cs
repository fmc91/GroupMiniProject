using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CovidTrackingApp;
using System;
using System.Linq;
using CovidTrackingApp.Data;

namespace CovidTrackingApp.Data
{
    public static class SeedDataVenues
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CovidTrackingContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CovidTrackingContext>>()))
            {
                // Look for any movies.
                if (context.Venue.Any())
                {
                    return;   // DB has been seeded
                }

                context.Venue.AddRange(
                    new Venue
                    {
                        VenueName = "The Ship",
                        Website = "theship.co.uk",
                        Address = "41 Jews Row",
                        City = "London",
                        Postcode = "SW18 1TB",
                        PhoneNumber = "+442088709667",
                        Capacity = 50,
                    },

                    new Venue
                    {
                        VenueName = "The Anchor",
                        Website = "theAnchor.co.uk",
                        Address = "61 Holgate Ave",
                        City = "London",
                        Postcode = "SW11 2AT",
                        PhoneNumber = "+442079787383",
                        Capacity = 40,
                    },

                    new Venue
                    {
                        VenueName = "The Waterside",
                        Website = "watersideimperialwharf.co.uk",
                        Address = "Imperial Wharf, The Blvd",
                        City = "London",
                        Postcode = "SW6 2SU",
                        PhoneNumber = "+442088709667",
                        Capacity = 55,
                    },

                    new Venue
                    {
                        VenueName = "The King's Arms Wandsworth",
                        Website = "www.kingsarmswandsworth.co.uk",
                        Address = "94-96 Wandsworth High St",
                        City = "London",
                        Postcode = "SW18 4LB",
                        PhoneNumber = "+442034370006",
                        Capacity = 50,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
