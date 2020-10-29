using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CovidTrackingApp.Data
{
    public partial class Venue
    {
        public Venue()
        {
            Booking = new HashSet<Booking>();
        }

        [Display(Name = "Venue ID")]
        public int VenueId { get; set; }

        [Required]
        [Display(Name = "Venue Name")]
        public string VenueName { get; set; }

        [Range(1, Int32.MaxValue)]
        public int Capacity { get; set; }

        [DataType(DataType.Url)]
        public string Website { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z]{1,2}[0-9]([A-Za-z]|[0-9])? ?[0-9][A-Za-z]{2}$", ErrorMessage = "Invalid postcode")]
        public string Postcode { get; set; }

        [Display(Name = "Telephone")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public virtual ICollection<Booking> Booking { get; set; }
    }
}
