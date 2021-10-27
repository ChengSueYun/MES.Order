namespace THS.MES.MAS.DAL.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EntranceLog")]
    public partial class EntranceLog
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
        [StringLength(2)]
        public string WorkType { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short WorkYear { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(13)]
        public string WorkID { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(30)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SequenceNo { get; set; }

        [Required]
        [StringLength(4)]
        public string DepartmentID { get; set; }

        [Required]
        [StringLength(10)]
        public string BadgeNo { get; set; }

        public DateTime IncomingDateTime { get; set; }

        public DateTime LeavingDateTime { get; set; }

        [Required]
        [StringLength(100)]
        public string CarryOnItems { get; set; }

        [Required]
        [StringLength(50)]
        public string Exceed { get; set; }

        [Required]
        [StringLength(20)]
        public string OfficialPermission { get; set; }

        [Required]
        [StringLength(50)]
        public string Remark { get; set; }

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
        [StringLength(10)]
        public string LicensePlatNumber { get; set; }

        [Required]
        [StringLength(1)]
        public string InsuranceStatus { get; set; }

        [Required]
        [StringLength(1)]
        public string HealthCheckUpStatus { get; set; }

        [Required]
        [StringLength(15)]
        public string IdentityID { get; set; }

        [Required]
        [StringLength(1)]
        public string OccupationalHazardsCode { get; set; }
    }
}
