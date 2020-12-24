using Microsoft.EntityFrameworkCore.Migrations;

namespace WishList.Migrations.WishListDB
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Wish",
                columns: table => new
                {
                    WishID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Year = table.Column<string>(type: "TEXT", nullable: true),
                    Plot = table.Column<string>(type: "TEXT", nullable: true),
                    PosterURL = table.Column<string>(type: "TEXT", nullable: true),
                    imdbID = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    Season = table.Column<string>(type: "TEXT", nullable: true),
                    totalSeasons = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wish", x => x.WishID);
                });

            migrationBuilder.InsertData(
                table: "Wish",
                columns: new[] { "WishID", "Plot", "PosterURL", "Season", "Title", "Type", "Year", "imdbID", "totalSeasons" },
                values: new object[] { 1, null, null, null, "The Grinch", "movie", "2018", "tt2709692", null });

            migrationBuilder.InsertData(
                table: "Wish",
                columns: new[] { "WishID", "Plot", "PosterURL", "Season", "Title", "Type", "Year", "imdbID", "totalSeasons" },
                values: new object[] { 2, null, null, null, "Mr. Robot", "series", "2015-2019", "tt4158110", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Wish");
        }
    }
}
