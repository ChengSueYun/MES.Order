namespace THS.MES.MAS.DAL.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MaintenanceMan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string LocationID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string ProviderID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(4)]
        public string DepartmentID { get; set; }

        [Required]
        [StringLength(10)]
        public string BadgeNo { get; set; }

        public int AccidentInsuranceAmount { get; set; }

        public DateTime AccidentInsuranceDueDate { get; set; }

        [Required]
        [StringLength(100)]
        public string Qualification { get; set; }

        [Required]
        [StringLength(1)]
        public string LaborInsurance { get; set; }

        [Required]
        [StringLength(100)]
        public string OccupationalHazards { get; set; }

        [Required]
        [StringLength(300)]
        public string InformedDate { get; set; }

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

        public DateTime MenStartingDate { get; set; }

        public DateTime MenCompleteDate { get; set; }
    }
}
