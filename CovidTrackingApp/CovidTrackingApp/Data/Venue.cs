using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidTrackingApp.Data
{
    public partial class Venue
    {
        public int VenueId { get; set; }
        public string VenueName { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string PhoneNumber { get; set; }
        public int Capacity { get; set; }
        public virtual ICollection<Booking> Booking { get; set; }

        public Venue()
        {
            Booking = new HashSet<Booking>();
        }

    }
}
