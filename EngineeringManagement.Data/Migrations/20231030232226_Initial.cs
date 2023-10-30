using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EngineeringManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Certifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CertificationName = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeName = table.Column<string>(type: "TEXT", nullable: false),
                    Position = table.Column<string>(type: "TEXT", nullable: false),
                    EmployeeType = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Facilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FacilityName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeCertifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CertificationId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeCertifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeCertifications_Certifications_CertificationId",
                        column: x => x.CertificationId,
                        principalTable: "Certifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeCertifications_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FacilityCertifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FacilityId = table.Column<int>(type: "INTEGER", nullable: false),
                    CertificationId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilityCertifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FacilityCertifications_Certifications_CertificationId",
                        column: x => x.CertificationId,
                        principalTable: "Certifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FacilityCertifications_Facilities_FacilityId",
                        column: x => x.FacilityId,
                        principalTable: "Facilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "CertificationName", "Description" },
                values: new object[,]
                {
                    { -25, "NOM-029", "MANTENIMIENTO DE LAS INSTALACIONES ELECTRICAS EN LOS CENTROS DE TRABAJO" },
                    { -24, "NOM-026", "CORRECTA INTERPRETACION DE LOS ELEMENTOS DE SEÑALIZACION DEL CENTRO DE TRABAJO" },
                    { -23, "Candados y etiquetas", null },
                    { -22, "Aperturas de líneas de proceso", null },
                    { -21, "Trabajos en caliente", null },
                    { -20, "NOM-030", "Servicios Preventivos de Seguridad y Salud en el Trabajo" },
                    { -19, "NOM-036", "Manejo de cargas manuales" },
                    { -18, "Uso, revisión, reposición, limpieza, limitaciones, mantenimiento, resguardo y disposición final del equipo de protección personal.", null },
                    { -17, "NOM-031", "Condiciones de seguridad e higiene" },
                    { -16, "Operación segura de plataformas articuladas y elevadas", null },
                    { -15, "Izajes y Cargas", null },
                    { -14, "Formacion de Armadores de Andamios", null },
                    { -13, "Primeros Auxilios", null },
                    { -12, "NOM-026-STPS-2008", "Colores y señales de seguridad e higiene e identificacion de riesgos conducidas por tuberias" },
                    { -11, "NOM-017- STPS-2008", "Equipo de proteccion personal Selección uso y manejo en los centros de trabajo" },
                    { -10, "NOM-002-STPS-2010", "Condiciones de Seguridad Prevencion y Proteccion contra Incendio en los centros de Trabajo" },
                    { -9, "Combate de Incendios con Extintores", null },
                    { -8, "NOM-004-STPS-1999", "Sistemas de Proteccion y Diapositivos de Seguridad en la Maquinaria y Equipo (candados y etiquetas)" },
                    { -7, "NOM-028-STPS-2012", "(Organización del trabajo-Seguridad en los procesos y equipos que manejen sustancias quimicas) Apertura de lineas de proceso." },
                    { -6, "NOM-029-STPS-2011", "Mantenimiento de las instalaciones Electricas en los Centros de Trabajo" },
                    { -5, "NOM-018-STPS-2015", "Sistema Globalmente Armonizado para la identificacion y comunicación de peligros y riesgos por sustancias quimicas peligrosas en los centros de trabajo" },
                    { -4, "NOM-005-STPS-1999", "Condiciones de Seguridad e Higiene en los centros de trabajo para el manejo, transporte y almacenamiento de sustancias quimicas peligrosas" },
                    { -3, "NOM-009-STPS-2011", "Trabajos en Altura" },
                    { -2, "Corte y Soldadura", null },
                    { -1, "Espacios Confinados", null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "EmployeeName", "EmployeeType", "Position" },
                values: new object[,]
                {
                    { -40, "Alvarez Martir Christian", 1, "Auxiliar de control de proyectos" },
                    { -39, "Santiago Hernandez Bernabe Esequiel", 2, "Electrico" },
                    { -38, "Villanueva Espinoza Julio Cesar", 1, "Ingeniero A Electrico" },
                    { -37, "Saucedo Ramirez Fernando", 2, "Ayudante General" },
                    { -36, "Saucedo Ramirez Fernando", 2, "Andamiero" },
                    { -35, "Sanchez Mar Nelson Ivan", 2, "Ayudante General" },
                    { -34, "Rodriguez Guerrero Jose Martin", 2, "Electrico" },
                    { -33, "Ramos Ruiz Alberto Ivan", 1, "Control de Materiales" },
                    { -32, "Ramirez Francisco Luis Enrique", 1, "Proyectista" },
                    { -31, "Ramirez Francisco Jonathan", 1, "Cadista Jr" },
                    { -30, "Piñeyro Lara Sergio Israel", 2, "Gerente de Ingenieria" },
                    { -29, "Otero Gonzalez Irma Jessica", 1, "Ingeniero C de Proceso" },
                    { -28, "Osorio Estrella Hector", 2, "Analista de precios unitarios" },
                    { -27, "Nava Comsille Arturo", 1, "Jefe de Ingenieria" },
                    { -26, "Miranda Martinez Andrea", 2, "Ingeniero en procesos c" },
                    { -25, "Melo Rivera Juan Jesus", 2, "Ayudante General" },
                    { -24, "Maya Peña Juan Francisco", 1, "Jefe de ingenieria" },
                    { -23, "Martinez Baeza Francisco", 2, "Auxiliar de control de proyectos" },
                    { -22, "Lopez Pacheco Javier", 2, "Coordinador Electrico e Instrumentacion" },
                    { -21, "Lopez Ochoa Jonathan", 2, "Electrico" },
                    { -20, "Juarez Lopez Leonardo Alejandro", 2, "Supervisor de disciplina" },
                    { -19, "Juarez Lopez Guillermo", 2, "Supervisor de disciplina" },
                    { -18, "Hervert Garibay Ricardo de Jesus", 2, "Ayudante General" },
                    { -17, "Herrera Arteaga Josue", 1, "Ingeniero A de Tuberias" },
                    { -16, "Hernandez Valdez Joel", 2, "Cabo Electrico" },
                    { -15, "Gomez Reyes Edwin De Jesus", 2, "Cadista Jr" },
                    { -14, "Gaspar Flores Jose Ernesto", 1, "Ingeniero A de Tuberias" },
                    { -13, "Diaz Rendon Wendy Montserrat", 2, "Control de documentos" },
                    { -12, "Diaz Rendon Audrey Daniela", 1, "Cadista Jr" },
                    { -11, "Del Angel Del Angel Javier", 1, "Supervisor de Calidad" },
                    { -10, "De La Cruz Mendoza Andres", 1, "Ingeniero b civil y estructuras" },
                    { -9, "Cisneros Zuñiga Gustavo", 2, "Electrico" },
                    { -8, "Cartagena Vicencio Diego Alberto", 1, "Controlador de Proyectos Jr" },
                    { -7, "Cardenas Vargas Carlos", 2, "Jefe de Ingenieria de Confiabilidad" },
                    { -6, "Campos Medina Axel", 2, "Ayudante General" },
                    { -5, "Camacho Aguilar Ricardo", 1, "Especialista A en Instrumentacion" },
                    { -4, "Angeles Hernandez Jesus", 2, "Ayudante General" },
                    { -3, "Alfaro Muñiz Margarito", 1, "Especialista en Tuberias" },
                    { -2, "Alejandre Blanco Javier", 2, "Electrico" },
                    { -1, "Aguilar Gonzalez Armando", 2, "Electrico" }
                });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "Id", "FacilityName" },
                values: new object[,]
                {
                    { -2, "Cabot" },
                    { -1, "Sabic" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeCertifications",
                columns: new[] { "Id", "CertificationId", "EmployeeId", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { -106, -16, -10, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -105, -15, -10, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -104, -12, -10, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -103, -11, -10, new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -102, -10, -10, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -101, -9, -10, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -100, -8, -10, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -99, -7, -10, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -98, -6, -10, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -97, -5, -10, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -96, -4, -10, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -95, -3, -10, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -94, -2, -10, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -93, -1, -10, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -92, -20, -9, new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -91, -17, -9, new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -90, -12, -9, new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -89, -11, -9, new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -88, -10, -9, new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -87, -9, -9, new DateTime(2024, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -86, -8, -9, new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -85, -7, -9, new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -84, -6, -9, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -83, -5, -9, new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -82, -4, -9, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -81, -3, -9, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -80, -2, -9, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -79, -1, -9, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -78, -16, -8, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -77, -12, -8, new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -76, -11, -8, new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -75, -9, -8, new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -74, -8, -8, new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -73, -7, -8, new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -72, -6, -8, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -71, -5, -8, new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -70, -4, -8, new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -69, -3, -8, new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -68, -2, -8, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -67, -1, -8, new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -66, -20, -6, new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -65, -17, -6, new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -64, -16, -6, new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -63, -12, -6, new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -62, -11, -6, new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -61, -9, -6, new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -60, -8, -6, new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -59, -7, -6, new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -58, -6, -6, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -57, -5, -6, new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -56, -4, -6, new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -55, -3, -6, new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -54, -2, -6, new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -53, -1, -6, new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -52, -16, -5, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -51, -14, -5, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -50, -12, -5, new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -49, -11, -5, new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -48, -10, -5, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -47, -9, -5, new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -46, -8, -5, new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -45, -7, -5, new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -44, -6, -5, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -43, -5, -5, new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -42, -4, -5, new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -41, -3, -5, new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -40, -2, -5, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -39, -1, -5, new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -38, -16, -3, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -37, -14, -3, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -36, -12, -3, new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -35, -11, -3, new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -34, -10, -3, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -33, -9, -3, new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -32, -8, -3, new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -31, -7, -3, new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -30, -6, -3, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -29, -5, -3, new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -28, -4, -3, new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -27, -3, -3, new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -26, -2, -3, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -25, -1, -3, new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -24, -19, -2, new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -23, -17, -2, new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -22, -12, -2, new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -21, -11, -2, new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -20, -9, -2, new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -19, -8, -2, new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -18, -7, -2, new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -17, -6, -2, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -16, -5, -2, new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -15, -4, -2, new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -14, -3, -2, new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -13, -2, -2, new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -12, -1, -2, new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -11, -18, -1, new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -10, -17, -1, new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -9, -9, -1, new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -8, -8, -1, new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -7, -7, -1, new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -6, -6, -1, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -5, -5, -1, new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -4, -4, -1, new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -3, -3, -1, new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -2, -2, -1, new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -1, -1, -1, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCertifications_CertificationId",
                table: "EmployeeCertifications",
                column: "CertificationId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCertifications_EmployeeId",
                table: "EmployeeCertifications",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_FacilityCertifications_CertificationId",
                table: "FacilityCertifications",
                column: "CertificationId");

            migrationBuilder.CreateIndex(
                name: "IX_FacilityCertifications_FacilityId",
                table: "FacilityCertifications",
                column: "FacilityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeCertifications");

            migrationBuilder.DropTable(
                name: "FacilityCertifications");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Certifications");

            migrationBuilder.DropTable(
                name: "Facilities");
        }
    }
}
