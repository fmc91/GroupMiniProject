using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CovidTrackingApp;
using System;
using System.Linq;
using CovidTrackingApp.Data;
using System.Security.Cryptography;

namespace CovidTrackingApp.Data
{
    public static class SeedDataBookings
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CovidTrackingContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CovidTrackingContext>>()))
            {
                // Look for any movies.
                if (context.Booking.Any())
                {
                    return;   // DB has been seeded
                }

                context.Booking.AddRange(
                    new Booking
                    {
                        UserId = 1,
                        VenueId = 1,
                        ArrivalTime = new TimeSpan(11,30,00),
                        DepartureTime = new TimeSpan(14,00,00),
                        BookingDate = new DateTime(2020,10,28)
                    },
                    new Booking
                    {
                        UserId = 1,
                        VenueId = 2,
                        ArrivalTime = new TimeSpan(15, 30, 00),
                        DepartureTime = new TimeSpan(18, 00, 00),
                        BookingDate = new DateTime(2020, 10, 28)
                    },
                    new Booking
                    {
                        UserId = 2,
                        VenueId = 3,
                        ArrivalTime = new TimeSpan(11, 30, 00),
                        DepartureTime = new TimeSpan(16, 00, 00),
                        BookingDate = new DateTime(2020, 10, 29)
                    },
                    new Booking
                    {
                        UserId = 3,
                        VenueId = 4,
                        ArrivalTime = new TimeSpan(11, 30, 00),
                        DepartureTime = new TimeSpan(16, 00, 00),
                        BookingDate = new DateTime(2020, 10, 29)
                    },
                    new Booking
                    {
                        UserId = 3,
                        VenueId = 3,
                        ArrivalTime = new TimeSpan(13, 30, 00),
                        DepartureTime = new TimeSpan(15, 00, 00),
                        BookingDate = new DateTime(2020, 10, 29)
                    },
                    new Booking
                    {
                        UserId = 4,
                        VenueId = 1,
                        ArrivalTime = new TimeSpan(16, 30, 00),
                        DepartureTime = new TimeSpan(19, 00, 00),
                        BookingDate = new DateTime(2020, 10, 29)
                    },
                    new Booking
                    {
                        UserId = 4,
                        VenueId = 4,
                        ArrivalTime = new TimeSpan(9, 30, 00),
                        DepartureTime = new TimeSpan(10, 00, 00),
                        BookingDate = new DateTime(2020, 10, 27)
                    }


                );
                context.SaveChanges();
            }
        }
    }
}
