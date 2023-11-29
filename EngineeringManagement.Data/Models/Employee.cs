using EngineeringManagement.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace EngineeringManagement.Data.Models
{
    public class Employee : BaseModel
    {
        [Required]
        [Display(Name = "Colaborador")]
        public string EmployeeName { get; set; }

        [Required]
        [Display(Name = "Puesto")]
        public string Position { get; set; }

        [Required]
        public EmployeeType EmployeeType { get; set; } = EmployeeType.Operative;

        public string Curp { get; set; }

        public string LabsFileName { get; set; }

        public string SisositFileName { get; set; }

        public string PictureFileName { get; set; }

        public int SocialSecurityNumber { get; set; }
    }
}