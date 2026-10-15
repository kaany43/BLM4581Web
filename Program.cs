using BLM4581Web.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Servisler Build() öncesinde eklenmeli.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<KitapDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("KitapDb")
    )
);

var app = builder.Build();

// Middleware ve endpoint yapılandırması
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages().WithStaticAssets();

app.Run();