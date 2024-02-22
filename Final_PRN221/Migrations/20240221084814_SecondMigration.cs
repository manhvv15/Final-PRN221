using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_PRN221.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0f4a2f7d-8185-4e3d-9f65-f434ee04af18", "833ea4e7-eeda-4b90-8d41-5d835421108a", "client", "client" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "17d4e59e-5e24-4cee-bd04-88ec9bdcda00", "8b873490-13eb-44e5-b1ac-9e1d77b0e8c5", "seller", "seller" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d565f25f-524f-477c-ab8b-17d5c71fc752", "06cfc3d6-6849-4f21-aca3-923cbfd82648", "admin", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f4a2f7d-8185-4e3d-9f65-f434ee04af18");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17d4e59e-5e24-4cee-bd04-88ec9bdcda00");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d565f25f-524f-477c-ab8b-17d5c71fc752");
        }
    }
}
