using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BLM4581Web.Migrations
{
    /// <inheritdoc />
    public partial class OrnekKitapVerileri : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Kitaplar",
                columns: new[] { "Id", "Ad", "BasimYili", "KategoriId", "SayfaSayisi", "Yazar" },
                values: new object[,]
                {
                    { 10001, "Suç ve Ceza", 1866, 1, 687, "Fyodor Dostoyevski" },
                    { 10002, "Sefiller", 1862, 1, 1463, "Victor Hugo" },
                    { 10003, "1984", 1949, 1, 328, "George Orwell" },
                    { 10004, "Dönüşüm", 1915, 1, 74, "Franz Kafka" },
                    { 10005, "Kürk Mantolu Madonna", 1943, 1, 160, "Sabahattin Ali" },
                    { 10006, "Beyaz Geceler", 1848, 1, 112, "Fyodor Dostoyevski" },
                    { 10007, "Tutunamayanlar", 1972, 1, 724, "Oğuz Atay" },
                    { 10008, "Yabancı", 1942, 1, 119, "Albert Camus" },
                    { 10009, "Anna Karenina", 1878, 1, 864, "Lev Tolstoy" },
                    { 10010, "Don Kişot", 1605, 1, 863, "Miguel de Cervantes" },
                    { 10011, "Küçük Prens", 1943, 2, 96, "Antoine de Saint-Exupéry" },
                    { 10012, "Semaver", 1936, 2, 128, "Sait Faik Abasıyanık" },
                    { 10013, "Kaşağı", 1919, 2, 64, "Ömer Seyfettin" },
                    { 10014, "Değirmen", 1935, 2, 144, "Sabahattin Ali" },
                    { 10015, "Memleket Hikâyeleri", 1919, 2, 208, "Refik Halit Karay" },
                    { 10016, "Kozmos", 1980, 3, 396, "Carl Sagan" },
                    { 10017, "Kısa Bir Zaman Tarihi", 1988, 3, 256, "Stephen Hawking" },
                    { 10018, "Türlerin Kökeni", 1859, 3, 502, "Charles Darwin" },
                    { 10019, "Gen Bencildir", 1976, 3, 360, "Richard Dawkins" },
                    { 10020, "Sessiz Bahar", 1962, 3, 400, "Rachel Carson" },
                    { 10021, "Sapiens", 2011, 3, 412, "Yuval Noah Harari" },
                    { 10022, "Zamanın Kısa Tarihi", 1988, 3, 256, "Stephen Hawking" },
                    { 10023, "Kozmik Bağlantı", 1973, 3, 320, "Carl Sagan" },
                    { 10024, "Neredeyse Her Şeyin Kısa Tarihi", 2003, 3, 544, "Bill Bryson" },
                    { 10025, "Zamanın Düzeni", 2017, 3, 256, "Carlo Rovelli" },
                    { 10026, "Nutuk", 1927, 4, 600, "Mustafa Kemal Atatürk" },
                    { 10027, "Tüfek, Mikrop ve Çelik", 1997, 4, 528, "Jared Diamond" },
                    { 10028, "Osmanlı İmparatorluğu", 1973, 4, 640, "Halil İnalcık" },
                    { 10029, "İkinci Dünya Savaşı", 2012, 4, 880, "Antony Beevor" },
                    { 10030, "Tarihin Sonu ve Son İnsan", 1992, 4, 464, "Francis Fukuyama" },
                    { 10031, "Devlet", -380, 5, 416, "Platon" },
                    { 10032, "Nikomakhos'a Etik", -340, 5, 384, "Aristoteles" },
                    { 10033, "Böyle Buyurdu Zerdüşt", 1883, 5, 352, "Friedrich Nietzsche" },
                    { 10034, "Meditasyonlar", 180, 5, 256, "Marcus Aurelius" },
                    { 10035, "Saf Aklın Eleştirisi", 1781, 5, 856, "Immanuel Kant" },
                    { 10036, "Sanatın Öyküsü", 1950, 6, 688, "E. H. Gombrich" },
                    { 10037, "Görme Biçimleri", 1972, 6, 176, "John Berger" },
                    { 10038, "Sanat ve Yanılsama", 1960, 6, 582, "E. H. Gombrich" },
                    { 10039, "Modern Sanatın Öyküsü", 1968, 6, 832, "H. H. Arnason" },
                    { 10040, "Sanat Nedir?", 1897, 6, 256, "Lev Tolstoy" },
                    { 10041, "İnsanın Anlam Arayışı", 1946, 7, 184, "Viktor E. Frankl" },
                    { 10042, "Düşünme, Hızlı ve Yavaş", 2011, 7, 512, "Daniel Kahneman" },
                    { 10043, "Akış", 1990, 7, 336, "Mihaly Csikszentmihalyi" },
                    { 10044, "İnsanın Kendini Arayışı", 1953, 7, 320, "Rollo May" },
                    { 10045, "Bilinçaltı", 1915, 7, 256, "Sigmund Freud" },
                    { 10046, "İnce Memed", 1955, 8, 436, "Yaşar Kemal" },
                    { 10047, "Saatleri Ayarlama Enstitüsü", 1961, 8, 382, "Ahmet Hamdi Tanpınar" },
                    { 10048, "Kuyucaklı Yusuf", 1937, 8, 221, "Sabahattin Ali" },
                    { 10049, "Huzur", 1949, 8, 391, "Ahmet Hamdi Tanpınar" },
                    { 10050, "Çalıkuşu", 1922, 8, 544, "Reşat Nuri Güntekin" },
                    { 10051, "Prens", 1532, 9, 140, "Niccolò Machiavelli" },
                    { 10052, "Komünist Manifesto", 1848, 9, 80, "Karl Marx ve Friedrich Engels" },
                    { 10053, "Leviathan", 1651, 9, 736, "Thomas Hobbes" },
                    { 10054, "Demokrasi Üzerine", 1998, 9, 272, "Robert A. Dahl" },
                    { 10055, "Totalitarizmin Kaynakları", 1951, 9, 576, "Hannah Arendt" },
                    { 10056, "İslam'ın Kısa Tarihi", 2000, 10, 224, "Karen Armstrong" },
                    { 10057, "Kutsal ve Dindışı", 1957, 10, 256, "Mircea Eliade" },
                    { 10058, "Tanrı Yanılgısı", 2006, 10, 464, "Richard Dawkins" },
                    { 10059, "Dinlerin Tarihi", 1958, 10, 400, "Huston Smith" },
                    { 10060, "Tanrı'nın Tarihi", 1993, 10, 496, "Karen Armstrong" },
                    { 10061, "Açık", 2009, 11, 400, "Andre Agassi" },
                    { 10062, "Fever Pitch", 1992, 11, 256, "Nick Hornby" },
                    { 10063, "Koşu Hakkında", 2007, 11, 192, "Haruki Murakami" },
                    { 10064, "Benim Oyunum", 2016, 11, 336, "Johan Cruyff" },
                    { 10065, "Shoe Dog", 2016, 11, 400, "Phil Knight" },
                    { 10066, "Müzik Üzerine", 1949, 12, 320, "Theodor W. Adorno" },
                    { 10067, "Hayatım", 1989, 12, 448, "Miles Davis" },
                    { 10068, "Just Kids", 2010, 12, 304, "Patti Smith" },
                    { 10069, "Chronicles", 2004, 12, 352, "Bob Dylan" },
                    { 10070, "Life", 2010, 12, 576, "Keith Richards" },
                    { 10071, "Sinema Nedir?", 1958, 13, 400, "André Bazin" },
                    { 10072, "Bir Film Nasıl Okunur?", 1977, 13, 736, "James Monaco" },
                    { 10073, "Easy Riders, Raging Bulls", 1998, 13, 512, "Peter Biskind" },
                    { 10074, "Hitchcock", 1966, 13, 368, "François Truffaut" },
                    { 10075, "Sinemanın Dili", 2010, 13, 192, "Robert Edgar-Hunt" },
                    { 10076, "Bir Bebek Evi", 1879, 14, 128, "Henrik Ibsen" },
                    { 10077, "Hamlet", 1603, 14, 342, "William Shakespeare" },
                    { 10078, "Godot'yu Beklerken", 1953, 14, 120, "Samuel Beckett" },
                    { 10079, "Kral Lear", 1606, 14, 256, "William Shakespeare" },
                    { 10080, "Keşanlı Ali Destanı", 1964, 14, 128, "Haldun Taner" },
                    { 10081, "Seyahatname", 1670, 15, 500, "Evliya Çelebi" },
                    { 10082, "Yolda", 1957, 15, 320, "Jack Kerouac" },
                    { 10083, "Bir Bisikletlinin Günlüğü", 2011, 15, 288, "Robert Penn" },
                    { 10084, "Vahşi", 2012, 15, 336, "Cheryl Strayed" },
                    { 10085, "İtalya Yolculuğu", 1816, 15, 512, "Johann Wolfgang von Goethe" },
                    { 10086, "Küçük Kadınlar", 1868, 16, 759, "Louisa May Alcott" },
                    { 10087, "Alice Harikalar Diyarında", 1865, 16, 192, "Lewis Carroll" },
                    { 10088, "Pinokyo", 1883, 16, 240, "Carlo Collodi" },
                    { 10089, "Heidi", 1881, 16, 256, "Johanna Spyri" },
                    { 10090, "Charlie'nin Çikolata Fabrikası", 1964, 16, 192, "Roald Dahl" },
                    { 10091, "Harry Potter ve Felsefe Taşı", 1997, 17, 320, "J. K. Rowling" },
                    { 10092, "Açlık Oyunları", 2008, 17, 374, "Suzanne Collins" },
                    { 10093, "Mucize", 2012, 17, 320, "R. J. Palacio" },
                    { 10094, "Labirent: Ölümcül Kaçış", 2009, 17, 375, "James Dashner" },
                    { 10095, "Fahrenheit 451", 1953, 17, 249, "Ray Bradbury" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10001);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10002);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10003);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10004);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10005);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10006);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10007);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10008);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10009);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10010);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10011);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10012);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10013);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10014);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10015);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10016);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10017);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10018);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10019);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10020);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10021);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10022);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10023);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10024);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10025);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10026);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10027);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10028);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10029);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10030);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10031);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10032);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10033);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10034);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10035);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10036);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10037);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10038);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10039);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10040);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10041);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10042);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10043);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10044);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10045);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10046);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10047);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10048);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10049);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10050);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10051);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10052);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10053);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10054);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10055);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10056);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10057);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10058);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10059);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10060);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10061);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10062);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10063);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10064);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10065);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10066);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10067);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10068);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10069);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10070);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10071);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10072);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10073);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10074);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10075);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10076);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10077);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10078);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10079);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10080);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10081);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10082);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10083);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10084);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10085);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10086);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10087);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10088);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10089);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10090);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10091);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10092);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10093);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10094);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10095);
        }
    }
}
