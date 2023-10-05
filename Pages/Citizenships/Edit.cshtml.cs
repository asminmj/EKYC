using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CRM.Models;
using RazorPagesCitizenship.Data;

namespace crm.Pages_Citizenships
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesCitizenship.Data.RazorPagesCitizenshipContext _context;

        public EditModel(RazorPagesCitizenship.Data.RazorPagesCitizenshipContext context)
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

            var citizenship =  await _context.Citizenship.FirstOrDefaultAsync(m => m.ID == id);
            if (citizenship == null)
            {
                return NotFound();
            }
            Citizenship = citizenship;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Citizenship).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CitizenshipExists(Citizenship.ID))
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

        private bool CitizenshipExists(int id)
        {
          return (_context.Citizenship?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
