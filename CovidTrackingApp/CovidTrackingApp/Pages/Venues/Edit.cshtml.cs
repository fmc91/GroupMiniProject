using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CovidTrackingApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CovidTrackingApp.Pages.Venues
{
    public class EditModel : PageModel
    {
        private CovidTrackingContext _db;

        public EditModel(CovidTrackingContext context)
        {
            _db = context;
        }

        public Venue SelectedVenue { get; set; }

        public async Task<IActionResult> OnGet(int venueId)
        {
            SelectedVenue = await _db.Venue.FindAsync(venueId);

            if (SelectedVenue == null)
                return NotFound();

            else
                return Page();
        }
    }
}
