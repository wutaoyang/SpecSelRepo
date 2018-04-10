using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SpecSelRepo.Models;

namespace SpecSelRepo.Pages.SpecSelResults
{
    public class IndexModel : PageModel
    {
        private readonly SpecSelRepo.Models.SpecSelResultContext _context;

        public IndexModel(SpecSelRepo.Models.SpecSelResultContext context)
        {
            _context = context;
        }

        public IList<SpecSelResult> SpecSelResult { get;set; }

        //public async Task OnGetAsync()
        //{
        //    SpecSelResult = await _context.SpecSelResult.ToListAsync();
        //}


        /// <summary>
        /// Add search capability to the index page
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns></returns>
        public async Task OnGetAsync(string searchString)
        {
            var specSelResults = from m in _context.SpecSelResult
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                specSelResults = specSelResults.Where(s => s.DataSet.Contains(searchString));
            }

            SpecSelResult = await specSelResults.ToListAsync();
        }
    }
}
