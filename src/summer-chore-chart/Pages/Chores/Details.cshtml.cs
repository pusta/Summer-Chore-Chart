using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using summer_chore_chart.Models;

namespace summer_chore_chart.Pages.Chores
{
    public class DetailsModel : PageModel
    {
        private readonly summer_chore_chart.Models.ApplicationDbContext _context;

        public DetailsModel(summer_chore_chart.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public Chorelist Chorelist { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Chorelist = await _context.Chorelist.FirstOrDefaultAsync(m => m.Id == id);

            if (Chorelist == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
