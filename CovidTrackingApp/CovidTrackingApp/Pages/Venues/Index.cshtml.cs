using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CovidTrackingApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CovidTrackingApp.Pages.Venues
{
    public class IndexModel : PageModel
    {
        private readonly CovidTrackingContext _db;

        public IndexModel(CovidTrackingContext context)
        {
            _db = context;
        }

        public List<Venue> Venues { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Venues = await _db.Venue
                .OrderBy(v => v.VenueName)
                .ToListAsync();

            return Page();
        }

        public async Task<IActionResult> OnGetFilterAsync(string venueName)
        {
            Venues = await _db.Venue
                .Where(v => v.VenueName.Contains(venueName))
                .OrderBy(v => v.VenueName)
                .ToListAsync();

            return Page();
        }
    }
}
