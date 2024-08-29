using System.Diagnostics;
using EngineeringManagement.Core.Contracts;
using EngineeringManagement.Core.Extensions;

namespace EngineeringManagement.Core.Services
{
   public class OpenFileService : IOpenFileService
   {
      public void Execute(string fileName, string startupPath, string employeeName = "")
      {
         Process.Start(new ProcessStartInfo
         {
            FileName = employeeName.HasValue()
                ? Path.Combine(startupPath, "Documentos", employeeName, fileName)
                : fileName,
            UseShellExecute = true
         });
      }
   }
}
