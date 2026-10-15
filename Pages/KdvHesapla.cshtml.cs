using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BLM4581Web.Pages
{
    public class KdvHesaplaModel : PageModel
    {
        [BindProperty]
        public decimal Tutar { get; set; }

        [BindProperty]
        public int KdvOrani { get; set; } = 20;

        public decimal KdvTutari { get; set; }
        public decimal Toplam { get; set; }
        public bool Hesaplandi { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            KdvTutari = Tutar * KdvOrani / 100;
            Toplam = Tutar + KdvTutari;
            Hesaplandi = true;
        }
    }

}
