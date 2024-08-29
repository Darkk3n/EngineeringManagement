using EngineeringManagement.Core.Models;

namespace EngineeringManagement.Core.Contracts
{
   public interface ICopyFilesService
   {
      void Execute(CopyFilesServiceArgs serviceArgs);
   }
}