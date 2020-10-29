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
    public class IndexModel : PageModel
    {
        private readonly CovidTrackingApp.Data.CovidTrackingContext _context;

        public IndexModel(CovidTrackingApp.Data.CovidTrackingContext context)
        {
            _context = context;
        }

        public IList<Booking> Booking { get;set; }

        public async Task OnGetAsync(int? venueId, int? userId)
        {
            if (venueId != null) {
                Booking = await _context.Booking
                .Include(b => b.User)
                .Include(b => b.Venue).Where(x => x.VenueId == venueId).ToListAsync();
            }
            else if (userId != null)
            {
                Booking = await _context.Booking
          .Include(b => b.User)
          .Include(b => b.Venue).Where(x => x.UserId == userId).ToListAsync();
            }
            else 
            { 
            Booking = await _context.Booking
          .Include(b => b.User)
          .Include(b => b.Venue).ToListAsync();
            }
            
        }
    }
}
