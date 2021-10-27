namespace THS.MES.MAS.DAL.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vendor")]
    public partial class Vendor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string TransactFlag { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime TransDate { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string VendorID { get; set; }

        [Required]
        [StringLength(10)]
        public string VendorName { get; set; }

        [Required]
        [StringLength(50)]
        public string VendorFullName { get; set; }

        [Required]
        [StringLength(10)]
        public string VatNo { get; set; }

        [Required]
        [StringLength(16)]
        public string PhoneNo { get; set; }

        [Required]
        [StringLength(16)]
        public string FaxNo { get; set; }

        [Required]
        [StringLength(120)]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        public string ContactPerson { get; set; }

        [Required]
        [StringLength(16)]
        public string ContactPhone { get; set; }

        [Required]
        [StringLength(16)]
        public string ContactMphone { get; set; }

        [Required]
        [StringLength(50)]
        public string ContactEmail { get; set; }

        [Required]
        [StringLength(3)]
        public string AreaID { get; set; }

        [Required]
        [StringLength(1)]
        public string ActiveFlag { get; set; }

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
        [StringLength(50)]
        public string LockUser { get; set; }

        public DateTime LockDateTime { get; set; }
    }
}
