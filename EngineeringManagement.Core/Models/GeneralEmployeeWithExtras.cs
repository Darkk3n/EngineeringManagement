using EngineeringManagement.Data.Models;

namespace EngineeringManagement.Core.Models
{
    public class GeneralEmployeeWithExtras : GeneralEmployee
    {
        public string Category { get; set; }
        public string ProjectNumber { get; set; }
        public decimal SBD { get; set; }
        public decimal SDI { get; set; }
        public string Basket { get; set; }
        public bool Infonavit { get; set; }
        public int UnionPercent { get; set; }
    }
}
