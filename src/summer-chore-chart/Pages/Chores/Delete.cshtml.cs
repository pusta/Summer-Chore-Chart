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
    public class DeleteModel : PageModel
    {
        private readonly summer_chore_chart.Models.ApplicationDbContext _context;

        public DeleteModel(summer_chore_chart.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Chorelist = await _context.Chorelist.FindAsync(id);

            if (Chorelist != null)
            {
                _context.Chorelist.Remove(Chorelist);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
