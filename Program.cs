using Microsoft.EntityFrameworkCore;
using RazorPagesCitizenship.Data;
using RazorPagesCitizenship;
using RazorPagesCitizenship.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<RazorPagesCitizenshipContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("RazorPagesCitizenshipContext")));



var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
