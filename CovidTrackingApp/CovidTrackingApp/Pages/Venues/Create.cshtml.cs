using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CovidTrackingApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CovidTrackingApp.Pages.Venues
{
    public class CreateModel : PageModel
    {
        private readonly CovidTrackingContext _db;

        public CreateModel(CovidTrackingContext context)
        {
            _db = context;
        }

        [BindProperty]
        public Venue NewVenue { get; set; }

        public IActionResult OnGet()
        {
            NewVenue = new Venue();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (NewVenue == null)
                return BadRequest();

            _db.Venue.Add(NewVenue);
            await _db.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
