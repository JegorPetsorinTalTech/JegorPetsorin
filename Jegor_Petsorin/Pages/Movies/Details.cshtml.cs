using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Jegor_Petsorin.Data;
using Jegor_Petsorin.Models;

namespace Jegor_Petsorin
{
    public class DetailsModel : PageModel
    {
        private readonly Jegor_Petsorin.Data.Jegor_PetsorinContext _context;

        public DetailsModel(Jegor_Petsorin.Data.Jegor_PetsorinContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
