using EngineeringManagement.Core.Models;
using EngineeringManagement.Data.Models;

namespace EngineeringManagement.Core.Contracts
{
    public interface IPdfGeneratorService
    {
        void Generate(GeneralEmployeeWithExtras employee, string basePath, string logoPath);
    }
}