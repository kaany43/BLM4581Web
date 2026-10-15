using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace BLM4581Web.Pages
{
    public class OgrenciKayitModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Ad soyad zorunludur.")]
        [StringLength(50, MinimumLength = 3,
            ErrorMessage = "Ad soyad 3-50 karakter olmalıdır.")]
        [Display(Name = "Ad Soyad")]
        public string AdSoyad { get; set; } = "";

        [BindProperty]
        [Required(ErrorMessage = "Öğrenci numarası zorunludur.")]
        [RegularExpression(@"^\d{8}$",
            ErrorMessage = "Öğrenci numarası 8 haneli olmalıdır.")]
        [Display(Name = "Öğrenci No")]
        public string OgrenciNo { get; set; } = "";

        [BindProperty]
        [Required(ErrorMessage = "E-posta zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi girin.")]
        [Display(Name = "E-posta")]
        public string Eposta { get; set; } = "";
        [BindProperty]
        [Required(ErrorMessage = "Yaş zorunludur.")]
        [Range(17, 99, ErrorMessage = "Yaş 17 ile 99 arasında olmalıdır.")]
        [Display(Name = "Yaş")]
        public int? Yas { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Bölüm seçiniz.")]
        [Display(Name = "Bölüm")]
        public string Bolum { get; set; } = "";

        public SelectList Bolumler { get; set; } = default!;
        public bool Kaydedildi { get; set; }
        public void OnGet()
        {
            BolumleriDoldur();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid && !Eposta.EndsWith("ogrenci.ankara.edu.tr"))
            {
                ModelState.AddModelError("Eposta",
                    "Üniversite e-postanızı (…ogrenci.ankara.edu.tr) kullanın.");
            }

            if (!ModelState.IsValid)
            {
                BolumleriDoldur();
                return Page();
            }

            Kaydedildi = true;
            BolumleriDoldur();
            return Page();
        }
        private void BolumleriDoldur()
        {
            var bolumler = new List<string>
        {
            "Bilgisayar Mühendisliği",
            "Yazılım Mühendisliği",
            "Elektrik-Elektronik Mühendisliği",
            "Elektrik Mühendisliği",
            "Elektronik Mühendisliği",
            "Elektronik ve Haberleşme Mühendisliği",
            "Telekomünikasyon Mühendisliği",
            "Endüstri Mühendisliği",
            "Makine Mühendisliği",
            "Yapay Zeka ve Veri Mühendisliği",
            "Yapay Zeka Mühendisliği",
            "Veri Bilimi ve Analitiği",
            "Veri Bilimi Mühendisliği",
            "Biyomedikal Mühendisliği",
            "Kontrol ve Otomasyon Mühendisliği",
            "Mekatronik Mühendisliği",
            "Robotik ve Otonom Sistemler Mühendisliği",
            "Bilgisayar Bilimleri",
            "Bilgisayar Bilimleri Mühendisliği",
            "Bilgi Sistemleri Mühendisliği",
            "Bilgi Teknolojileri",
            "Yönetim Bilişim Sistemleri",
            "Bilişim Sistemleri Mühendisliği",
            "Adli Bilişim Mühendisliği",
            "Yazılım ve Bilişim Mühendisliği",
            "İletişim Mühendisliği",
            "Telekomünikasyon ve Ağ Mühendisliği",
            "Siber Güvenlik Mühendisliği",
            "Siber Güvenlik",
            "Bilgi Güvenliği Teknolojisi",
            "Kriptografi Mühendisliği",
            "Matematik Mühendisliği",
            "Matematik ve Bilgisayar Bilimleri",
            "İstatistik",
            "İstatistik ve Bilgisayar Bilimleri",
            "Uygulamalı Matematik",
            "Uygulamalı Matematik ve Bilgisayar",
            "Fizik Mühendisliği",
            "Fizik",
            "Kimya Mühendisliği",
            "Kimya",
            "Biyoloji",
            "Biyomühendislik",
            "Genetik ve Biyomühendislik",
            "Genetik ve Biyoteknoloji",
            "Biyoteknoloji",
            "Çevre Mühendisliği",
            "İnşaat Mühendisliği",
            "Harita Mühendisliği",
            "Geomatik Mühendisliği",
            "Jeoloji Mühendisliği",
            "Jeofizik Mühendisliği",
            "Maden Mühendisliği",
            "Petrol ve Doğalgaz Mühendisliği",
            "Metalurji ve Malzeme Mühendisliği",
            "Malzeme Bilimi ve Mühendisliği",
            "Seramik ve Cam Mühendisliği",
            "Tekstil Mühendisliği",
            "Gıda Mühendisliği",
            "Tarım Makineleri ve Teknolojileri Mühendisliği",
            "Biyosistem Mühendisliği",
            "Tarım Mühendisliği",
            "Ziraat Mühendisliği",
            "Orman Mühendisliği",
            "Deniz Ulaştırma İşletme Mühendisliği",
            "Gemi İnşaatı ve Gemi Makineleri Mühendisliği",
            "Gemi Makineleri İşletme Mühendisliği",
            "Uçak Mühendisliği",
            "Havacılık ve Uzay Mühendisliği",
            "Uzay Mühendisliği",
            "Uçak ve Uzay Mühendisliği",
            "Yazılım Geliştirme",
            "Web Tasarımı ve Kodlama",
            "Bilgisayar Teknolojisi",
            "Bilgisayar Programcılığı",
            "Bilgisayar ve Öğretim Teknolojileri Eğitimi",
            "Elektronik Teknolojisi",
            "Elektrik-Elektronik Teknolojisi",
            "Bilgi Güvenliği Teknolojisi",
            "Yapay Zeka ve Makine Öğrenmesi",
            "Makine Öğrenmesi",
            "Veri Analitiği",
            "Veri Yönetimi",
            "İş Analitiği",
            "Finansal Teknoloji",
            "Endüstri ve Sistem Mühendisliği",
            "Sistem Mühendisliği",
            "Üretim Mühendisliği",
            "Üretim Sistemleri Mühendisliği",
            "Lojistik Mühendisliği",
            "Ulaştırma Mühendisliği",
            "Mühendislik Bilimleri",
            "Mühendislik ve Doğa Bilimleri",
        };
            Bolumler = new SelectList(bolumler);
        }

    }
}
