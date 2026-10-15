using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BLM4581Web.Pages
{
    public class DersBilgiModel : PageModel
    {
        public string DersAdi { get; set; } = "";
        public string DersKodu { get; set; } = "";
        public string Donem { get; set; } = "";
        public List<string> Konular { get; set; } = new();

        public void OnGet()
        {
            DersKodu = "BLM4581";
            DersAdi = "Ağ Tabanlı Teknolojiler ve Uygulamaları";
            Donem = "2026-2027 Güz";
            Konular = new List<string> 
            {
                "ASP.NET Core ve Razor Pages",
                "Formlar ve veri alma",
                "Veritabanı işlemleri (EF Core)",
                "MVC mimarisi",
                "Kullanıcı girişi ve yetkilendirme"
            };
        }
    }

}