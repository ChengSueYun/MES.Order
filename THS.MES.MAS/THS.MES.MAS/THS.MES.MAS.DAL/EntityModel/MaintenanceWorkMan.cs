namespace THS.MES.MAS.DAL.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MaintenanceWorkMan
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

        [Key]
        [Column(Order = 4)]
        [StringLength(6)]
        public string ProviderID { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(1)]
        public string OccupationalHazardsCode { get; set; }

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
        public string OccupationalMan { get; set; }

        public DateTime OccupationalDateTime { get; set; }

        [Required]
        [StringLength(1)]
        public string InsuranceStatus { get; set; }

        [Required]
        [StringLength(1)]
        public string HealthCheckUpStatus { get; set; }

        [Required]
        [StringLength(15)]
        public string IdentityID { get; set; }

        public DateTime InsuranceDate { get; set; }

        public DateTime HealthCheckDate { get; set; }

        public DateTime SafetyLicenseDate { get; set; }

        [Required]
        [StringLength(1)]
        public string OvertimeCheck { get; set; }
    }
}
