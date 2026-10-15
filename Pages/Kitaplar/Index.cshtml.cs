
using BLM4581Web.Data;
using BLM4581Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BLM4581Web.Pages.Kitaplar
{
    public class IndexModel : PageModel
    {
        private readonly KitapDbContext _context;

        public IndexModel(KitapDbContext context)
        {
            _context = context;
        }

        public List<Kitap> Kitaplar { get; set; } = new();
        public SelectList Kategoriler { get; set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? Arama { get; set; }

        [BindProperty(SupportsGet = true)]
        public int? KategoriId { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? Siralama { get; set; }


        public async Task OnGetAsync()
        {
            IQueryable<Kitap> sorgu = _context.Kitaplar.Include(k => k.Kategori);

            if (!string.IsNullOrEmpty(Arama))
            {
                sorgu = sorgu.Where(k => k.Ad.Contains(Arama)
                                      || k.Yazar.Contains(Arama));
            }

            if (KategoriId != null)
            {
                sorgu = sorgu.Where(k => k.KategoriId == KategoriId);
            }
            if (Siralama == "yil")
            {
                sorgu = sorgu.OrderBy(k => k.BasimYili);
            }
            else
            {
                sorgu = sorgu.OrderBy(k => k.Ad);
            }

            Kitaplar = await sorgu.ToListAsync();

            var kategoriler = await _context.Kategoriler
                .OrderBy(k => k.Ad)
                .ToListAsync();
            Kategoriler = new SelectList(kategoriler, "Id", "Ad");
        }

    }

}

