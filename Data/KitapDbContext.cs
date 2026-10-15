using BLM4581Web.Models;
using Microsoft.EntityFrameworkCore;

namespace BLM4581Web.Data;

public class KitapDbContext : DbContext
{
    public KitapDbContext(DbContextOptions<KitapDbContext> options)
        : base(options)
    {
    }

    public DbSet<Kitap> Kitaplar { get; set; } = default!;
    public DbSet<Kategori> Kategoriler { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Kategori>().HasData(
            new Kategori { Id = 1, Ad = "Roman" },
            new Kategori { Id = 2, Ad = "Öykü" },
            new Kategori { Id = 3, Ad = "Bilim" },
            new Kategori { Id = 4, Ad = "Tarih" },
            new Kategori { Id = 5, Ad = "Felsefe" },
            new Kategori { Id = 6, Ad = "Sanat" },
            new Kategori { Id = 7, Ad = "Psikoloji" },
            new Kategori { Id = 8, Ad = "Edebiyat" },
            new Kategori { Id = 9, Ad = "Siyaset" },
            new Kategori { Id = 10, Ad = "Din" },
            new Kategori { Id = 11, Ad = "Spor" },
            new Kategori { Id = 12, Ad = "Müzik" },
            new Kategori { Id = 13, Ad = "Sinema" },
            new Kategori { Id = 14, Ad = "Tiyatro" },
            new Kategori { Id = 15, Ad = "Gezi" },
            new Kategori { Id = 16, Ad = "Çocuk" },
            new Kategori { Id = 17, Ad = "Gençlik" }
  
        );
        modelBuilder.Entity<Kitap>().HasData(
            new Kitap { Id = 10001, Ad = "Suç ve Ceza", Yazar = "Fyodor Dostoyevski", BasimYili = 1866, SayfaSayisi = 687, KategoriId = 1 },
            new Kitap { Id = 10002, Ad = "Sefiller", Yazar = "Victor Hugo", BasimYili = 1862, SayfaSayisi = 1463, KategoriId = 1 },
            new Kitap { Id = 10003, Ad = "1984", Yazar = "George Orwell", BasimYili = 1949, SayfaSayisi = 328, KategoriId = 1 },
            new Kitap { Id = 10004, Ad = "Dönüşüm", Yazar = "Franz Kafka", BasimYili = 1915, SayfaSayisi = 74, KategoriId = 1 },
            new Kitap { Id = 10005, Ad = "Kürk Mantolu Madonna", Yazar = "Sabahattin Ali", BasimYili = 1943, SayfaSayisi = 160, KategoriId = 1 },
            new Kitap { Id = 10006, Ad = "Beyaz Geceler", Yazar = "Fyodor Dostoyevski", BasimYili = 1848, SayfaSayisi = 112, KategoriId = 1 },
            new Kitap { Id = 10007, Ad = "Tutunamayanlar", Yazar = "Oğuz Atay", BasimYili = 1972, SayfaSayisi = 724, KategoriId = 1 },
            new Kitap { Id = 10008, Ad = "Yabancı", Yazar = "Albert Camus", BasimYili = 1942, SayfaSayisi = 119, KategoriId = 1 },
            new Kitap { Id = 10009, Ad = "Anna Karenina", Yazar = "Lev Tolstoy", BasimYili = 1878, SayfaSayisi = 864, KategoriId = 1 },
            new Kitap { Id = 10010, Ad = "Don Kişot", Yazar = "Miguel de Cervantes", BasimYili = 1605, SayfaSayisi = 863, KategoriId = 1 },
            new Kitap { Id = 10011, Ad = "Küçük Prens", Yazar = "Antoine de Saint-Exupéry", BasimYili = 1943, SayfaSayisi = 96, KategoriId = 2 },
            new Kitap { Id = 10012, Ad = "Semaver", Yazar = "Sait Faik Abasıyanık", BasimYili = 1936, SayfaSayisi = 128, KategoriId = 2 },
            new Kitap { Id = 10013, Ad = "Kaşağı", Yazar = "Ömer Seyfettin", BasimYili = 1919, SayfaSayisi = 64, KategoriId = 2 },
            new Kitap { Id = 10014, Ad = "Değirmen", Yazar = "Sabahattin Ali", BasimYili = 1935, SayfaSayisi = 144, KategoriId = 2 },
            new Kitap { Id = 10015, Ad = "Memleket Hikâyeleri", Yazar = "Refik Halit Karay", BasimYili = 1919, SayfaSayisi = 208, KategoriId = 2 },
            new Kitap { Id = 10016, Ad = "Kozmos", Yazar = "Carl Sagan", BasimYili = 1980, SayfaSayisi = 396, KategoriId = 3 },
            new Kitap { Id = 10017, Ad = "Kısa Bir Zaman Tarihi", Yazar = "Stephen Hawking", BasimYili = 1988, SayfaSayisi = 256, KategoriId = 3 },
            new Kitap { Id = 10018, Ad = "Türlerin Kökeni", Yazar = "Charles Darwin", BasimYili = 1859, SayfaSayisi = 502, KategoriId = 3 },
            new Kitap { Id = 10019, Ad = "Gen Bencildir", Yazar = "Richard Dawkins", BasimYili = 1976, SayfaSayisi = 360, KategoriId = 3 },
            new Kitap { Id = 10020, Ad = "Sessiz Bahar", Yazar = "Rachel Carson", BasimYili = 1962, SayfaSayisi = 400, KategoriId = 3 },
            new Kitap { Id = 10021, Ad = "Sapiens", Yazar = "Yuval Noah Harari", BasimYili = 2011, SayfaSayisi = 412, KategoriId = 3 },
            new Kitap { Id = 10022, Ad = "Zamanın Kısa Tarihi", Yazar = "Stephen Hawking", BasimYili = 1988, SayfaSayisi = 256, KategoriId = 3 },
            new Kitap { Id = 10023, Ad = "Kozmik Bağlantı", Yazar = "Carl Sagan", BasimYili = 1973, SayfaSayisi = 320, KategoriId = 3 },
            new Kitap { Id = 10024, Ad = "Neredeyse Her Şeyin Kısa Tarihi", Yazar = "Bill Bryson", BasimYili = 2003, SayfaSayisi = 544, KategoriId = 3 },
            new Kitap { Id = 10025, Ad = "Zamanın Düzeni", Yazar = "Carlo Rovelli", BasimYili = 2017, SayfaSayisi = 256, KategoriId = 3 },
            new Kitap { Id = 10026, Ad = "Nutuk", Yazar = "Mustafa Kemal Atatürk", BasimYili = 1927, SayfaSayisi = 600, KategoriId = 4 },
            new Kitap { Id = 10027, Ad = "Tüfek, Mikrop ve Çelik", Yazar = "Jared Diamond", BasimYili = 1997, SayfaSayisi = 528, KategoriId = 4 },
            new Kitap { Id = 10028, Ad = "Osmanlı İmparatorluğu", Yazar = "Halil İnalcık", BasimYili = 1973, SayfaSayisi = 640, KategoriId = 4 },
            new Kitap { Id = 10029, Ad = "İkinci Dünya Savaşı", Yazar = "Antony Beevor", BasimYili = 2012, SayfaSayisi = 880, KategoriId = 4 },
            new Kitap { Id = 10030, Ad = "Tarihin Sonu ve Son İnsan", Yazar = "Francis Fukuyama", BasimYili = 1992, SayfaSayisi = 464, KategoriId = 4 },
            new Kitap { Id = 10031, Ad = "Devlet", Yazar = "Platon", BasimYili = -380, SayfaSayisi = 416, KategoriId = 5 },
            new Kitap { Id = 10032, Ad = "Nikomakhos'a Etik", Yazar = "Aristoteles", BasimYili = -340, SayfaSayisi = 384, KategoriId = 5 },
            new Kitap { Id = 10033, Ad = "Böyle Buyurdu Zerdüşt", Yazar = "Friedrich Nietzsche", BasimYili = 1883, SayfaSayisi = 352, KategoriId = 5 },
            new Kitap { Id = 10034, Ad = "Meditasyonlar", Yazar = "Marcus Aurelius", BasimYili = 180, SayfaSayisi = 256, KategoriId = 5 },
            new Kitap { Id = 10035, Ad = "Saf Aklın Eleştirisi", Yazar = "Immanuel Kant", BasimYili = 1781, SayfaSayisi = 856, KategoriId = 5 },
            new Kitap { Id = 10036, Ad = "Sanatın Öyküsü", Yazar = "E. H. Gombrich", BasimYili = 1950, SayfaSayisi = 688, KategoriId = 6 },
            new Kitap { Id = 10037, Ad = "Görme Biçimleri", Yazar = "John Berger", BasimYili = 1972, SayfaSayisi = 176, KategoriId = 6 },
            new Kitap { Id = 10038, Ad = "Sanat ve Yanılsama", Yazar = "E. H. Gombrich", BasimYili = 1960, SayfaSayisi = 582, KategoriId = 6 },
            new Kitap { Id = 10039, Ad = "Modern Sanatın Öyküsü", Yazar = "H. H. Arnason", BasimYili = 1968, SayfaSayisi = 832, KategoriId = 6 },
            new Kitap { Id = 10040, Ad = "Sanat Nedir?", Yazar = "Lev Tolstoy", BasimYili = 1897, SayfaSayisi = 256, KategoriId = 6 },
            new Kitap { Id = 10041, Ad = "İnsanın Anlam Arayışı", Yazar = "Viktor E. Frankl", BasimYili = 1946, SayfaSayisi = 184, KategoriId = 7 },
            new Kitap { Id = 10042, Ad = "Düşünme, Hızlı ve Yavaş", Yazar = "Daniel Kahneman", BasimYili = 2011, SayfaSayisi = 512, KategoriId = 7 },
            new Kitap { Id = 10043, Ad = "Akış", Yazar = "Mihaly Csikszentmihalyi", BasimYili = 1990, SayfaSayisi = 336, KategoriId = 7 },
            new Kitap { Id = 10044, Ad = "İnsanın Kendini Arayışı", Yazar = "Rollo May", BasimYili = 1953, SayfaSayisi = 320, KategoriId = 7 },
            new Kitap { Id = 10045, Ad = "Bilinçaltı", Yazar = "Sigmund Freud", BasimYili = 1915, SayfaSayisi = 256, KategoriId = 7 },
            new Kitap { Id = 10046, Ad = "İnce Memed", Yazar = "Yaşar Kemal", BasimYili = 1955, SayfaSayisi = 436, KategoriId = 8 },
            new Kitap { Id = 10047, Ad = "Saatleri Ayarlama Enstitüsü", Yazar = "Ahmet Hamdi Tanpınar", BasimYili = 1961, SayfaSayisi = 382, KategoriId = 8 },
            new Kitap { Id = 10048, Ad = "Kuyucaklı Yusuf", Yazar = "Sabahattin Ali", BasimYili = 1937, SayfaSayisi = 221, KategoriId = 8 },
            new Kitap { Id = 10049, Ad = "Huzur", Yazar = "Ahmet Hamdi Tanpınar", BasimYili = 1949, SayfaSayisi = 391, KategoriId = 8 },
            new Kitap { Id = 10050, Ad = "Çalıkuşu", Yazar = "Reşat Nuri Güntekin", BasimYili = 1922, SayfaSayisi = 544, KategoriId = 8 },
            new Kitap { Id = 10051, Ad = "Prens", Yazar = "Niccolò Machiavelli", BasimYili = 1532, SayfaSayisi = 140, KategoriId = 9 },
            new Kitap { Id = 10052, Ad = "Komünist Manifesto", Yazar = "Karl Marx ve Friedrich Engels", BasimYili = 1848, SayfaSayisi = 80, KategoriId = 9 },
            new Kitap { Id = 10053, Ad = "Leviathan", Yazar = "Thomas Hobbes", BasimYili = 1651, SayfaSayisi = 736, KategoriId = 9 },
            new Kitap { Id = 10054, Ad = "Demokrasi Üzerine", Yazar = "Robert A. Dahl", BasimYili = 1998, SayfaSayisi = 272, KategoriId = 9 },
            new Kitap { Id = 10055, Ad = "Totalitarizmin Kaynakları", Yazar = "Hannah Arendt", BasimYili = 1951, SayfaSayisi = 576, KategoriId = 9 },
            new Kitap { Id = 10056, Ad = "İslam'ın Kısa Tarihi", Yazar = "Karen Armstrong", BasimYili = 2000, SayfaSayisi = 224, KategoriId = 10 },
            new Kitap { Id = 10057, Ad = "Kutsal ve Dindışı", Yazar = "Mircea Eliade", BasimYili = 1957, SayfaSayisi = 256, KategoriId = 10 },
            new Kitap { Id = 10058, Ad = "Tanrı Yanılgısı", Yazar = "Richard Dawkins", BasimYili = 2006, SayfaSayisi = 464, KategoriId = 10 },
            new Kitap { Id = 10059, Ad = "Dinlerin Tarihi", Yazar = "Huston Smith", BasimYili = 1958, SayfaSayisi = 400, KategoriId = 10 },
            new Kitap { Id = 10060, Ad = "Tanrı'nın Tarihi", Yazar = "Karen Armstrong", BasimYili = 1993, SayfaSayisi = 496, KategoriId = 10 },
            new Kitap { Id = 10061, Ad = "Açık", Yazar = "Andre Agassi", BasimYili = 2009, SayfaSayisi = 400, KategoriId = 11 },
            new Kitap { Id = 10062, Ad = "Fever Pitch", Yazar = "Nick Hornby", BasimYili = 1992, SayfaSayisi = 256, KategoriId = 11 },
            new Kitap { Id = 10063, Ad = "Koşu Hakkında", Yazar = "Haruki Murakami", BasimYili = 2007, SayfaSayisi = 192, KategoriId = 11 },
            new Kitap { Id = 10064, Ad = "Benim Oyunum", Yazar = "Johan Cruyff", BasimYili = 2016, SayfaSayisi = 336, KategoriId = 11 },
            new Kitap { Id = 10065, Ad = "Shoe Dog", Yazar = "Phil Knight", BasimYili = 2016, SayfaSayisi = 400, KategoriId = 11 },
            new Kitap { Id = 10066, Ad = "Müzik Üzerine", Yazar = "Theodor W. Adorno", BasimYili = 1949, SayfaSayisi = 320, KategoriId = 12 },
            new Kitap { Id = 10067, Ad = "Hayatım", Yazar = "Miles Davis", BasimYili = 1989, SayfaSayisi = 448, KategoriId = 12 },
            new Kitap { Id = 10068, Ad = "Just Kids", Yazar = "Patti Smith", BasimYili = 2010, SayfaSayisi = 304, KategoriId = 12 },
            new Kitap { Id = 10069, Ad = "Chronicles", Yazar = "Bob Dylan", BasimYili = 2004, SayfaSayisi = 352, KategoriId = 12 },
            new Kitap { Id = 10070, Ad = "Life", Yazar = "Keith Richards", BasimYili = 2010, SayfaSayisi = 576, KategoriId = 12 },
            new Kitap { Id = 10071, Ad = "Sinema Nedir?", Yazar = "André Bazin", BasimYili = 1958, SayfaSayisi = 400, KategoriId = 13 },
            new Kitap { Id = 10072, Ad = "Bir Film Nasıl Okunur?", Yazar = "James Monaco", BasimYili = 1977, SayfaSayisi = 736, KategoriId = 13 },
            new Kitap { Id = 10073, Ad = "Easy Riders, Raging Bulls", Yazar = "Peter Biskind", BasimYili = 1998, SayfaSayisi = 512, KategoriId = 13 },
            new Kitap { Id = 10074, Ad = "Hitchcock", Yazar = "François Truffaut", BasimYili = 1966, SayfaSayisi = 368, KategoriId = 13 },
            new Kitap { Id = 10075, Ad = "Sinemanın Dili", Yazar = "Robert Edgar-Hunt", BasimYili = 2010, SayfaSayisi = 192, KategoriId = 13 },
            new Kitap { Id = 10076, Ad = "Bir Bebek Evi", Yazar = "Henrik Ibsen", BasimYili = 1879, SayfaSayisi = 128, KategoriId = 14 },
            new Kitap { Id = 10077, Ad = "Hamlet", Yazar = "William Shakespeare", BasimYili = 1603, SayfaSayisi = 342, KategoriId = 14 },
            new Kitap { Id = 10078, Ad = "Godot'yu Beklerken", Yazar = "Samuel Beckett", BasimYili = 1953, SayfaSayisi = 120, KategoriId = 14 },
            new Kitap { Id = 10079, Ad = "Kral Lear", Yazar = "William Shakespeare", BasimYili = 1606, SayfaSayisi = 256, KategoriId = 14 },
            new Kitap { Id = 10080, Ad = "Keşanlı Ali Destanı", Yazar = "Haldun Taner", BasimYili = 1964, SayfaSayisi = 128, KategoriId = 14 },
            new Kitap { Id = 10081, Ad = "Seyahatname", Yazar = "Evliya Çelebi", BasimYili = 1670, SayfaSayisi = 500, KategoriId = 15 },
            new Kitap { Id = 10082, Ad = "Yolda", Yazar = "Jack Kerouac", BasimYili = 1957, SayfaSayisi = 320, KategoriId = 15 },
            new Kitap { Id = 10083, Ad = "Bir Bisikletlinin Günlüğü", Yazar = "Robert Penn", BasimYili = 2011, SayfaSayisi = 288, KategoriId = 15 },
            new Kitap { Id = 10084, Ad = "Vahşi", Yazar = "Cheryl Strayed", BasimYili = 2012, SayfaSayisi = 336, KategoriId = 15 },
            new Kitap { Id = 10085, Ad = "İtalya Yolculuğu", Yazar = "Johann Wolfgang von Goethe", BasimYili = 1816, SayfaSayisi = 512, KategoriId = 15 },
            new Kitap { Id = 10086, Ad = "Küçük Kadınlar", Yazar = "Louisa May Alcott", BasimYili = 1868, SayfaSayisi = 759, KategoriId = 16 },
            new Kitap { Id = 10087, Ad = "Alice Harikalar Diyarında", Yazar = "Lewis Carroll", BasimYili = 1865, SayfaSayisi = 192, KategoriId = 16 },
            new Kitap { Id = 10088, Ad = "Pinokyo", Yazar = "Carlo Collodi", BasimYili = 1883, SayfaSayisi = 240, KategoriId = 16 },
            new Kitap { Id = 10089, Ad = "Heidi", Yazar = "Johanna Spyri", BasimYili = 1881, SayfaSayisi = 256, KategoriId = 16 },
            new Kitap { Id = 10090, Ad = "Charlie'nin Çikolata Fabrikası", Yazar = "Roald Dahl", BasimYili = 1964, SayfaSayisi = 192, KategoriId = 16 },
            new Kitap { Id = 10091, Ad = "Harry Potter ve Felsefe Taşı", Yazar = "J. K. Rowling", BasimYili = 1997, SayfaSayisi = 320, KategoriId = 17 },
            new Kitap { Id = 10092, Ad = "Açlık Oyunları", Yazar = "Suzanne Collins", BasimYili = 2008, SayfaSayisi = 374, KategoriId = 17 },
            new Kitap { Id = 10093, Ad = "Mucize", Yazar = "R. J. Palacio", BasimYili = 2012, SayfaSayisi = 320, KategoriId = 17 },
            new Kitap { Id = 10094, Ad = "Labirent: Ölümcül Kaçış", Yazar = "James Dashner", BasimYili = 2009, SayfaSayisi = 375, KategoriId = 17 },
            new Kitap { Id = 10095, Ad = "Fahrenheit 451", Yazar = "Ray Bradbury", BasimYili = 1953, SayfaSayisi = 249, KategoriId = 17 }
        );
    }
}

