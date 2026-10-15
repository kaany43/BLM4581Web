using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace BLM4581Web.Pages
{
    public class NotHesaplaModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Öğrenci adı zorunludur.")]
        [Display(Name = "Öğrenci Adı")]
        public string OgrenciAdi { get; set; } = "";

        [BindProperty]
        [Required(ErrorMessage = "Vize notu zorunludur.")]
        [Range(0, 100, ErrorMessage = "Vize 0 ile 100 arasında olmalıdır.")]
        [Display(Name = "Vize (%40)")]
        public int? Vize { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Final notu zorunludur.")]
        [Range(0, 100, ErrorMessage = "Final 0 ile 100 arasında olmalıdır.")]
        [Display(Name = "Final (%60)")]
        public int? Final { get; set; }

        public double Ortalama { get; set; }
        public string HarfNotu { get; set; } = "";
        public bool Gecti { get; set; }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Ortalama = (Vize ?? 0) * 0.4 + (Final ?? 0) * 0.6;

            if (Ortalama >= 90) HarfNotu = "AA";
            else if (Ortalama >= 80) HarfNotu = "BA";
            else if (Ortalama >= 70) HarfNotu = "BB";
            else if (Ortalama >= 60) HarfNotu = "CB";
            else if (Ortalama >= 50) HarfNotu = "CC";
            else HarfNotu = "FF";

            Gecti = Ortalama >= 50;
            return Page();
        }
    }
}
