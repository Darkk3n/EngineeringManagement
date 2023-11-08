using EngineeringManagement.UI.Extensions;

namespace EngineeringManagement.UI.Services
{
    public static class CopyFilesService
    {
        public static void Execute(CopyFilesServiceArgs serviceArgs)
        {
            var pathToCopy = Path.Combine(Application.StartupPath, "Documentos", serviceArgs.EmployeeName);
            if (!Directory.Exists(pathToCopy))
            {
                Directory.CreateDirectory(pathToCopy);
            }
            if (serviceArgs.FileName.HasValue())
            {
                try
                {
                    if (serviceArgs.OriginalFileName.HasValue())
                    {
                        File.Delete(Path.Combine(pathToCopy, serviceArgs.OriginalFileName));
                    }
                    File.Copy(serviceArgs.FileName, Path.Combine(pathToCopy, serviceArgs.SafeFileName));
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }

    public class CopyFilesServiceArgs
    {
        public string EmployeeName { get; set; }
        public string FileName { get; set; }
        public string SafeFileName { get; set; }
        public string OriginalFileName { get; set; }
    }
}