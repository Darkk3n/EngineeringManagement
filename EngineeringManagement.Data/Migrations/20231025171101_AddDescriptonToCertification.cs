using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EngineeringManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDescriptonToCertification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Certifications",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "CertificationName", "Description" },
                values: new object[,]
                {
                    { -19, "NOM-029", "MANTENIMIENTO DE LAS INSTALACIONES ELECTRICAS EN LOS CENTROS DE TRABAJO" },
                    { -18, "NOM-026", "CORRECTA INTERPRETACION DE LOS ELEMENTOS DE SEÑALIZACION DEL CENTRO DE TRABAJO" },
                    { -17, "Candados y etiquetas", null },
                    { -16, "Aperturas de líneas de proceso", null },
                    { -15, "Trabajos en caliente", null },
                    { -14, "NOM-030", "Servicios Preventivos de Seguridad y Salud en el Trabajo" },
                    { -13, "Manejo de cargas manuales", null },
                    { -12, "NOM-036", null },
                    { -11, "Uso, revisión, reposición, limpieza, limitaciones, mantenimiento, resguardo y disposición final del equipo de protección personal.", null },
                    { -10, "NOM-031", "Condiciones de seguridad e higiene" },
                    { -9, "Operación segura de plataformas articuladas y elevadas", null },
                    { -8, "Izajes y Cargas", null },
                    { -7, "Formacion de Armadores de Andamios", null },
                    { -6, "NOM-002-STPS-2010", "Condiciones de Seguridad Prevencion y Proteccion contra Incendio en los centros de Trabajo" },
                    { -5, "NOM-004-STPS-1999", "Sistemas de Proteccion y Diapositivos de Seguridad en la Maquinaria y Equipo (candados y etiquetas)" },
                    { -4, "NOM-018-STPS-2015", "Sistema Globalmente Armonizado para la identificacion y comunicación de peligros y riesgos por sustancias quimicas peligrosas en los centros de trabajo" },
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -40);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -39);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -38);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -37);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -36);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -35);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -34);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -33);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -32);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -31);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Certifications");
        }
    }
}
