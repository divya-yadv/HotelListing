using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListingM.Migrations
{
    /// <inheritdoc />
    public partial class addall : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "059a27cb-3591-43a6-8381-1045feb571e0", "75c3f763-f9c0-4a6c-867f-f8f2e099e425", "Administrator", "ADMINISTRATOR" },
                    { "ed9df58b-0fb2-4591-a7cc-e126fdc4c21a", "25e57db3-1ca2-4cc8-8502-af4162bdc36a", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "059a27cb-3591-43a6-8381-1045feb571e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed9df58b-0fb2-4591-a7cc-e126fdc4c21a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "75fa9b3b-aee5-4465-ac5f-ff27db808d38", "102440da-85ef-45cf-8655-08dc71319754", "User", "USER" },
                    { "e1c63bdc-3111-4089-80b9-d4dcd9648381", "4cc4db3d-9ee9-4e30-8b71-08d2b8a97a01", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
