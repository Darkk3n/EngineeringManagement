using System.ComponentModel.DataAnnotations;

namespace EngineeringManagement.Data.Models
{
    public class Facility : BaseModel
    {
        [Required]
        public string FacilityName { get; set; }
    }
}