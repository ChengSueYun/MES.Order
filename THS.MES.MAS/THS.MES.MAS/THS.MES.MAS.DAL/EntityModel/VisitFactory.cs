namespace THS.MES.MAS.DAL.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VisitFactory")]
    public partial class VisitFactory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string LocationID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime EnterDate { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string VendorID { get; set; }

        [Required]
        [StringLength(10)]
        public string VendorName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(30)]
        public string ProjectID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(6)]
        public string ReceptionDept { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(2)]
        public string VisitID { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(10)]
        public string IDnumber { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime EnterDateTime { get; set; }

        public DateTime OutDateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string VisitorName { get; set; }

        [Required]
        [StringLength(16)]
        public string ContactPhone { get; set; }

        [Required]
        [StringLength(1)]
        public string CertificateType { get; set; }

        [Required]
        [StringLength(5)]
        public string CertificateID { get; set; }

        [Required]
        [StringLength(1)]
        public string SendMail { get; set; }

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

        [StringLength(20)]
        public string Receptionist { get; set; }

        [StringLength(50)]
        public string Mark { get; set; }
    }
}
