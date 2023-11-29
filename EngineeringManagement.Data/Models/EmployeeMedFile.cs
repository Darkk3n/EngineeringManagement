using System.ComponentModel.DataAnnotations.Schema;
using EngineeringManagement.Data.Models.Enums;

namespace EngineeringManagement.Data.Models
{
    public class EmployeeMedFile : BaseModel
    {
        [ForeignKey("FK_EmployeeMedFile_Employee")]
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }

        public string BloodType { get; set; }

        public string EmergencyPhone { get; set; }

        public string EmergencyName { get; set; }

        public string Relation { get; set; }

        public AbleType? Able { get; set; }
    }
}
