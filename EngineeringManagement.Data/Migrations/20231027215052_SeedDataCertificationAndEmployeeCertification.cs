using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EngineeringManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataCertificationAndEmployeeCertification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CertificationName", "Description" },
                values: new object[] { "NOM-036", "Manejo de cargas manuales" });

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CertificationName", "Description" },
                values: new object[] { "Uso, revisión, reposición, limpieza, limitaciones, mantenimiento, resguardo y disposición final del equipo de protección personal.", null });

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CertificationName", "Description" },
                values: new object[] { "NOM-031", "Condiciones de seguridad e higiene" });

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -16,
                column: "CertificationName",
                value: "Operación segura de plataformas articuladas y elevadas");

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -15,
                column: "CertificationName",
                value: "Izajes y Cargas");

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CertificationName", "Description" },
                values: new object[] { "Formacion de Armadores de Andamios", null });

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -13,
                column: "CertificationName",
                value: "Primeros Auxilios");

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CertificationName", "Description" },
                values: new object[] { "NOM-026-STPS-2008", "Colores y señales de seguridad e higiene e identificacion de riesgos conducidas por tuberias" });

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CertificationName", "Description" },
                values: new object[] { "NOM-017- STPS-2008", "Equipo de proteccion personal Selección uso y manejo en los centros de trabajo" });

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CertificationName", "Description" },
                values: new object[] { "NOM-002-STPS-2010", "Condiciones de Seguridad Prevencion y Proteccion contra Incendio en los centros de Trabajo" });

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -9,
                column: "CertificationName",
                value: "Combate de Incendios con Extintores");

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CertificationName", "Description" },
                values: new object[] { "NOM-004-STPS-1999", "Sistemas de Proteccion y Diapositivos de Seguridad en la Maquinaria y Equipo (candados y etiquetas)" });

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CertificationName", "Description" },
                values: new object[] { "NOM-028-STPS-2012", "(Organización del trabajo-Seguridad en los procesos y equipos que manejen sustancias quimicas) Apertura de lineas de proceso." });

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CertificationName", "Description" },
                values: new object[] { "NOM-029-STPS-2011", "Mantenimiento de las instalaciones Electricas en los Centros de Trabajo" });

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CertificationName", "Description" },
                values: new object[] { "NOM-018-STPS-2015", "Sistema Globalmente Armonizado para la identificacion y comunicación de peligros y riesgos por sustancias quimicas peligrosas en los centros de trabajo" });

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CertificationName", "Description" },
                values: new object[] { "NOM-005-STPS-1999", "Condiciones de Seguridad e Higiene en los centros de trabajo para el manejo, transporte y almacenamiento de sustancias quimicas peligrosas" });

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
                    { -20, "NOM-030", "Servicios Preventivos de Seguridad y Salud en el Trabajo" }
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
                    { -1, -1, -1, new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -92, -20, -9, new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -66, -20, -6, new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -106);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -105);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -104);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -103);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -102);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -101);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -100);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -99);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -98);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -97);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -96);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -95);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -94);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -93);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -92);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -91);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -90);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -89);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -88);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -87);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -86);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -85);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -84);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -83);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -82);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -81);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -80);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -79);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -78);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -77);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -76);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -75);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -74);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -73);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -72);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -71);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -70);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -69);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -68);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -67);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -66);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -65);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -64);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -63);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -62);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -61);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -60);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -59);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -58);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -57);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -56);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -55);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -54);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -53);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -52);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -51);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -50);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -49);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -48);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -47);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -46);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -45);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -44);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -43);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -42);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -41);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -40);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -39);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -38);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -37);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -36);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -35);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -34);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -33);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -32);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -31);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "EmployeeCertifications",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CertificationName", "Description" },
                values: new object[] { "NOM-029", "MANTENIMIENTO DE LAS INSTALACIONES ELECTRICAS EN LOS CENTROS DE TRABAJO" });

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CertificationName", "Description" },
                values: new object[] { "NOM-026", "CORRECTA INTERPRETACION DE LOS ELEMENTOS DE SEÑALIZACION DEL CENTRO DE TRABAJO" });

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CertificationName", "Description" },
                values: new object[] { "Candados y etiquetas", null });

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -16,
                column: "CertificationName",
                value: "Aperturas de líneas de proceso");

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -15,
                column: "CertificationName",
                value: "Trabajos en caliente");

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CertificationName", "Description" },
                values: new object[] { "NOM-030", "Servicios Preventivos de Seguridad y Salud en el Trabajo" });

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -13,
                column: "CertificationName",
                value: "Manejo de cargas manuales");

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CertificationName", "Description" },
                values: new object[] { "NOM-036", null });

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CertificationName", "Description" },
                values: new object[] { "Uso, revisión, reposición, limpieza, limitaciones, mantenimiento, resguardo y disposición final del equipo de protección personal.", null });

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CertificationName", "Description" },
                values: new object[] { "NOM-031", "Condiciones de seguridad e higiene" });

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -9,
                column: "CertificationName",
                value: "Operación segura de plataformas articuladas y elevadas");

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CertificationName", "Description" },
                values: new object[] { "Izajes y Cargas", null });

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CertificationName", "Description" },
                values: new object[] { "Formacion de Armadores de Andamios", null });

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CertificationName", "Description" },
                values: new object[] { "NOM-002-STPS-2010", "Condiciones de Seguridad Prevencion y Proteccion contra Incendio en los centros de Trabajo" });

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CertificationName", "Description" },
                values: new object[] { "NOM-004-STPS-1999", "Sistemas de Proteccion y Diapositivos de Seguridad en la Maquinaria y Equipo (candados y etiquetas)" });

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CertificationName", "Description" },
                values: new object[] { "NOM-018-STPS-2015", "Sistema Globalmente Armonizado para la identificacion y comunicación de peligros y riesgos por sustancias quimicas peligrosas en los centros de trabajo" });
        }
    }
}
