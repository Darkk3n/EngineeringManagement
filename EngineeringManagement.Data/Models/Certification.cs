using System.ComponentModel.DataAnnotations;

namespace EngineeringManagement.Data.Models
{
    public class Certification : BaseModel
    {
        [Required]
        public string CertificationName { get; set; }

        public string Description { get; set; }
    }
}