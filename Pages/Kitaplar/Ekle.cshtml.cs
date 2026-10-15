
using BLM4581Web.Data;
using BLM4581Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore; // <- EKLENDİ

namespace BLM4581Web.Pages.Kitaplar
{
    public class EkleModel : PageModel
    {
        private readonly KitapDbContext _context;

        public EkleModel(KitapDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Kitap YeniKitap { get; set; } = new();

        public SelectList Kategoriler { get; set; } = default!;

        public async Task OnGetAsync()
        {
            await KategorileriDoldurAsync();
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                await KategorileriDoldurAsync();
                return Page();
            }

            _context.Kitaplar.Add(YeniKitap);
            await _context.SaveChangesAsync();

            TempData["Mesaj"] = $"\"{YeniKitap.Ad}\" eklendi.";
            return RedirectToPage("Index");
        }

        private async Task KategorileriDoldurAsync()
        {
            var kategoriler = await _context.Kategoriler
                .OrderBy(k => k.Ad)
                .ToListAsync();
            Kategoriler = new SelectList(kategoriler, "Id", "Ad");
        }
    }
}
