using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EngineeringManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedFKToCertifications : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CertificationName",
                table: "EmployeeCertifications");

            migrationBuilder.AddColumn<int>(
                name: "CertificationId",
                table: "EmployeeCertifications",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCertifications_CertificationId",
                table: "EmployeeCertifications",
                column: "CertificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeCertifications_Certifications_CertificationId",
                table: "EmployeeCertifications",
                column: "CertificationId",
                principalTable: "Certifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeCertifications_Certifications_CertificationId",
                table: "EmployeeCertifications");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeCertifications_CertificationId",
                table: "EmployeeCertifications");

            migrationBuilder.DropColumn(
                name: "CertificationId",
                table: "EmployeeCertifications");

            migrationBuilder.AddColumn<string>(
                name: "CertificationName",
                table: "EmployeeCertifications",
                type: "TEXT",
                nullable: true);
        }
    }
}
