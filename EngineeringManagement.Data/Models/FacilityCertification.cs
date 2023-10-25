using System.ComponentModel.DataAnnotations.Schema;

namespace EngineeringManagement.Data.Models
{
    public class FacilityCertification : BaseModel
    {
        [ForeignKey("FacilityCertification_Facility")]
        public int FacilityId { get; set; }

        public virtual Facility Facility { get; set; }

        [ForeignKey("FacilityCertification_Certification")]
        public int CertificationId { get; set; }

        public virtual Certification Certification { get; set; }
    }
}