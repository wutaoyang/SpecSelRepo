using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SpecSelRepo.Models;

namespace SpecSelRepo.Pages.SpecSelResults
{
    public class CreateModel : PageModel
    {
        private readonly SpecSelRepo.Models.SpecSelResultContext _context;

        public CreateModel(SpecSelRepo.Models.SpecSelResultContext context)
        {
            _context = context;
        }

        /// <summary>
        /// The OnGet method initializes any state needed for the page. The Create page doesn't 
        /// have any state to initialize. The Page method creates a PageResult object that renders 
        /// the Create.cshtml page.
        /// </summary>
        /// <returns></returns>
        public IActionResult OnGet()
        {
            return Page();
        }

        /// <summary>
        /// The SpecSelResult property uses the [BindProperty] attribute to opt-in to model binding. 
        /// When the Create form posts the form values, the ASP.NET Core runtime binds the posted 
        /// values to the SpecSelResult model.
        /// </summary>
        [BindProperty]
        public SpecSelResult SpecSelResult { get; set; }

        /// <summary>
        /// The OnPostAsync method is run when the page posts form data.
        /// If there are any model errors, the form is redisplayed, along with any form data posted.
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.SpecSelResult.Add(SpecSelResult);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}