namespace THS.MES.MAS.DAL.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccessRule")]
    public partial class AccessRule
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string LocationID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(9)]
        public string RuleNo { get; set; }

        [Required]
        [StringLength(1)]
        public string RuleType { get; set; }

        public DateTime ExpirationDate { get; set; }

        [Required]
        [StringLength(150)]
        public string Resume { get; set; }

        [Required]
        [StringLength(50)]
        public string FileName { get; set; }

        [Required]
        [StringLength(150)]
        public string FilePath { get; set; }

        [Required]
        [StringLength(1)]
        public string TipCode { get; set; }

        public DateTime TipDate { get; set; }

        [Required]
        [StringLength(4)]
        public string TipRange { get; set; }

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
    }
}
