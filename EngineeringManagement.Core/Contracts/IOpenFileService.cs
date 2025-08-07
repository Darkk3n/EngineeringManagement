namespace EngineeringManagement.Core.Contracts
{
   public interface IOpenFileService
   {
      void Execute(string fileName, string startupPath, string employeeName = "");
      void Execute(string fileName);
    }
}