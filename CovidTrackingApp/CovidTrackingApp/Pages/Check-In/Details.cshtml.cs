using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CovidTrackingApp.Data;

namespace CovidTrackingApp.Pages.Check_In
{
    public class DetailsModel : PageModel
    {
        private readonly CovidTrackingApp.Data.CovidTrackingContext _context;

        public DetailsModel(CovidTrackingApp.Data.CovidTrackingContext context)
        {
            _context = context;
        }

        public Booking Booking { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Booking = await _context.Booking
                .Include(b => b.User)
                .Include(b => b.Venue).FirstOrDefaultAsync(m => m.BookingId == id);

            if (Booking == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
