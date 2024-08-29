using EngineeringManagement.Data.Models;

namespace EngineeringManagement.Core.Contracts
{
   public interface IEmployeeListService
   {
      IEnumerable<Employee> Get();
   }
}