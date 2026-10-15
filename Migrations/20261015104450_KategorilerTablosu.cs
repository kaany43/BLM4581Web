using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BLM4581Web.Migrations
{
    /// <inheritdoc />
    public partial class KategorilerTablosu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KategoriId",
                table: "Kitaplar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "Id", "Ad" },
                values: new object[,]
                {
                    { 1, "Roman" },
                    { 2, "Öykü" },
                    { 3, "Bilim" },
                    { 4, "Tarih" },
                    { 5, "Felsefe" },
                    { 6, "Sanat" },
                    { 7, "Psikoloji" },
                    { 8, "Edebiyat" },
                    { 9, "Siyaset" },
                    { 10, "Din" },
                    { 11, "Spor" },
                    { 12, "Müzik" },
                    { 13, "Sinema" },
                    { 14, "Tiyatro" },
                    { 15, "Gezi" },
                    { 16, "Çocuk" },
                    { 17, "Gençlik" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_KategoriId",
                table: "Kitaplar",
                column: "KategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Kategoriler_KategoriId",
                table: "Kitaplar",
                column: "KategoriId",
                principalTable: "Kategoriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Kategoriler_KategoriId",
                table: "Kitaplar");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropIndex(
                name: "IX_Kitaplar_KategoriId",
                table: "Kitaplar");

            migrationBuilder.DropColumn(
                name: "KategoriId",
                table: "Kitaplar");
        }
    }
}
