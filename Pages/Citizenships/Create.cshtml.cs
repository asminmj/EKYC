using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CRM.Models;
using RazorPagesCitizenship.Data;

namespace crm.Pages_Citizenships
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesCitizenship.Data.RazorPagesCitizenshipContext _context;

        public CreateModel(RazorPagesCitizenship.Data.RazorPagesCitizenshipContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Citizenship Citizenship { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Citizenship == null || Citizenship == null)
            {
                return Page();
            }

            _context.Citizenship.Add(Citizenship);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
