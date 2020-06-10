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
    public class IndexModel : PageModel
    {
        private readonly summer_chore_chart.Models.ApplicationDbContext _context;

        public IndexModel(summer_chore_chart.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Chorelist> Chorelist { get;set; }

        public async Task OnGetAsync()
        {
            Chorelist = await _context.Chorelist.ToListAsync();
        }
    }
}
