using BLM4581Web.Data;
using BLM4581Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BLM4581Web.Pages.Kitaplar
{
    public class DuzenleModel : PageModel
    {
        private readonly KitapDbContext _context;

        public DuzenleModel(KitapDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Kitap DuzenlenenKitap { get; set; } = new();

        public SelectList Kategoriler { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var kitap = await _context.Kitaplar
            .Include(k => k.Kategori)
            .FirstOrDefaultAsync(k => k.Id == id);
            if (kitap == null)
            {
                return NotFound();
            }

            DuzenlenenKitap = kitap;
            await KategorileriDoldurAsync();
            return Page();

        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (!ModelState.IsValid)
            {
                await KategorileriDoldurAsync();
                return Page();
            }

            var kitap = await _context.Kitaplar.FindAsync(id);
            if (kitap == null)
            {
                return NotFound();
            }

            kitap.Ad = DuzenlenenKitap.Ad;
            kitap.Yazar = DuzenlenenKitap.Yazar;
            kitap.BasimYili = DuzenlenenKitap.BasimYili;
            kitap.SayfaSayisi = DuzenlenenKitap.SayfaSayisi;
            kitap.KategoriId = DuzenlenenKitap.KategoriId;
            await _context.SaveChangesAsync();

            TempData["Mesaj"] = $"\"{kitap.Ad}\" güncellendi.";
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
