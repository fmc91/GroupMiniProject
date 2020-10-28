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

        public async Task OnGetAsync(int Id)
        {

            Booking = await _context.Booking
                .Include(b => b.User)
                .Include(b => b.Venue).Where(x => x.VenueId == Id).ToListAsync();
        }
    }
}
