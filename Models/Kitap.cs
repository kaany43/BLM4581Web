using System.ComponentModel.DataAnnotations;
namespace BLM4581Web.Models
{
    public class Kitap
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Kitap adı zorunludur.")]
        [StringLength(100, ErrorMessage = "Kitap adı 100 karakterden fazla olamaz.")]
        [Display(Name = "Kitap Adı")]
        public string Ad { get; set; } = "";

        [Required(ErrorMessage = "Yazar adı zorunludur.")]
        [StringLength(100, ErrorMessage = "Yazar adı 100 karakterden fazla olamaz.")]
        [Display(Name = "Yazar")]
        public string Yazar { get; set; } = "";

        [Required(ErrorMessage = "Sayfa sayısı zorunludur.")]
        [Range(1, 10000, ErrorMessage = "Sayfa sayısı 1 ile 10000 arasında olmalıdır.")]
        [Display(Name = "Sayfa Sayısı")]
        public int? SayfaSayisi { get; set; }

        [Required(ErrorMessage = "Basım yılı zorunludur.")]
        [Range(-400, 2026, ErrorMessage = "Basım yılı -400 ile 2026 arasında olmalıdır.")]
        [Display(Name = "Basım Yılı")]
        public int? BasimYili { get; set; }

        [Required(ErrorMessage = "Kategori seçiniz.")]
        [Display(Name = "Kategori")]
        public int? KategoriId { get; set; }
        public Kategori? Kategori { get; set; }

    }
}
