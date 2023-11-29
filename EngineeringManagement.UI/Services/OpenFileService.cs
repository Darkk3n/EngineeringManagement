using System.Diagnostics;
using EngineeringManagement.UI.Extensions;

namespace EngineeringManagement.UI.Services
{
    public class OpenFileService
    {
        public static void Execute(string fileName, string employeeName = "")
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = employeeName.HasValue()
                ? Path.Combine(Application.StartupPath, "Documentos", employeeName, fileName)
                : fileName,
                UseShellExecute = true
            });
        }
    }
}