
using BLM4581Web.Data;
using BLM4581Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BLM4581Web.Pages.Kitaplar
{
    public class SilModel : PageModel
    {
        private readonly KitapDbContext _context;

        public SilModel(KitapDbContext context)
        {
            _context = context;
        }

        public Kitap SeciliKitap { get; set; } = new();

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var kitap = await _context.Kitaplar.FindAsync(id);
            if (kitap == null)
            {
                return NotFound();
            }

            SeciliKitap = kitap;
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int id)
        {
            var kitap = await _context.Kitaplar.FindAsync(id);
            if (kitap == null)
            {
                return NotFound();
            }

            _context.Kitaplar.Remove(kitap);
            await _context.SaveChangesAsync();

            TempData["Mesaj"] = $"\"{kitap.Ad}\" silindi.";
            return RedirectToPage("Index");
        }


    }
}
