using EngineeringManagement.Core.Contracts;
using EngineeringManagement.Core.Extensions;
using EngineeringManagement.Core.Models;

namespace EngineeringManagement.Core.Services
{
   public class CopyFilesService : ICopyFilesService
   {
      public void Execute(CopyFilesServiceArgs serviceArgs)
      {
         var pathToCopy = Path.Combine(serviceArgs.StartupPath, "Documentos", serviceArgs.EmployeeName);
         if (!Directory.Exists(pathToCopy))
         {
            Directory.CreateDirectory(pathToCopy);
         }
         if (!serviceArgs.FileName.HasValue())
         {
            return;
         }
         try
         {
            if (serviceArgs.OriginalFileName.HasValue())
            {
               File.Delete(Path.Combine(pathToCopy, serviceArgs.OriginalFileName));
            }
            File.Copy(serviceArgs.FileName, Path.Combine(pathToCopy, serviceArgs.SafeFileName), true);
         }
         catch (Exception)
         {
            throw;
         }
      }
   }
}