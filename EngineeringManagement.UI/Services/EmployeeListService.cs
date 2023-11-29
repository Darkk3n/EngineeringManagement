using EngineeringManagement.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EngineeringManagement.UI.Services
{
    public class EmployeeListService
    {
        public IEnumerable<Employee> Get()
        {
            using var context = new Data.AppContext();
            var employees = context.Employees.AsNoTracking().ToList();
            employees.Add(new Employee { Id = 1000000, EmployeeName = "-- SELECCIONE --" });
            return employees;
        }
    }
}