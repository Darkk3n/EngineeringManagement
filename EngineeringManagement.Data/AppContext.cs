﻿using EngineeringManagement.Data.Models;
using EngineeringManagement.Data.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace EngineeringManagement.Data
{
    public class AppContext : DbContext
    {
        public AppContext()
        {
        }

        public AppContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<EmployeeCertification> EmployeeCertifications { get; set; }
        public DbSet<FacilityCertification> FacilityCertifications { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = EngineeringManagement.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new[]
            {
                new Employee{ Id =-1,EmployeeName="Aguilar Gonzalez Armando", EmployeeType=EmployeeType.Administrative, Position="Electrico"},
                new Employee{Id =-2,EmployeeName="Alejandre Blanco Javier", EmployeeType=EmployeeType.Administrative, Position="Electrico"},
                new Employee{Id =-3,EmployeeName="Alfaro Muñiz Margarito", EmployeeType=EmployeeType.Operative, Position="Especialista en Tuberias"},
                new Employee{Id =-4,EmployeeName="Angeles Hernandez Jesus", EmployeeType=EmployeeType.Administrative, Position="Ayudante General"},
                new Employee{Id =-5,EmployeeName="Camacho Aguilar Ricardo", EmployeeType=EmployeeType.Operative, Position="Especialista A en Instrumentacion"},
                new Employee{Id =-6,EmployeeName="Campos Medina Axel", EmployeeType=EmployeeType.Administrative, Position="Ayudante General"},
                new Employee{Id =-7,EmployeeName="Cardenas Vargas Carlos", EmployeeType=EmployeeType.Administrative, Position="Jefe de Ingenieria de Confiabilidad"},
                new Employee{Id =-8,EmployeeName="Cartagena Vicencio Diego Alberto", EmployeeType=EmployeeType.Operative, Position="Controlador de Proyectos Jr"},
                new Employee{Id =-9,EmployeeName="Cisneros Zuñiga Gustavo", EmployeeType=EmployeeType.Administrative, Position="Electrico"},
                new Employee{Id =-10,EmployeeName="De La Cruz Mendoza Andres", EmployeeType=EmployeeType.Operative, Position="Ingeniero b civil y estructuras"},
                new Employee{Id =-11,EmployeeName="Del Angel Del Angel Javier", EmployeeType=EmployeeType.Operative, Position="Supervisor de Calidad"},
                new Employee{Id =-12,EmployeeName="Diaz Rendon Audrey Daniela", EmployeeType=EmployeeType.Operative, Position="Cadista Jr"},
                new Employee{Id =-13,EmployeeName="Diaz Rendon Wendy Montserrat", EmployeeType=EmployeeType.Administrative, Position="Control de documentos"},
                new Employee{Id =-14,EmployeeName="Gaspar Flores Jose Ernesto", EmployeeType=EmployeeType.Operative, Position="Ingeniero A de Tuberias"},
                new Employee{Id =-15,EmployeeName="Gomez Reyes Edwin De Jesus", EmployeeType=EmployeeType.Administrative, Position="Cadista Jr"},
                new Employee{Id =-16,EmployeeName="Hernandez Valdez Joel", EmployeeType=EmployeeType.Administrative, Position="Cabo Electrico"},
                new Employee{Id =-17,EmployeeName="Herrera Arteaga Josue", EmployeeType=EmployeeType.Operative, Position="Ingeniero A de Tuberias"},
                new Employee{Id =-18,EmployeeName="Hervert Garibay Ricardo de Jesus", EmployeeType=EmployeeType.Administrative, Position="Ayudante General"},
                new Employee{Id =-19,EmployeeName="Juarez Lopez Guillermo", EmployeeType=EmployeeType.Administrative, Position="Supervisor de disciplina"},
                new Employee{Id =-20,EmployeeName="Juarez Lopez Leonardo Alejandro", EmployeeType=EmployeeType.Administrative, Position="Supervisor de disciplina"},
                new Employee{Id =-21,EmployeeName="Lopez Ochoa Jonathan", EmployeeType=EmployeeType.Administrative, Position="Electrico"},
                new Employee{Id =-22,EmployeeName="Lopez Pacheco Javier", EmployeeType=EmployeeType.Administrative, Position="Coordinador Electrico e Instrumentacion"},
                new Employee{Id =-23,EmployeeName="Martinez Baeza Francisco", EmployeeType=EmployeeType.Administrative, Position="Auxiliar de control de proyectos"},
                new Employee{Id =-24,EmployeeName="Maya Peña Juan Francisco", EmployeeType=EmployeeType.Operative, Position="Jefe de ingenieria"},
                new Employee{Id =-25,EmployeeName="Melo Rivera Juan Jesus", EmployeeType=EmployeeType.Administrative, Position="Ayudante General"},
                new Employee{Id =-26,EmployeeName="Miranda Martinez Andrea", EmployeeType=EmployeeType.Administrative, Position="Ingeniero en procesos c"},
                new Employee{Id =-27,EmployeeName="Nava Comsille Arturo", EmployeeType=EmployeeType.Operative, Position="Jefe de Ingenieria"},
                new Employee{Id =-28,EmployeeName="Osorio Estrella Hector", EmployeeType=EmployeeType.Administrative, Position="Analista de precios unitarios"},
                new Employee{Id =-29,EmployeeName="Otero Gonzalez Irma Jessica", EmployeeType=EmployeeType.Operative, Position="Ingeniero C de Proceso"},
                new Employee{Id =-30,EmployeeName="Piñeyro Lara Sergio Israel", EmployeeType=EmployeeType.Administrative, Position="Gerente de Ingenieria"},
                new Employee{Id =-31,EmployeeName="Ramirez Francisco Jonathan", EmployeeType=EmployeeType.Operative, Position="Cadista Jr"},
                new Employee{Id =-32,EmployeeName="Ramirez Francisco Luis Enrique", EmployeeType=EmployeeType.Operative, Position="Proyectista"},
                new Employee{Id =-33,EmployeeName="Ramos Ruiz Alberto Ivan", EmployeeType=EmployeeType.Operative, Position="Control de Materiales"},
                new Employee{Id =-34,EmployeeName="Rodriguez Guerrero Jose Martin", EmployeeType=EmployeeType.Administrative, Position="Electrico"},
                new Employee{Id =-35,EmployeeName="Sanchez Mar Nelson Ivan", EmployeeType=EmployeeType.Administrative, Position="Ayudante General"},
                new Employee{Id =-36,EmployeeName="Saucedo Ramirez Fernando", EmployeeType=EmployeeType.Administrative, Position="Andamiero"},
                new Employee{Id =-37,EmployeeName="Saucedo Ramirez Fernando", EmployeeType=EmployeeType.Administrative, Position="Ayudante General"},
                new Employee{Id =-38,EmployeeName="Villanueva Espinoza Julio Cesar", EmployeeType=EmployeeType.Operative, Position="Ingeniero A Electrico"},
                new Employee{Id =-39,EmployeeName="Santiago Hernandez Bernabe Esequiel", EmployeeType=EmployeeType.Administrative, Position="Electrico"},
                new Employee{Id =-40,EmployeeName="Alvarez Martir Christian", EmployeeType=EmployeeType.Operative, Position="Auxiliar de control de proyectos"},
            });
        }
    }
}