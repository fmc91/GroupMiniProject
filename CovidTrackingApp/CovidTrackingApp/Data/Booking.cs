using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CovidTrackingApp.Data
{
    public partial class Booking
    {
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public int VenueId { get; set; }

        [Display(Name = "Arrival Time")]
        public TimeSpan ArrivalTime { get; set; }

        []
        [Display(Name = "Departure Time")]
        public TimeSpan DepartureTime { get; set; }
        [Display(Name = "Booking Date")]
        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }

        public virtual User User { get; set; }
        public virtual Venue Venue { get; set; }


    }
}
