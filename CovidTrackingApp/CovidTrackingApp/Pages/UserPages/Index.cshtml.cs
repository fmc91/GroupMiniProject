using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CovidTrackingApp.Data;

namespace CovidTrackingApp.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly CovidTrackingApp.Data.CovidTrackingContext _context;

        public IndexModel(CovidTrackingApp.Data.CovidTrackingContext context)
        {
            _context = context;
        }

        public bool IsViewFiltered { get; set; }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User
                .OrderBy(u => u.LastName)
                .ToListAsync();
        }

        public async Task<IActionResult> OnGetFilterAsync(string name)
        {
            User = await _context.User
                .Where(u => (u.FirstName + ' ' + u.LastName).Contains(name))
                .OrderBy(u => u.LastName)
                .ToListAsync();

            IsViewFiltered = true;

            return Page();
        }
    }
}
