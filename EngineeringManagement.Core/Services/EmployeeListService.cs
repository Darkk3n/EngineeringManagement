using EngineeringManagement.Core.Contracts;
using EngineeringManagement.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EngineeringManagement.Core.Services
{
   public class EmployeeListService : IEmployeeListService
   {
      private readonly Data.HrDataContext context;

      public EmployeeListService(Data.HrDataContext context) => this.context = context;

      public IEnumerable<Employee> Get()
      {
         var employees = context.Employees.AsNoTracking().ToList();
         employees.Add(new Employee { Id = 1000000, EmployeeName = "-- SELECCIONE --" });
         return employees;
      }
   }
}