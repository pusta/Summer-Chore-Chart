using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using summer_chore_chart.Models;

namespace summer_chore_chart.Pages.Children
{
    public class CreateModel : PageModel
    {
        private readonly summer_chore_chart.Models.ApplicationDbContext _context;

        public CreateModel(summer_chore_chart.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Child Child { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Child.Add(Child);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
