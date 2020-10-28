using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidTrackingApp.Data
{
    public partial class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ICollection<Booking> Booking { get; set; }

        public User()
        {
            Booking = new HashSet<Booking>();
        }
    }
}
