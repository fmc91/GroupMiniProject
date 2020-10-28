using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CovidTrackingApp.Data;

namespace CovidTrackingApp.Pages.Check_In
{
    public class CreateModel : PageModel
    {
        private readonly CovidTrackingApp.Data.CovidTrackingContext _context;

        public CreateModel(CovidTrackingApp.Data.CovidTrackingContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int? id)
        {
        ViewData["UserId"] = new SelectList(_context.User.Where(u=>u.UserId == id), "UserId", "UserId");
        ViewData["VenueName"] = new SelectList(_context.Venue, "VenueName", "VenueName");
            return Page();
        }

        [BindProperty]
        public Booking Booking { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Booking.Add(Booking);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
