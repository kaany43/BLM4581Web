using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace BLM4581Web.Pages
{
    public class SelamModel : PageModel
    {
        public string Selamlama { get; set; } = "";
        public string Tarih { get; set; } = "";
        public bool HaftaSonu { get; set; }
        public int KalanGun { get; set; }
        public string? Ad { get; set; }

        public void OnGet(string? ad)
        {
            Ad = ad;
            DateTime simdi = DateTime.Now;

            if (simdi.Hour < 12)
                Selamlama = "Günaydın";
            else if (simdi.Hour < 18)
                Selamlama = "İyi günler";
            else
                Selamlama = "İyi akşamlar";

            Tarih = simdi.ToString("dd MMMM yyyy, dddd",
                                   new CultureInfo("tr-TR"));

            HaftaSonu = simdi.DayOfWeek == DayOfWeek.Saturday
                     || simdi.DayOfWeek == DayOfWeek.Sunday;
            KalanGun = DayOfWeek.Saturday - simdi.DayOfWeek;

        }
    }
}
