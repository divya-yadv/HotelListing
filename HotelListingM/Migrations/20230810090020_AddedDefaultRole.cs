using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListingM.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "593cb53c-0625-499b-8ae1-33bf7a84dc12");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e222dc49-1f8c-4912-908e-94b9a816691e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "75fa9b3b-aee5-4465-ac5f-ff27db808d38", "102440da-85ef-45cf-8655-08dc71319754", "User", "USER" },
                    { "e1c63bdc-3111-4089-80b9-d4dcd9648381", "4cc4db3d-9ee9-4e30-8b71-08d2b8a97a01", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75fa9b3b-aee5-4465-ac5f-ff27db808d38");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1c63bdc-3111-4089-80b9-d4dcd9648381");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "593cb53c-0625-499b-8ae1-33bf7a84dc12", "5588f45a-81d4-4452-bb3d-e03cbec3a3f9", "Administrator", "ADMINISTRATOR" },
                    { "e222dc49-1f8c-4912-908e-94b9a816691e", "12e860e4-db1c-421e-afc8-80e130714f94", "User", "USER" }
                });
        }
    }
}
