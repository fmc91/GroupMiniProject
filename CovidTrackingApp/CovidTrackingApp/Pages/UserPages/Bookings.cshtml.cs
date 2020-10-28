using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CovidTrackingApp.Data;

namespace CovidTrackingApp.Pages.UserPages
{
    public class SelectModel : PageModel
    {
        private readonly CovidTrackingApp.Data.CovidTrackingContext _context;

        public SelectModel(CovidTrackingApp.Data.CovidTrackingContext context)
        {
            _context = context;
        }

        public IList<Booking> Booking { get; set; }

        public async Task OnGetAsync(int? Userid)
        {
            Booking = await _context.Booking
                .Include(b => b.User)
                .Include(b => b.Venue)
                .Where(b => b.UserId == Userid).ToListAsync();
        }
    }
}
