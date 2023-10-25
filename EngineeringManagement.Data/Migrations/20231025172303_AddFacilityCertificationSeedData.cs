using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EngineeringManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddFacilityCertificationSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FacilityCertifications",
                columns: new[] { "Id", "CertificationId", "FacilityId" },
                values: new object[,]
                {
                    { -20, -6, -2 },
                    { -19, -6, -1 },
                    { -18, -5, -2 },
                    { -17, -5, -1 },
                    { -16, -4, -2 },
                    { -15, -4, -1 },
                    { -14, -3, -2 },
                    { -13, -3, -1 },
                    { -12, -1, -2 },
                    { -11, -1, -1 },
                    { -10, -17, -2 },
                    { -9, -16, -2 },
                    { -8, -15, -2 },
                    { -7, -14, -2 },
                    { -6, -13, -2 },
                    { -5, -12, -2 },
                    { -4, -11, -2 },
                    { -3, -10, -2 },
                    { -2, -9, -2 },
                    { -1, -2, -1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FacilityCertifications",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "FacilityCertifications",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "FacilityCertifications",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "FacilityCertifications",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "FacilityCertifications",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "FacilityCertifications",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "FacilityCertifications",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "FacilityCertifications",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "FacilityCertifications",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "FacilityCertifications",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "FacilityCertifications",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "FacilityCertifications",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "FacilityCertifications",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "FacilityCertifications",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "FacilityCertifications",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "FacilityCertifications",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "FacilityCertifications",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "FacilityCertifications",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "FacilityCertifications",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "FacilityCertifications",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
