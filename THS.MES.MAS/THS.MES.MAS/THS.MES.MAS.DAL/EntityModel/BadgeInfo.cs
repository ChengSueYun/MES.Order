namespace THS.MES.MAS.DAL.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BadgeInfo")]
    public partial class BadgeInfo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoID { get; set; }

        [Required]
        [StringLength(3)]
        public string LocationID { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short BadgeYear { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BadgeSequenceNo { get; set; }

        public DateTime ExpirationDate { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string ProviderID { get; set; }

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

        [Required]
        [StringLength(1)]
        public string VoidCode { get; set; }

        [Required]
        [StringLength(50)]
        public string VoidUser { get; set; }

        public DateTime VoidDateTime { get; set; }

        [Required]
        [StringLength(10)]
        public string VoidWorkstationID { get; set; }

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
        [StringLength(1)]
        public string DepositStatus { get; set; }

        public DateTime DepositReceiveDate { get; set; }

        public DateTime DepositReturnDate { get; set; }

        [Required]
        [StringLength(30)]
        public string DepositReceivePerson { get; set; }

        [Required]
        [StringLength(30)]
        public string DepositReturnPerson { get; set; }

        [Required]
        [StringLength(50)]
        public string IssuedUser { get; set; }

        public DateTime IssueDate { get; set; }

        [Required]
        [StringLength(1)]
        public string Useflag { get; set; }

        [Required]
        [StringLength(1)]
        public string Type { get; set; }

        [Required]
        [StringLength(100)]
        public string ManagementRemark { get; set; }

        [Required]
        [StringLength(100)]
        public string AccountingRemark { get; set; }

        [Required]
        [StringLength(15)]
        public string IdentityID { get; set; }
    }
}
