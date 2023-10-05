using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRM.Models;
using RazorPagesCitizenship.Data;

namespace crm.Pages_Citizenships
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesCitizenship.Data.RazorPagesCitizenshipContext _context;

        public DetailsModel(RazorPagesCitizenship.Data.RazorPagesCitizenshipContext context)
        {
            _context = context;
        }

      public Citizenship Citizenship { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Citizenship == null)
            {
                return NotFound();
            }

            var citizenship = await _context.Citizenship.FirstOrDefaultAsync(m => m.ID == id);
            if (citizenship == null)
            {
                return NotFound();
            }
            else 
            {
                Citizenship = citizenship;
            }
            return Page();
        }
    }
}
