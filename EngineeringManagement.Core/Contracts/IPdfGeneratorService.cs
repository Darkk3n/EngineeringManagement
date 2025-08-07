using EngineeringManagement.Data.Models;

namespace EngineeringManagement.Core.Contracts
{
    public interface IPdfGeneratorService
    {
        void Generate(GeneralEmployee employee, string basePath, string logoPath);
    }
}