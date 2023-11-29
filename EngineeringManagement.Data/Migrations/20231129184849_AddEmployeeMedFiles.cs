using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EngineeringManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeMedFiles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeMedFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    BloodType = table.Column<string>(type: "TEXT", nullable: true),
                    EmergencyPhone = table.Column<string>(type: "TEXT", nullable: true),
                    EmergencyName = table.Column<string>(type: "TEXT", nullable: true),
                    Relation = table.Column<string>(type: "TEXT", nullable: true),
                    Able = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeMedFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeMedFiles_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeMedFiles_EmployeeId",
                table: "EmployeeMedFiles",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeMedFiles");
        }
    }
}
