using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRM.Models;
using RazorPagesCitizenship.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace crm.Pages_Citizenships
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesCitizenship.Data.RazorPagesCitizenshipContext _context;

        public IndexModel(RazorPagesCitizenship.Data.RazorPagesCitizenshipContext context)
        {
            _context = context;
        }

        public IList<Citizenship> Citizenship { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        
        public SelectList Name {get; set;}
        [BindProperty(SupportsGet = true)]
        public string CitizenshipNumber { get; set; }
        
        public async Task OnGetAsync()
        {
            var citizenship = from c in _context.Citizenship select c;
            if (string.IsNullOrEmpty(SearchString))
            {
                citizenship = citizenship.Where(s => s.Name == (SearchString));
            }
            {
                
                Citizenship = await _context.Citizenship.ToListAsync();
            }
        }
    }
}
