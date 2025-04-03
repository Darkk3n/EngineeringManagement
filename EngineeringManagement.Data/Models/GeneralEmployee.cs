using System.ComponentModel.DataAnnotations;
using EngineeringManagement.Data.Models.Enums;

namespace EngineeringManagement.Data.Models
{
    public class GeneralEmployee : BaseModel
    {
        public int? EmployeeId { get; set; }

        [MaxLength(255)]
        public string EmployeeName { get; set; }

        public string StartDate { get; set; }

        public string RenewalDate { get; set; }

        public string JobDescription { get; set; }

        public string WorkCellPhone { get; set; }

        public string PersonalCellPhone { get; set; }

        public string Curp { get; set; }

        public string Rfc { get; set; }

        public string SocialSecurityNumber { get; set; }

        public string Email { get; set; }

        public string EmergencyPhoneNumber { get; set; }

        public string EmergencyContactName { get; set; }

        public string EmergencyContactRelationShip { get; set; }

        public string BloodType { get; set; }

        public EmployeeType EmployeeType { get; set; }

        public string MaritalStatus { get; set; }

        public bool? HasJobReferences { get; set; }
        public bool? HasVotingCard { get; set; }
        public bool? HasCurp { get; set; }
        public bool? HasNss { get; set; }
        public bool? HasDrivingLicense { get; set; }
        public bool? HasInfonavit { get; set; }
        public bool? HasSat { get; set; }
        public bool? HasProofOfStudies { get; set; }
        public bool? HasBankStatement { get; set; }
        public bool? Has2Pictures { get; set; }
        public bool? HasProofOfAddress { get; set; }
        public bool? Has2RecomendationLetters { get; set; }
        public bool? HasCellPhone { get; set; }
        public bool? HasEquipment { get; set; }
        public bool? HasComputer { get; set; }
        public bool? HasVehicle { get; set; }
        public bool? HasUniforms { get; set; }
        public string PictureFileName { get; set; }

        [StringLength(1000)]
        public string Address { get; set; }

        public string HospitalNumber { get; set; }
        public string InfonavitNumber { get; set; }
        public string InfonavitPercent { get; set; }
        public string FonacotClientNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string AcademicDegree { get; set; }
        public string AcademicDegreeDocument { get; set; }
        public string Profession { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public int BenefitiaryPercent { get; set; }
        public DateTime? BenefitiaryBirthDate { get; set; }
        public int BankAccountNumber { get; set; }
        public int BankAccountCard { get; set; }
        public string BankName { get; set; }
    }
}