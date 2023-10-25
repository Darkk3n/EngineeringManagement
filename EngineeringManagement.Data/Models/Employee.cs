using EngineeringManagement.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace EngineeringManagement.Data.Models
{
    public class Employee : BaseModel
    {
        [Required]
        public string EmployeeName { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public EmployeeType EmployeeType { get; set; } = EmployeeType.Operative;
    }
}