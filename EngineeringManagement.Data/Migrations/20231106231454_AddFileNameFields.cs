using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EngineeringManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddFileNameFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PictureFileName",
                table: "Employees",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SisositFileName",
                table: "Employees",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "PictureFileName", "SisositFileName" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureFileName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SisositFileName",
                table: "Employees");
        }
    }
}
