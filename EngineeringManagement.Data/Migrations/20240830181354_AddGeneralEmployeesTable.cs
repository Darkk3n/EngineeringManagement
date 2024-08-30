using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EngineeringManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddGeneralEmployeesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GeneralEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: true),
                    EmployeeName = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    StartDate = table.Column<string>(type: "TEXT", nullable: true),
                    RenewalDate = table.Column<string>(type: "TEXT", nullable: true),
                    JobDescription = table.Column<string>(type: "TEXT", nullable: true),
                    WorkCellPhone = table.Column<string>(type: "TEXT", nullable: true),
                    PersonalCellPhone = table.Column<string>(type: "TEXT", nullable: true),
                    Curp = table.Column<string>(type: "TEXT", nullable: true),
                    Rfc = table.Column<string>(type: "TEXT", nullable: true),
                    SocialSecurityNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    EmergencyPhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    EmergencyContactName = table.Column<string>(type: "TEXT", nullable: true),
                    EmergencyContactRelationShip = table.Column<string>(type: "TEXT", nullable: true),
                    BloodType = table.Column<string>(type: "TEXT", nullable: true),
                    EmployeeType = table.Column<int>(type: "INTEGER", nullable: false),
                    MaritalStatus = table.Column<string>(type: "TEXT", nullable: true),
                    HasJobReferences = table.Column<bool>(type: "INTEGER", nullable: true),
                    HasVotingCard = table.Column<bool>(type: "INTEGER", nullable: true),
                    HasCurp = table.Column<bool>(type: "INTEGER", nullable: true),
                    HasNss = table.Column<bool>(type: "INTEGER", nullable: true),
                    HasDrivingLicense = table.Column<bool>(type: "INTEGER", nullable: true),
                    HasInfonavit = table.Column<bool>(type: "INTEGER", nullable: true),
                    HasSat = table.Column<bool>(type: "INTEGER", nullable: true),
                    HasProofOfStudies = table.Column<bool>(type: "INTEGER", nullable: true),
                    HasBankStatement = table.Column<bool>(type: "INTEGER", nullable: true),
                    Has2Pictures = table.Column<bool>(type: "INTEGER", nullable: true),
                    HasProofOfAddress = table.Column<bool>(type: "INTEGER", nullable: true),
                    Has2RecomendationLetters = table.Column<bool>(type: "INTEGER", nullable: true),
                    HasCellPhone = table.Column<bool>(type: "INTEGER", nullable: true),
                    HasEquipment = table.Column<bool>(type: "INTEGER", nullable: true),
                    HasComputer = table.Column<bool>(type: "INTEGER", nullable: true),
                    HasVehicle = table.Column<bool>(type: "INTEGER", nullable: true),
                    HasUniforms = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralEmployees", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeneralEmployees");
        }
    }
}
