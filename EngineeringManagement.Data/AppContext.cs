using EngineeringManagement.Data.Models;
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
    }
}