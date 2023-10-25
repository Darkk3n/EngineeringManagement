using System.ComponentModel.DataAnnotations;

namespace EngineeringManagement.Data.Models.Enums
{
    public enum EmployeeType : int
    {
        [Display(Name = "Operativo")]
        Operative = 1,
        [Display(Name = "Administrativo")]
        Administrative = 2
    }
}