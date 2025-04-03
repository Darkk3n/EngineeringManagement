using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EngineeringManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNewGeneralEmpFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AcademicDegree",
                table: "GeneralEmployees",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AcademicDegreeDocument",
                table: "GeneralEmployees",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "GeneralEmployees",
                type: "TEXT",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BankAccountCard",
                table: "GeneralEmployees",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BankAccountNumber",
                table: "GeneralEmployees",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BankName",
                table: "GeneralEmployees",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BenefitiaryBirthDate",
                table: "GeneralEmployees",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BenefitiaryPercent",
                table: "GeneralEmployees",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "GeneralEmployees",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BirthPlace",
                table: "GeneralEmployees",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FatherName",
                table: "GeneralEmployees",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FonacotClientNumber",
                table: "GeneralEmployees",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HospitalNumber",
                table: "GeneralEmployees",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InfonavitNumber",
                table: "GeneralEmployees",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InfonavitPercent",
                table: "GeneralEmployees",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotherName",
                table: "GeneralEmployees",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Profession",
                table: "GeneralEmployees",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcademicDegree",
                table: "GeneralEmployees");

            migrationBuilder.DropColumn(
                name: "AcademicDegreeDocument",
                table: "GeneralEmployees");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "GeneralEmployees");

            migrationBuilder.DropColumn(
                name: "BankAccountCard",
                table: "GeneralEmployees");

            migrationBuilder.DropColumn(
                name: "BankAccountNumber",
                table: "GeneralEmployees");

            migrationBuilder.DropColumn(
                name: "BankName",
                table: "GeneralEmployees");

            migrationBuilder.DropColumn(
                name: "BenefitiaryBirthDate",
                table: "GeneralEmployees");

            migrationBuilder.DropColumn(
                name: "BenefitiaryPercent",
                table: "GeneralEmployees");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "GeneralEmployees");

            migrationBuilder.DropColumn(
                name: "BirthPlace",
                table: "GeneralEmployees");

            migrationBuilder.DropColumn(
                name: "FatherName",
                table: "GeneralEmployees");

            migrationBuilder.DropColumn(
                name: "FonacotClientNumber",
                table: "GeneralEmployees");

            migrationBuilder.DropColumn(
                name: "HospitalNumber",
                table: "GeneralEmployees");

            migrationBuilder.DropColumn(
                name: "InfonavitNumber",
                table: "GeneralEmployees");

            migrationBuilder.DropColumn(
                name: "InfonavitPercent",
                table: "GeneralEmployees");

            migrationBuilder.DropColumn(
                name: "MotherName",
                table: "GeneralEmployees");

            migrationBuilder.DropColumn(
                name: "Profession",
                table: "GeneralEmployees");
        }
    }
}
