namespace THS.MES.MAS.DAL.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_AccessApplication
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string ProviderID { get; set; }

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

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string WorkBrief { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string WorkingPlace { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(30)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(4)]
        public string RequiringDepartment { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string ResponsiblePerson { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(15)]
        public string Extension { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(30)]
        public string ContactPerson { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(30)]
        public string LogisticPerson { get; set; }

        [Key]
        [Column(Order = 12)]
        public DateTime StartingDate { get; set; }

        [Key]
        [Column(Order = 13)]
        public DateTime CompleteDate { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(6)]
        public string WorkingFrom { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(6)]
        public string WorkingTo { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EngineeringInsuranceAmount { get; set; }

        [Key]
        [Column(Order = 17)]
        public DateTime EngineeringInsuranceDueDate { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(100)]
        public string QualificationRequire { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(1)]
        public string CloseCode { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(10)]
        public string CreateUser { get; set; }

        [Key]
        [Column(Order = 21)]
        public DateTime CreateDateTime { get; set; }

        [Key]
        [Column(Order = 22)]
        [StringLength(10)]
        public string CreateWorkstationID { get; set; }

        [Key]
        [Column(Order = 23)]
        [StringLength(10)]
        public string ModifiedUser { get; set; }

        [Key]
        [Column(Order = 24)]
        public DateTime ModifiedDateTime { get; set; }

        [Key]
        [Column(Order = 25)]
        [StringLength(10)]
        public string ModifiedWorkstationID { get; set; }

        [Key]
        [Column(Order = 26)]
        [StringLength(50)]
        public string MailContactPerson { get; set; }

        [Key]
        [Column(Order = 27)]
        [StringLength(1)]
        public string InsuranceCheck { get; set; }

        [Key]
        [Column(Order = 28)]
        [StringLength(1)]
        public string CrossDayCheck { get; set; }

        [Key]
        [Column(Order = 29)]
        [StringLength(4)]
        public string CreateUserDeptID { get; set; }

        public short? BadgeYear { get; set; }

        public int? BadgeSequenceNo { get; set; }

        [Key]
        [Column(Order = 30)]
        [StringLength(1)]
        public string OccupationalHazardsCode { get; set; }

        [Key]
        [Column(Order = 31)]
        [StringLength(50)]
        public string CreateUserName { get; set; }

        [Key]
        [Column(Order = 32)]
        [StringLength(3)]
        public string LocationID { get; set; }

        [Key]
        [Column(Order = 33)]
        [StringLength(30)]
        public string ProviderName { get; set; }

        [Key]
        [Column(Order = 34)]
        [StringLength(8000)]
        public string BadgeNo { get; set; }

        [Key]
        [Column(Order = 35)]
        [StringLength(134)]
        public string GroupColumn { get; set; }

        [Key]
        [Column(Order = 36)]
        [StringLength(15)]
        public string ContactPersonPhone { get; set; }

        [Key]
        [Column(Order = 37)]
        [StringLength(1)]
        public string AllowEnterCar { get; set; }

        [Key]
        [Column(Order = 38)]
        [StringLength(10)]
        public string OccupationalMan { get; set; }

        [Key]
        [Column(Order = 39)]
        public DateTime OccupationalDateTime { get; set; }

        [Key]
        [Column(Order = 40)]
        public DateTime ContractStratDate { get; set; }

        [Key]
        [Column(Order = 41)]
        public DateTime ContractEndDate { get; set; }

        [Key]
        [Column(Order = 42)]
        [StringLength(30)]
        public string InsurancePerson { get; set; }

        [Key]
        [Column(Order = 43)]
        [StringLength(10)]
        public string ContractModifiedUser { get; set; }

        [Key]
        [Column(Order = 44)]
        [StringLength(15)]
        public string IdentityID { get; set; }

        [Key]
        [Column(Order = 45)]
        [StringLength(1)]
        public string InsuranceStatus { get; set; }
    }
}
