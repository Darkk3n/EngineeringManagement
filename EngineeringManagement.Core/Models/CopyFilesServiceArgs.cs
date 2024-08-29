namespace EngineeringManagement.Core.Models
{
   public class CopyFilesServiceArgs
   {
      public string EmployeeName { get; set; }
      public string FileName { get; set; }
      public string SafeFileName { get; set; }
      public string OriginalFileName { get; set; }
      public string StartupPath { get; set; }
   }
}