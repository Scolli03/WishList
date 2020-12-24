using Microsoft.EntityFrameworkCore.Migrations;

namespace WishList.Migrations.WishListDB
{
    public partial class UserIDcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Wish",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Wish",
                keyColumn: "WishID",
                keyValue: 1,
                column: "UserID",
                value: "5aa802fc-acbf-478f-9935-b7c1259dc6cf");

            migrationBuilder.UpdateData(
                table: "Wish",
                keyColumn: "WishID",
                keyValue: 2,
                columns: new[] { "Season", "UserID" },
                values: new object[] { "4", "732bc22c-8c1a-4cc2-a59e-0a1b20a335d3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Wish");

            migrationBuilder.UpdateData(
                table: "Wish",
                keyColumn: "WishID",
                keyValue: 2,
                column: "Season",
                value: null);
        }
    }
}
