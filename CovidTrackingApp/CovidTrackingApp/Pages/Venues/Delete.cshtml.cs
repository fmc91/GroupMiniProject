using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CovidTrackingApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Razor.Language.Extensions;

namespace CovidTrackingApp.Pages.Venues
{
    public class DeleteModel : PageModel
    {
        private CovidTrackingContext _db;

        public DeleteModel(CovidTrackingContext context)
        {
            _db = context;
        }

        public Venue SelectedVenue { get; set; }

        public async Task<IActionResult> OnGet(int venueId)
        {
            SelectedVenue = await _db.Venue.FindAsync(venueId);

            if (SelectedVenue == null)
                return NotFound();

            return Page();
        }

        public async Task<IActionResult> OnPost(int venueId)
        {
            Venue venue = _db.Venue.Find(venueId);

            if (venue == null)
                return NotFound();

            _db.Venue.Remove(venue);
            await _db.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
