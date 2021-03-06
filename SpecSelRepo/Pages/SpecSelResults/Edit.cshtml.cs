using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SpecSelRepo.Models;

namespace SpecSelRepo.Pages.SpecSelResults
{
    public class EditModel : PageModel
    {
        private readonly SpecSelRepo.Models.SpecSelResultContext _context;

        public EditModel(SpecSelRepo.Models.SpecSelResultContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SpecSelResult SpecSelResult { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SpecSelResult = await _context.SpecSelResult.SingleOrDefaultAsync(m => m.ID == id);

            if (SpecSelResult == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(SpecSelResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!SpecSelResultExists(SpecSelResult.ID))
                if (!_context.SpecSelResult.Any(e => e.ID == SpecSelResult.ID))
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

        private bool SpecSelResultExists(int id)
        {
            return _context.SpecSelResult.Any(e => e.ID == id);
        }
    }
}
