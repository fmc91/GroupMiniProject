using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CovidTrackingApp.Data
{
    public partial class User
    {
        public int UserId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Email { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        public virtual ICollection<Booking> Booking { get; set; }

        public User()
        {
            Booking = new HashSet<Booking>();
        }
    }
}
