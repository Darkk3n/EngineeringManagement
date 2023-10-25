using System.ComponentModel.DataAnnotations.Schema;

namespace EngineeringManagement.Data.Models
{
    public class EmployeeCertification : BaseModel
    {
        [ForeignKey("FK_EmployeeCertification_Employee")]
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string CertificationName { get; set; }
    }
}