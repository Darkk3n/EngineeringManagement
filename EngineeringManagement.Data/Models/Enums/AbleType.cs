using System.ComponentModel.DataAnnotations;

namespace EngineeringManagement.Data.Models.Enums
{
    public enum AbleType : int
    {
        [Display(Name = "Apto")]
        Able = 1,
        [Display(Name = "Apto con precauciones")]
        AbleWithCautions = 2,
        [Display(Name = "No Apto")]
        Unable = 3,
    }
}