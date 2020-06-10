using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using summer_chore_chart.Models;

namespace summer_chore_chart.Pages.Children
{
    public class EditModel : PageModel
    {
        private readonly summer_chore_chart.Models.ApplicationDbContext _context;

        public EditModel(summer_chore_chart.Models.ApplicationDbContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Child).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChildExists(Child.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ChildExists(int id)
        {
            return _context.Child.Any(e => e.Id == id);
        }
    }
}
