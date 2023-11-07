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
            if (serviceArgs.LabsFileName.HasValue())
            {
                CopyFile(serviceArgs.LabsFileName, Path.Combine(pathToCopy, serviceArgs.LabsSafeFileName));
            }
            if (serviceArgs.SisositFileName.HasValue())
            {
                CopyFile(serviceArgs.SisositFileName, Path.Combine(pathToCopy, serviceArgs.SisositSafeFileName));
            }
            if (serviceArgs.PictureSafeFileName.HasValue())
            {
                CopyFile(serviceArgs.PictureFileName, Path.Combine(pathToCopy, serviceArgs.PictureSafeFileName));
            }
        }

        private static void CopyFile(string fileName, string pathToCopy)
        {
            try
            {
                File.Copy(fileName, pathToCopy);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

    public class CopyFilesServiceArgs
    {
        public string EmployeeName { get; set; }
        public string LabsFileName { get; set; }
        public string LabsSafeFileName { get; set; }
        public string SisositFileName { get; set; }
        public string SisositSafeFileName { get; set; }
        public string PictureSafeFileName { get; set; }
        public string PictureFileName { get; set; }
    }
}