using EngineeringManagement.Data.Models;
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

            modelBuilder.Entity<Facility>().HasData(new[]
            {
                new Facility{Id=-1,FacilityName="Sabic"},
                new Facility{Id=-2,FacilityName="Cabot"},
            });

            modelBuilder.Entity<Certification>().HasData(new[]
            {
                new Certification{Id = -1, CertificationName = "Espacios Confinados"},
                new Certification{Id = -2, CertificationName = "Corte y Soldadura"},
                new Certification{Id = -3, CertificationName = "NOM-009-STPS-2011", Description = "Trabajos en Altura"},
                new Certification{Id = -4, CertificationName = "NOM-005-STPS-1999", Description = "Condiciones de Seguridad e Higiene en los centros de trabajo para el manejo, transporte y almacenamiento de sustancias quimicas peligrosas"},
                new Certification{Id = -5, CertificationName = "NOM-018-STPS-2015",Description ="Sistema Globalmente Armonizado para la identificacion y comunicación de peligros y riesgos por sustancias quimicas peligrosas en los centros de trabajo"},
                new Certification{Id = -6, CertificationName = "NOM-029-STPS-2011", Description = "Mantenimiento de las instalaciones Electricas en los Centros de Trabajo"},
                new Certification{Id = -7,CertificationName = "NOM-028-STPS-2012", Description = "(Organización del trabajo-Seguridad en los procesos y equipos que manejen sustancias quimicas) Apertura de lineas de proceso."},
                new Certification{Id = -8, CertificationName = "NOM-004-STPS-1999", Description = "Sistemas de Proteccion y Diapositivos de Seguridad en la Maquinaria y Equipo (candados y etiquetas)"},
                new Certification{Id = -9, CertificationName = "Combate de Incendios con Extintores"},
                new Certification{Id = -10, CertificationName = "NOM-002-STPS-2010", Description = "Condiciones de Seguridad Prevencion y Proteccion contra Incendio en los centros de Trabajo"},
                new Certification{Id = -11, CertificationName = "NOM-017- STPS-2008", Description = "Equipo de proteccion personal Selección uso y manejo en los centros de trabajo"},
                new Certification{Id = -12, CertificationName = "NOM-026-STPS-2008", Description = "Colores y señales de seguridad e higiene e identificacion de riesgos conducidas por tuberias"},
                new Certification{Id = -13, CertificationName = "Primeros Auxilios"},
                new Certification{Id = -14, CertificationName = "Formacion de Armadores de Andamios"},
                new Certification{Id = -15, CertificationName = "Izajes y Cargas"},
                new Certification{Id = -16, CertificationName = "Operación segura de plataformas articuladas y elevadas"},
                new Certification{Id = -17, CertificationName = "NOM-031", Description = "Condiciones de seguridad e higiene"},
                new Certification{Id = -18, CertificationName = "Uso, revisión, reposición, limpieza, limitaciones, mantenimiento, resguardo y disposición final del equipo de protección personal."},
                new Certification{Id = -19, CertificationName = "NOM-036", Description = "Manejo de cargas manuales"},
                new Certification{Id = -20, CertificationName = "NOM-030", Description = "Servicios Preventivos de Seguridad y Salud en el Trabajo"},
                new Certification{Id = -21, CertificationName = "Trabajos en caliente"},
                new Certification{Id = -22, CertificationName = "Aperturas de líneas de proceso"},
                new Certification{Id = -23, CertificationName = "Candados y etiquetas"},
                new Certification{Id = -24, CertificationName = "NOM-026", Description = "CORRECTA INTERPRETACION DE LOS ELEMENTOS DE SEÑALIZACION DEL CENTRO DE TRABAJO"},
                new Certification{Id = -25, CertificationName = "NOM-029", Description = "MANTENIMIENTO DE LAS INSTALACIONES ELECTRICAS EN LOS CENTROS DE TRABAJO"},
            });

            modelBuilder.Entity<FacilityCertification>().HasData(new[]
            {
                //Sabic
                new FacilityCertification{Id = -1, FacilityId = -1, CertificationId = -2},
                new FacilityCertification{Id = -2, FacilityId = -2, CertificationId = -9},
                //Cabot
                new FacilityCertification{Id = -3, FacilityId = -2, CertificationId = -10},
                new FacilityCertification{Id = -4, FacilityId = -2, CertificationId = -11},
                new FacilityCertification{Id = -5, FacilityId = -2, CertificationId = -12},
                new FacilityCertification{Id = -6, FacilityId = -2, CertificationId = -13},
                new FacilityCertification{Id = -7, FacilityId = -2, CertificationId = -14},
                new FacilityCertification{Id = -8, FacilityId = -2, CertificationId = -15},
                new FacilityCertification{Id = -9, FacilityId = -2, CertificationId = -16},
                new FacilityCertification{Id = -10, FacilityId = -2, CertificationId = -17},
                //Both
                new FacilityCertification{Id = -11, FacilityId = -1, CertificationId = -1},
                new FacilityCertification{Id = -12, FacilityId = -2, CertificationId = -1},
                new FacilityCertification{Id = -13, FacilityId = -1, CertificationId = -3},
                new FacilityCertification{Id = -14, FacilityId = -2, CertificationId = -3},
                new FacilityCertification{Id = -15, FacilityId = -1, CertificationId = -4},
                new FacilityCertification{Id = -16, FacilityId = -2, CertificationId = -4},
                new FacilityCertification{Id = -17, FacilityId = -1, CertificationId = -5},
                new FacilityCertification{Id = -18, FacilityId = -2, CertificationId = -5},
                new FacilityCertification{Id = -19, FacilityId = -1, CertificationId = -6},
                new FacilityCertification{Id = -20, FacilityId = -2, CertificationId = -6},

            });

            modelBuilder.Entity<EmployeeCertification>().HasData(new[]
            {
               new EmployeeCertification{Id =-1, EmployeeId =-1, CertificationId =-1, StartDate = new DateTime(2023,8,5),EndDate = new DateTime(2024,8,4)},
                new EmployeeCertification{Id =-2, EmployeeId =-1, CertificationId =-2, StartDate = new DateTime(2023,8,1),EndDate = new DateTime(2024,7,31)},
                new EmployeeCertification{Id =-3, EmployeeId =-1, CertificationId =-3, StartDate = new DateTime(2023,8,4),EndDate = new DateTime(2024,8,3)},
                new EmployeeCertification{Id =-4, EmployeeId =-1, CertificationId =-4, StartDate = new DateTime(2023,8,7),EndDate = new DateTime(2024,8,6)},
                new EmployeeCertification{Id =-5, EmployeeId =-1, CertificationId =-5, StartDate = new DateTime(2023,8,9),EndDate = new DateTime(2024,8,8)},
                new EmployeeCertification{Id =-6, EmployeeId =-1, CertificationId =-6, StartDate = new DateTime(2023,8,2),EndDate = new DateTime(2024,8,1)},
                new EmployeeCertification{Id =-7, EmployeeId =-1, CertificationId =-7, StartDate = new DateTime(2023,8,11),EndDate = new DateTime(2024,8,10)},
                new EmployeeCertification{Id =-8, EmployeeId =-1, CertificationId =-8, StartDate = new DateTime(2023,8,10),EndDate = new DateTime(2024,8,9)},
                new EmployeeCertification{Id =-9, EmployeeId =-1, CertificationId =-9, StartDate = new DateTime(2023,8,3),EndDate = new DateTime(2024,8,2)},
                new EmployeeCertification{Id =-10, EmployeeId =-1, CertificationId =-17, StartDate = new DateTime(2023,9,22),EndDate = new DateTime(2024,9,21)},
                new EmployeeCertification{Id =-11, EmployeeId =-1, CertificationId =-18, StartDate = new DateTime(2023,9,18),EndDate = new DateTime(2024,9,17)},
                new EmployeeCertification{Id =-12, EmployeeId =-2, CertificationId =-1, StartDate = new DateTime(2023,8,6),EndDate = new DateTime(2024,8,5)},
                new EmployeeCertification{Id =-13, EmployeeId =-2, CertificationId =-2, StartDate = new DateTime(2023,8,1),EndDate = new DateTime(2024,7,31)},
                new EmployeeCertification{Id =-14, EmployeeId =-2, CertificationId =-3, StartDate = new DateTime(2023,8,4),EndDate = new DateTime(2024,8,3)},
                new EmployeeCertification{Id =-15, EmployeeId =-2, CertificationId =-4, StartDate = new DateTime(2023,8,7),EndDate = new DateTime(2024,8,6)},
                new EmployeeCertification{Id =-16, EmployeeId =-2, CertificationId =-5, StartDate = new DateTime(2023,8,9),EndDate = new DateTime(2024,8,8)},
                new EmployeeCertification{Id =-17, EmployeeId =-2, CertificationId =-6, StartDate = new DateTime(2023,8,2),EndDate = new DateTime(2024,8,1)},
                new EmployeeCertification{Id =-18, EmployeeId =-2, CertificationId =-7, StartDate = new DateTime(2023,8,11),EndDate = new DateTime(2024,8,10)},
                new EmployeeCertification{Id =-19, EmployeeId =-2, CertificationId =-8, StartDate = new DateTime(2023,8,10),EndDate = new DateTime(2024,8,9)},
                new EmployeeCertification{Id =-20, EmployeeId =-2, CertificationId =-9, StartDate = new DateTime(2023,8,3),EndDate = new DateTime(2024,8,2)},
                new EmployeeCertification{Id =-21, EmployeeId =-2, CertificationId =-11, StartDate = new DateTime(2023,9,4),EndDate = new DateTime(2024,9,3)},
                new EmployeeCertification{Id =-22, EmployeeId =-2, CertificationId =-12, StartDate = new DateTime(2023,9,6),EndDate = new DateTime(2024,9,5)},
                new EmployeeCertification{Id =-23, EmployeeId =-2, CertificationId =-17, StartDate = new DateTime(2023,9,22),EndDate = new DateTime(2024,9,21)},
                new EmployeeCertification{Id =-24, EmployeeId =-2, CertificationId =-19, StartDate = new DateTime(2023,9,14),EndDate = new DateTime(2024,9,13)},
                new EmployeeCertification{Id =-25, EmployeeId =-3, CertificationId =-1, StartDate = new DateTime(2023,8,6),EndDate = new DateTime(2024,8,5)},
                new EmployeeCertification{Id =-26, EmployeeId =-3, CertificationId =-2, StartDate = new DateTime(2023,5,22),EndDate = new DateTime(2024,5,21)},
                new EmployeeCertification{Id =-27, EmployeeId =-3, CertificationId =-3, StartDate = new DateTime(2023,8,4),EndDate = new DateTime(2024,8,3)},
                new EmployeeCertification{Id =-28, EmployeeId =-3, CertificationId =-4, StartDate = new DateTime(2023,8,7),EndDate = new DateTime(2024,8,6)},
                new EmployeeCertification{Id =-29, EmployeeId =-3, CertificationId =-5, StartDate = new DateTime(2023,8,9),EndDate = new DateTime(2024,8,8)},
                new EmployeeCertification{Id =-30, EmployeeId =-3, CertificationId =-6, StartDate = new DateTime(2023,5,17),EndDate = new DateTime(2024,5,16)},
                new EmployeeCertification{Id =-31, EmployeeId =-3, CertificationId =-7, StartDate = new DateTime(2023,8,11),EndDate = new DateTime(2024,8,10)},
                new EmployeeCertification{Id =-32, EmployeeId =-3, CertificationId =-8, StartDate = new DateTime(2023,8,10),EndDate = new DateTime(2024,8,9)},
                new EmployeeCertification{Id =-33, EmployeeId =-3, CertificationId =-9, StartDate = new DateTime(2023,8,3),EndDate = new DateTime(2024,8,2)},
                new EmployeeCertification{Id =-34, EmployeeId =-3, CertificationId =-10, StartDate = new DateTime(2022,10,13),EndDate = new DateTime(2023,10,13)},
                new EmployeeCertification{Id =-35, EmployeeId =-3, CertificationId =-11, StartDate = new DateTime(2023,5,10),EndDate = new DateTime(2024,5,9)},
                new EmployeeCertification{Id =-36, EmployeeId =-3, CertificationId =-12, StartDate = new DateTime(2023,5,9),EndDate = new DateTime(2024,5,8)},
                new EmployeeCertification{Id =-37, EmployeeId =-3, CertificationId =-14, StartDate = new DateTime(2022,10,19),EndDate = new DateTime(2023,10,19)},
                new EmployeeCertification{Id =-38, EmployeeId =-3, CertificationId =-16, StartDate = new DateTime(2023,5,4),EndDate = new DateTime(2024,5,3)},
                new EmployeeCertification{Id =-39, EmployeeId =-5, CertificationId =-1, StartDate = new DateTime(2023,8,6),EndDate = new DateTime(2024,8,5)},
                new EmployeeCertification{Id =-40, EmployeeId =-5, CertificationId =-2, StartDate = new DateTime(2023,5,22),EndDate = new DateTime(2024,5,21)},
                new EmployeeCertification{Id =-41, EmployeeId =-5, CertificationId =-3, StartDate = new DateTime(2023,8,4),EndDate = new DateTime(2024,8,3)},
                new EmployeeCertification{Id =-42, EmployeeId =-5, CertificationId =-4, StartDate = new DateTime(2023,8,7),EndDate = new DateTime(2024,8,6)},
                new EmployeeCertification{Id =-43, EmployeeId =-5, CertificationId =-5, StartDate = new DateTime(2023,8,9),EndDate = new DateTime(2024,8,8)},
                new EmployeeCertification{Id =-44, EmployeeId =-5, CertificationId =-6, StartDate = new DateTime(2023,5,17),EndDate = new DateTime(2024,5,16)},
                new EmployeeCertification{Id =-45, EmployeeId =-5, CertificationId =-7, StartDate = new DateTime(2023,8,11),EndDate = new DateTime(2024,8,10)},
                new EmployeeCertification{Id =-46, EmployeeId =-5, CertificationId =-8, StartDate = new DateTime(2023,8,10),EndDate = new DateTime(2024,8,9)},
                new EmployeeCertification{Id =-47, EmployeeId =-5, CertificationId =-9, StartDate = new DateTime(2023,8,3),EndDate = new DateTime(2024,8,2)},
                new EmployeeCertification{Id =-48, EmployeeId =-5, CertificationId =-10, StartDate = new DateTime(2022,10,13),EndDate = new DateTime(2023,10,13)},
                new EmployeeCertification{Id =-49, EmployeeId =-5, CertificationId =-11, StartDate = new DateTime(2023,5,10),EndDate = new DateTime(2024,5,9)},
                new EmployeeCertification{Id =-50, EmployeeId =-5, CertificationId =-12, StartDate = new DateTime(2023,5,9),EndDate = new DateTime(2024,5,8)},
                new EmployeeCertification{Id =-51, EmployeeId =-5, CertificationId =-14, StartDate = new DateTime(2022,10,19),EndDate = new DateTime(2023,10,19)},
                new EmployeeCertification{Id =-52, EmployeeId =-5, CertificationId =-16, StartDate = new DateTime(2023,5,4),EndDate = new DateTime(2024,5,3)},
                new EmployeeCertification{Id =-53, EmployeeId =-6, CertificationId =-1, StartDate = new DateTime(2023,8,6),EndDate = new DateTime(2024,8,5)},
                new EmployeeCertification{Id =-54, EmployeeId =-6, CertificationId =-2, StartDate = new DateTime(2023,8,1),EndDate = new DateTime(2024,7,31)},
                new EmployeeCertification{Id =-55, EmployeeId =-6, CertificationId =-3, StartDate = new DateTime(2023,8,4),EndDate = new DateTime(2024,8,3)},
                new EmployeeCertification{Id =-56, EmployeeId =-6, CertificationId =-4, StartDate = new DateTime(2023,8,7),EndDate = new DateTime(2024,8,6)},
                new EmployeeCertification{Id =-57, EmployeeId =-6, CertificationId =-5, StartDate = new DateTime(2023,8,9),EndDate = new DateTime(2024,8,8)},
                new EmployeeCertification{Id =-58, EmployeeId =-6, CertificationId =-6, StartDate = new DateTime(2023,8,2),EndDate = new DateTime(2024,8,1)},
                new EmployeeCertification{Id =-59, EmployeeId =-6, CertificationId =-7, StartDate = new DateTime(2023,8,11),EndDate = new DateTime(2024,8,10)},
                new EmployeeCertification{Id =-60, EmployeeId =-6, CertificationId =-8, StartDate = new DateTime(2023,8,10),EndDate = new DateTime(2024,8,9)},
                new EmployeeCertification{Id =-61, EmployeeId =-6, CertificationId =-9, StartDate = new DateTime(2023,8,3),EndDate = new DateTime(2024,8,2)},
                new EmployeeCertification{Id =-62, EmployeeId =-6, CertificationId =-11, StartDate = new DateTime(2023,9,4),EndDate = new DateTime(2024,9,3)},
                new EmployeeCertification{Id =-63, EmployeeId =-6, CertificationId =-12, StartDate = new DateTime(2023,9,6),EndDate = new DateTime(2024,9,5)},
                new EmployeeCertification{Id =-64, EmployeeId =-6, CertificationId =-16, StartDate = new DateTime(2023,9,22),EndDate = new DateTime(2024,9,21)},
                new EmployeeCertification{Id =-65, EmployeeId =-6, CertificationId =-17, StartDate = new DateTime(2023,9,4),EndDate = new DateTime(2024,9,3)},
                new EmployeeCertification{Id =-66, EmployeeId =-6, CertificationId =-20, StartDate = new DateTime(2023,9,14),EndDate = new DateTime(2024,9,13)},
                new EmployeeCertification{Id =-67, EmployeeId =-8, CertificationId =-1, StartDate = new DateTime(2023,8,6),EndDate = new DateTime(2024,8,5)},
                new EmployeeCertification{Id =-68, EmployeeId =-8, CertificationId =-2, StartDate = new DateTime(2023,5,22),EndDate = new DateTime(2024,5,21)},
                new EmployeeCertification{Id =-69, EmployeeId =-8, CertificationId =-3, StartDate = new DateTime(2023,5,5),EndDate = new DateTime(2024,5,4)},
                new EmployeeCertification{Id =-70, EmployeeId =-8, CertificationId =-4, StartDate = new DateTime(2023,8,7),EndDate = new DateTime(2024,8,6)},
                new EmployeeCertification{Id =-71, EmployeeId =-8, CertificationId =-5, StartDate = new DateTime(2023,8,9),EndDate = new DateTime(2024,8,8)},
                new EmployeeCertification{Id =-72, EmployeeId =-8, CertificationId =-6, StartDate = new DateTime(2023,5,17),EndDate = new DateTime(2024,5,16)},
                new EmployeeCertification{Id =-73, EmployeeId =-8, CertificationId =-7, StartDate = new DateTime(2023,8,11),EndDate = new DateTime(2024,8,10)},
                new EmployeeCertification{Id =-74, EmployeeId =-8, CertificationId =-8, StartDate = new DateTime(2023,8,10),EndDate = new DateTime(2024,8,9)},
                new EmployeeCertification{Id =-75, EmployeeId =-8, CertificationId =-9, StartDate = new DateTime(2023,8,3),EndDate = new DateTime(2024,8,2)},
                new EmployeeCertification{Id =-76, EmployeeId =-8, CertificationId =-11, StartDate = new DateTime(2023,5,10),EndDate = new DateTime(2024,5,9)},
                new EmployeeCertification{Id =-77, EmployeeId =-8, CertificationId =-12, StartDate = new DateTime(2023,5,9),EndDate = new DateTime(2024,5,8)},
                new EmployeeCertification{Id =-78, EmployeeId =-8, CertificationId =-16, StartDate = new DateTime(2023,5,4),EndDate = new DateTime(2024,5,3)},
                new EmployeeCertification{Id =-79, EmployeeId =-9, CertificationId =-1, StartDate = new DateTime(2023,5,18),EndDate = new DateTime(2024,5,17)},
                new EmployeeCertification{Id =-80, EmployeeId =-9, CertificationId =-2, StartDate = new DateTime(2023,5,22),EndDate = new DateTime(2024,5,21)},
                new EmployeeCertification{Id =-81, EmployeeId =-9, CertificationId =-3, StartDate = new DateTime(2023,5,19),EndDate = new DateTime(2024,5,18)},
                new EmployeeCertification{Id =-82, EmployeeId =-9, CertificationId =-4, StartDate = new DateTime(2023,6,29),EndDate = new DateTime(2024,6,28)},
                new EmployeeCertification{Id =-83, EmployeeId =-9, CertificationId =-5, StartDate = new DateTime(2023,5,13),EndDate = new DateTime(2024,5,12)},
                new EmployeeCertification{Id =-84, EmployeeId =-9, CertificationId =-6, StartDate = new DateTime(2023,5,17),EndDate = new DateTime(2024,5,16)},
                new EmployeeCertification{Id =-85, EmployeeId =-9, CertificationId =-7, StartDate = new DateTime(2023,5,11),EndDate = new DateTime(2024,5,10)},
                new EmployeeCertification{Id =-86, EmployeeId =-9, CertificationId =-8, StartDate = new DateTime(2023,5,12),EndDate = new DateTime(2024,5,11)},
                new EmployeeCertification{Id =-87, EmployeeId =-9, CertificationId =-9, StartDate = new DateTime(2023,9,15),EndDate = new DateTime(2024,9,14)},
                new EmployeeCertification{Id =-88, EmployeeId =-9, CertificationId =-10, StartDate = new DateTime(2023,5,15),EndDate = new DateTime(2024,5,14)},
                new EmployeeCertification{Id =-89, EmployeeId =-9, CertificationId =-11, StartDate = new DateTime(2023,5,10),EndDate = new DateTime(2024,5,9)},
                new EmployeeCertification{Id =-90, EmployeeId =-9, CertificationId =-12, StartDate = new DateTime(2023,5,9),EndDate = new DateTime(2024,5,8)},
                new EmployeeCertification{Id =-91, EmployeeId =-9, CertificationId =-17, StartDate = new DateTime(2023,9,22),EndDate = new DateTime(2024,9,21)},
                new EmployeeCertification{Id =-92, EmployeeId =-9, CertificationId =-20, StartDate = new DateTime(2023,9,14),EndDate = new DateTime(2024,9,13)},
                new EmployeeCertification{Id =-93, EmployeeId =-10, CertificationId =-1, StartDate = new DateTime(2023,1,27),EndDate = new DateTime(2024,1,27)},
                new EmployeeCertification{Id =-94, EmployeeId =-10, CertificationId =-2, StartDate = new DateTime(2023,5,22),EndDate = new DateTime(2024,5,21)},
                new EmployeeCertification{Id =-95, EmployeeId =-10, CertificationId =-3, StartDate = new DateTime(2023,1,25),EndDate = new DateTime(2024,1,25)},
                new EmployeeCertification{Id =-96, EmployeeId =-10, CertificationId =-4, StartDate = new DateTime(2023,1,19),EndDate = new DateTime(2024,1,19)},
                new EmployeeCertification{Id =-97, EmployeeId =-10, CertificationId =-5, StartDate = new DateTime(2023,1,21),EndDate = new DateTime(2024,1,21)},
                new EmployeeCertification{Id =-98, EmployeeId =-10, CertificationId =-6, StartDate = new DateTime(2023,5,17),EndDate = new DateTime(2024,5,16)},
                new EmployeeCertification{Id =-99, EmployeeId =-10, CertificationId =-7, StartDate = new DateTime(2023,1,13),EndDate = new DateTime(2024,1,13)},
                new EmployeeCertification{Id =-100, EmployeeId =-10, CertificationId =-8, StartDate = new DateTime(2023,1,12),EndDate = new DateTime(2024,1,12)},
                new EmployeeCertification{Id =-101, EmployeeId =-10, CertificationId =-9, StartDate = new DateTime(2023,1,17),EndDate = new DateTime(2024,1,17)},
                new EmployeeCertification{Id =-102, EmployeeId =-10, CertificationId =-10, StartDate = new DateTime(2023,1,23),EndDate = new DateTime(2024,1,23)},
                new EmployeeCertification{Id =-103, EmployeeId =-10, CertificationId =-11, StartDate = new DateTime(2023,5,10),EndDate = new DateTime(2024,5,9)},
                new EmployeeCertification{Id =-104, EmployeeId =-10, CertificationId =-12, StartDate = new DateTime(2023,1,16),EndDate = new DateTime(2024,1,16)},
                new EmployeeCertification{Id =-105, EmployeeId =-10, CertificationId =-15, StartDate = new DateTime(2023,1,14),EndDate = new DateTime(2024,1,14)},
                new EmployeeCertification{Id =-106, EmployeeId =-10, CertificationId =-16, StartDate = new DateTime(2023,5,4),EndDate = new DateTime(2024,5,3)},
            });
        }
    }
}