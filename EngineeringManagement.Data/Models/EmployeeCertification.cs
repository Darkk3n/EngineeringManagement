using System.ComponentModel.DataAnnotations.Schema;

namespace EngineeringManagement.Data.Models
{
    public class EmployeeCertification : BaseModel
    {
        [ForeignKey("FK_EmployeeCertification_Employee")]
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [ForeignKey("FK_EmployeeCertifiction_Certification")]
        public int CertificationId { get; set; }

        public virtual Certification Certification { get; set; }
    }
}