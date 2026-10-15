
using BLM4581Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BLM4581Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly KitapDbContext _context;

        public IndexModel(KitapDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return RedirectToPage("/Kitaplar/Index");
        }
    }
}
