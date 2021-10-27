namespace THS.MES.MAS.DAL.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaintenanceWork")]
    public partial class MaintenanceWork
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string LocationID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string WorkType { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short WorkYear { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(13)]
        public string WorkID { get; set; }

        [Required]
        [StringLength(1)]
        public string InsuranceCheck { get; set; }

        [Required]
        [StringLength(50)]
        public string WorkBrief { get; set; }

        [Required]
        [StringLength(6)]
        public string ProviderID { get; set; }

        [Required]
        [StringLength(50)]
        public string WorkingPlace { get; set; }

        [Required]
        [StringLength(4)]
        public string RequiringDepartment { get; set; }

        [Required]
        [StringLength(50)]
        public string ResponsiblePerson { get; set; }

        [Required]
        [StringLength(30)]
        public string ContactPerson { get; set; }

        [Required]
        [StringLength(30)]
        public string LogisticPerson { get; set; }

        public DateTime StartingDate { get; set; }

        public DateTime CompleteDate { get; set; }

        [Required]
        [StringLength(6)]
        public string WorkingFrom { get; set; }

        [Required]
        [StringLength(6)]
        public string WorkingTo { get; set; }

        public int EngineeringInsuranceAmount { get; set; }

        public DateTime EngineeringInsuranceDueDate { get; set; }

        [Required]
        [StringLength(100)]
        public string QualificationRequire { get; set; }

        [Required]
        [StringLength(1)]
        public string CloseCode { get; set; }

        [Required]
        [StringLength(10)]
        public string CreateUser { get; set; }

        public DateTime CreateDateTime { get; set; }

        [Required]
        [StringLength(10)]
        public string CreateWorkstationID { get; set; }

        [Required]
        [StringLength(10)]
        public string ModifiedUser { get; set; }

        public DateTime ModifiedDateTime { get; set; }

        [Required]
        [StringLength(10)]
        public string ModifiedWorkstationID { get; set; }

        [Required]
        [StringLength(1)]
        public string LockFlag { get; set; }

        [Required]
        [StringLength(10)]
        public string LockUser { get; set; }

        public DateTime LockDateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string MailContactPerson { get; set; }

        [Required]
        [StringLength(15)]
        public string Extension { get; set; }

        [Required]
        [StringLength(1)]
        public string CrossDayCheck { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUserName { get; set; }

        [Required]
        [StringLength(4)]
        public string CreateUserDeptID { get; set; }

        [Required]
        [StringLength(15)]
        public string ContactPersonPhone { get; set; }

        [Required]
        [StringLength(1)]
        public string AllowEnterCar { get; set; }

        public DateTime ContractStratDate { get; set; }

        public DateTime ContractEndDate { get; set; }

        [Required]
        [StringLength(30)]
        public string InsurancePerson { get; set; }

        [Required]
        [StringLength(10)]
        public string ContractModifiedUser { get; set; }

        public DateTime InsuranceDate { get; set; }

        public DateTime HealthCheckDate { get; set; }

        public DateTime SafetyLicenseDate { get; set; }
    }
}
