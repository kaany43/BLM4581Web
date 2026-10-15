using BLM4581Web.Data;
using BLM4581Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BLM4581Web.Pages.Kitaplar
{
    public class DetayModel : PageModel
    {
        private readonly KitapDbContext _context;

        public DetayModel(KitapDbContext context)
        {
            _context = context;
        }

        public Kitap SeciliKitap { get; set; } = new();

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var kitap = await _context.Kitaplar
                .Include(k => k.Kategori)
                .FirstOrDefaultAsync(k => k.Id == id);

            if (kitap == null)
            {
                return NotFound();
            }

            SeciliKitap = kitap;
            return Page();
        }
    }
}
