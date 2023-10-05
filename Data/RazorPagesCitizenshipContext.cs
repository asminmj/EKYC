using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRM.Models;

namespace RazorPagesCitizenship.Data
{
    public class RazorPagesCitizenshipContext : DbContext
    {
        public RazorPagesCitizenshipContext (DbContextOptions<RazorPagesCitizenshipContext> options)
            : base(options)
        {
        }

        public DbSet<CRM.Models.Citizenship> Citizenship { get; set; } = default!;
    }
}
