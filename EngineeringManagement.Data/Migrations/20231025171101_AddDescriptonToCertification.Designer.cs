﻿// <auto-generated />
using System;
using EngineeringManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EngineeringManagement.Data.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20231025171101_AddDescriptonToCertification")]
    partial class AddDescriptonToCertification
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("EngineeringManagement.Data.Models.Certification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CertificationName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Certifications");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            CertificationName = "Espacios Confinados"
                        },
                        new
                        {
                            Id = -2,
                            CertificationName = "Corte y Soldadura"
                        },
                        new
                        {
                            Id = -3,
                            CertificationName = "NOM-009-STPS-2011",
                            Description = "Trabajos en Altura"
                        },
                        new
                        {
                            Id = -4,
                            CertificationName = "NOM-018-STPS-2015",
                            Description = "Sistema Globalmente Armonizado para la identificacion y comunicación de peligros y riesgos por sustancias quimicas peligrosas en los centros de trabajo"
                        },
                        new
                        {
                            Id = -5,
                            CertificationName = "NOM-004-STPS-1999",
                            Description = "Sistemas de Proteccion y Diapositivos de Seguridad en la Maquinaria y Equipo (candados y etiquetas)"
                        },
                        new
                        {
                            Id = -6,
                            CertificationName = "NOM-002-STPS-2010",
                            Description = "Condiciones de Seguridad Prevencion y Proteccion contra Incendio en los centros de Trabajo"
                        },
                        new
                        {
                            Id = -7,
                            CertificationName = "Formacion de Armadores de Andamios"
                        },
                        new
                        {
                            Id = -8,
                            CertificationName = "Izajes y Cargas"
                        },
                        new
                        {
                            Id = -9,
                            CertificationName = "Operación segura de plataformas articuladas y elevadas"
                        },
                        new
                        {
                            Id = -10,
                            CertificationName = "NOM-031",
                            Description = "Condiciones de seguridad e higiene"
                        },
                        new
                        {
                            Id = -11,
                            CertificationName = "Uso, revisión, reposición, limpieza, limitaciones, mantenimiento, resguardo y disposición final del equipo de protección personal."
                        },
                        new
                        {
                            Id = -12,
                            CertificationName = "NOM-036"
                        },
                        new
                        {
                            Id = -13,
                            CertificationName = "Manejo de cargas manuales"
                        },
                        new
                        {
                            Id = -14,
                            CertificationName = "NOM-030",
                            Description = "Servicios Preventivos de Seguridad y Salud en el Trabajo"
                        },
                        new
                        {
                            Id = -15,
                            CertificationName = "Trabajos en caliente"
                        },
                        new
                        {
                            Id = -16,
                            CertificationName = "Aperturas de líneas de proceso"
                        },
                        new
                        {
                            Id = -17,
                            CertificationName = "Candados y etiquetas"
                        },
                        new
                        {
                            Id = -18,
                            CertificationName = "NOM-026",
                            Description = "CORRECTA INTERPRETACION DE LOS ELEMENTOS DE SEÑALIZACION DEL CENTRO DE TRABAJO"
                        },
                        new
                        {
                            Id = -19,
                            CertificationName = "NOM-029",
                            Description = "MANTENIMIENTO DE LAS INSTALACIONES ELECTRICAS EN LOS CENTROS DE TRABAJO"
                        });
                });

            modelBuilder.Entity("EngineeringManagement.Data.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("EmployeeType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            EmployeeName = "Aguilar Gonzalez Armando",
                            EmployeeType = 2,
                            Position = "Electrico"
                        },
                        new
                        {
                            Id = -2,
                            EmployeeName = "Alejandre Blanco Javier",
                            EmployeeType = 2,
                            Position = "Electrico"
                        },
                        new
                        {
                            Id = -3,
                            EmployeeName = "Alfaro Muñiz Margarito",
                            EmployeeType = 1,
                            Position = "Especialista en Tuberias"
                        },
                        new
                        {
                            Id = -4,
                            EmployeeName = "Angeles Hernandez Jesus",
                            EmployeeType = 2,
                            Position = "Ayudante General"
                        },
                        new
                        {
                            Id = -5,
                            EmployeeName = "Camacho Aguilar Ricardo",
                            EmployeeType = 1,
                            Position = "Especialista A en Instrumentacion"
                        },
                        new
                        {
                            Id = -6,
                            EmployeeName = "Campos Medina Axel",
                            EmployeeType = 2,
                            Position = "Ayudante General"
                        },
                        new
                        {
                            Id = -7,
                            EmployeeName = "Cardenas Vargas Carlos",
                            EmployeeType = 2,
                            Position = "Jefe de Ingenieria de Confiabilidad"
                        },
                        new
                        {
                            Id = -8,
                            EmployeeName = "Cartagena Vicencio Diego Alberto",
                            EmployeeType = 1,
                            Position = "Controlador de Proyectos Jr"
                        },
                        new
                        {
                            Id = -9,
                            EmployeeName = "Cisneros Zuñiga Gustavo",
                            EmployeeType = 2,
                            Position = "Electrico"
                        },
                        new
                        {
                            Id = -10,
                            EmployeeName = "De La Cruz Mendoza Andres",
                            EmployeeType = 1,
                            Position = "Ingeniero b civil y estructuras"
                        },
                        new
                        {
                            Id = -11,
                            EmployeeName = "Del Angel Del Angel Javier",
                            EmployeeType = 1,
                            Position = "Supervisor de Calidad"
                        },
                        new
                        {
                            Id = -12,
                            EmployeeName = "Diaz Rendon Audrey Daniela",
                            EmployeeType = 1,
                            Position = "Cadista Jr"
                        },
                        new
                        {
                            Id = -13,
                            EmployeeName = "Diaz Rendon Wendy Montserrat",
                            EmployeeType = 2,
                            Position = "Control de documentos"
                        },
                        new
                        {
                            Id = -14,
                            EmployeeName = "Gaspar Flores Jose Ernesto",
                            EmployeeType = 1,
                            Position = "Ingeniero A de Tuberias"
                        },
                        new
                        {
                            Id = -15,
                            EmployeeName = "Gomez Reyes Edwin De Jesus",
                            EmployeeType = 2,
                            Position = "Cadista Jr"
                        },
                        new
                        {
                            Id = -16,
                            EmployeeName = "Hernandez Valdez Joel",
                            EmployeeType = 2,
                            Position = "Cabo Electrico"
                        },
                        new
                        {
                            Id = -17,
                            EmployeeName = "Herrera Arteaga Josue",
                            EmployeeType = 1,
                            Position = "Ingeniero A de Tuberias"
                        },
                        new
                        {
                            Id = -18,
                            EmployeeName = "Hervert Garibay Ricardo de Jesus",
                            EmployeeType = 2,
                            Position = "Ayudante General"
                        },
                        new
                        {
                            Id = -19,
                            EmployeeName = "Juarez Lopez Guillermo",
                            EmployeeType = 2,
                            Position = "Supervisor de disciplina"
                        },
                        new
                        {
                            Id = -20,
                            EmployeeName = "Juarez Lopez Leonardo Alejandro",
                            EmployeeType = 2,
                            Position = "Supervisor de disciplina"
                        },
                        new
                        {
                            Id = -21,
                            EmployeeName = "Lopez Ochoa Jonathan",
                            EmployeeType = 2,
                            Position = "Electrico"
                        },
                        new
                        {
                            Id = -22,
                            EmployeeName = "Lopez Pacheco Javier",
                            EmployeeType = 2,
                            Position = "Coordinador Electrico e Instrumentacion"
                        },
                        new
                        {
                            Id = -23,
                            EmployeeName = "Martinez Baeza Francisco",
                            EmployeeType = 2,
                            Position = "Auxiliar de control de proyectos"
                        },
                        new
                        {
                            Id = -24,
                            EmployeeName = "Maya Peña Juan Francisco",
                            EmployeeType = 1,
                            Position = "Jefe de ingenieria"
                        },
                        new
                        {
                            Id = -25,
                            EmployeeName = "Melo Rivera Juan Jesus",
                            EmployeeType = 2,
                            Position = "Ayudante General"
                        },
                        new
                        {
                            Id = -26,
                            EmployeeName = "Miranda Martinez Andrea",
                            EmployeeType = 2,
                            Position = "Ingeniero en procesos c"
                        },
                        new
                        {
                            Id = -27,
                            EmployeeName = "Nava Comsille Arturo",
                            EmployeeType = 1,
                            Position = "Jefe de Ingenieria"
                        },
                        new
                        {
                            Id = -28,
                            EmployeeName = "Osorio Estrella Hector",
                            EmployeeType = 2,
                            Position = "Analista de precios unitarios"
                        },
                        new
                        {
                            Id = -29,
                            EmployeeName = "Otero Gonzalez Irma Jessica",
                            EmployeeType = 1,
                            Position = "Ingeniero C de Proceso"
                        },
                        new
                        {
                            Id = -30,
                            EmployeeName = "Piñeyro Lara Sergio Israel",
                            EmployeeType = 2,
                            Position = "Gerente de Ingenieria"
                        },
                        new
                        {
                            Id = -31,
                            EmployeeName = "Ramirez Francisco Jonathan",
                            EmployeeType = 1,
                            Position = "Cadista Jr"
                        },
                        new
                        {
                            Id = -32,
                            EmployeeName = "Ramirez Francisco Luis Enrique",
                            EmployeeType = 1,
                            Position = "Proyectista"
                        },
                        new
                        {
                            Id = -33,
                            EmployeeName = "Ramos Ruiz Alberto Ivan",
                            EmployeeType = 1,
                            Position = "Control de Materiales"
                        },
                        new
                        {
                            Id = -34,
                            EmployeeName = "Rodriguez Guerrero Jose Martin",
                            EmployeeType = 2,
                            Position = "Electrico"
                        },
                        new
                        {
                            Id = -35,
                            EmployeeName = "Sanchez Mar Nelson Ivan",
                            EmployeeType = 2,
                            Position = "Ayudante General"
                        },
                        new
                        {
                            Id = -36,
                            EmployeeName = "Saucedo Ramirez Fernando",
                            EmployeeType = 2,
                            Position = "Andamiero"
                        },
                        new
                        {
                            Id = -37,
                            EmployeeName = "Saucedo Ramirez Fernando",
                            EmployeeType = 2,
                            Position = "Ayudante General"
                        },
                        new
                        {
                            Id = -38,
                            EmployeeName = "Villanueva Espinoza Julio Cesar",
                            EmployeeType = 1,
                            Position = "Ingeniero A Electrico"
                        },
                        new
                        {
                            Id = -39,
                            EmployeeName = "Santiago Hernandez Bernabe Esequiel",
                            EmployeeType = 2,
                            Position = "Electrico"
                        },
                        new
                        {
                            Id = -40,
                            EmployeeName = "Alvarez Martir Christian",
                            EmployeeType = 1,
                            Position = "Auxiliar de control de proyectos"
                        });
                });

            modelBuilder.Entity("EngineeringManagement.Data.Models.EmployeeCertification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CertificationName")
                        .HasColumnType("TEXT");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeCertifications");
                });

            modelBuilder.Entity("EngineeringManagement.Data.Models.Facility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FacilityName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Facilities");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            FacilityName = "Sabic"
                        },
                        new
                        {
                            Id = -2,
                            FacilityName = "Cabot"
                        });
                });

            modelBuilder.Entity("EngineeringManagement.Data.Models.FacilityCertification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CertificationId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FacilityId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CertificationId");

                    b.HasIndex("FacilityId");

                    b.ToTable("FacilityCertifications");
                });

            modelBuilder.Entity("EngineeringManagement.Data.Models.EmployeeCertification", b =>
                {
                    b.HasOne("EngineeringManagement.Data.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EngineeringManagement.Data.Models.FacilityCertification", b =>
                {
                    b.HasOne("EngineeringManagement.Data.Models.Certification", "Certification")
                        .WithMany()
                        .HasForeignKey("CertificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EngineeringManagement.Data.Models.Facility", "Facility")
                        .WithMany()
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Certification");

                    b.Navigation("Facility");
                });
#pragma warning restore 612, 618
        }
    }
}
