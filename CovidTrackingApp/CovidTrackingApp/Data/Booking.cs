using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidTrackingApp.Data
{
    public partial class Booking
    {
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public int VenueId { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public TimeSpan DepartureTime { get; set; }
        public DateTime BookingDate { get; set; }

        public virtual User User { get; set; }
        public virtual Venue Venue { get; set; }


    }
}
