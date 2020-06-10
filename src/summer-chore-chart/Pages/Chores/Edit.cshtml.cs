using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using summer_chore_chart.Models;

namespace summer_chore_chart.Pages.Chores
{
    public class EditModel : PageModel
    {
        private readonly summer_chore_chart.Models.ApplicationDbContext _context;

        public EditModel(summer_chore_chart.Models.ApplicationDbContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Chorelist).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChorelistExists(Chorelist.Id))
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

        private bool ChorelistExists(int id)
        {
            return _context.Chorelist.Any(e => e.Id == id);
        }
    }
}
