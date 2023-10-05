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
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesCitizenship.Data.RazorPagesCitizenshipContext _context;

        public DeleteModel(RazorPagesCitizenship.Data.RazorPagesCitizenshipContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Citizenship == null)
            {
                return NotFound();
            }
            var citizenship = await _context.Citizenship.FindAsync(id);

            if (citizenship != null)
            {
                Citizenship = citizenship;
                _context.Citizenship.Remove(Citizenship);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
