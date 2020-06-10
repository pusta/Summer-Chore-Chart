using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using summer_chore_chart.Models;

namespace summer_chore_chart.Pages.Children
{
    public class DeleteModel : PageModel
    {
        private readonly summer_chore_chart.Models.ApplicationDbContext _context;

        public DeleteModel(summer_chore_chart.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Child Child { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Child = await _context.Child.FirstOrDefaultAsync(m => m.Id == id);

            if (Child == null)
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

            Child = await _context.Child.FindAsync(id);

            if (Child != null)
            {
                _context.Child.Remove(Child);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
