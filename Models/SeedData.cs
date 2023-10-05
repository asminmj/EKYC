using CRM.Models;
using Microsoft.EntityFrameworkCore;
using RazorPagesCitizenship.Data;

namespace RazorPagesCitizenship.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RazorPagesCitizenshipContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesCitizenshipContext>>()))
        {
            if (context == null || context.Citizenship == null)
            {
                throw new ArgumentNullException("Null RazorPagesCitizenshipContext");
            }

            // Look for any movies.
            if (context.Citizenship.Any())
            {
                return;   // DB has been seeded
            }

            context.Citizenship.AddRange(
                new CRM.Models.Citizenship
                {
                    Name = "Ram",
                    Birthplace = "kathmandu",
                    District = "Kathmadu",
                    Ward = 1,
                    Birthdate = DateTime.Parse("1989-2-12"),
                    FatherName = "Romantic Comedy",
                    Address = "sita-street",
                    CitizenshipNumber =12,
                    PermanentAddrress ="sita-street",
                    Gender ="Male",
                    CitizenshipRegisterDate =DateTime.Parse("1989-2-12"),
                },

                new CRM.Models.Citizenship
                {
                    Name = "Sam",
                    Birthplace = "kathmandu",
                    District = "Kathmadu",
                    Ward = 2,
                    Birthdate = DateTime.Parse("1984-3-13"),
                    FatherName = "Comedy",
                    Address = "sita-street",
                    CitizenshipNumber =124,
                    PermanentAddrress ="sita-street",
                    Gender ="Male",
                    CitizenshipRegisterDate =DateTime.Parse("1989-2-12"),
                },

                new Citizenship
                {
                    Name = "hari",
                    Birthplace = "kathmandu",
                    District = "Kathmadu",
                    Ward = 3,
                    Birthdate = DateTime.Parse("1986-2-23"),
                    FatherName = "Comedy",
                    Address = "sita-street",
                    CitizenshipNumber =125,
                    PermanentAddrress ="sita-street",
                    Gender ="Male",
                    CitizenshipRegisterDate =DateTime.Parse("1989-2-12"),
                },

                new Citizenship
                {
                    Name = "gita",
                    Birthplace = "kathmandu",
                    District = "Kathmadu",
                    Ward = 4,
                    Birthdate = DateTime.Parse("1959-4-15"),
                    FatherName= "Western",
                    Address = "sita-street",
                    CitizenshipNumber =159,
                    PermanentAddrress ="sita-street",
                    Gender ="Female",
                    CitizenshipRegisterDate =DateTime.Parse("1989-2-12"),
                }
            );
            context.SaveChanges();
        }
    }
}