namespace THS.MES.MAS.DAL.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Department")]
    public partial class Department
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
        public string DeptID { get; set; }

        [Required]
        [StringLength(10)]
        public string DeptDesc { get; set; }

        [Required]
        [StringLength(30)]
        public string DeptLocalDesc { get; set; }

        [Required]
        [StringLength(10)]
        public string CreateUser { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CreateDateTime { get; set; }

        [Required]
        [StringLength(10)]
        public string CreateWorkstationID { get; set; }

        [Required]
        [StringLength(10)]
        public string ModifiedUser { get; set; }

        [Column(TypeName = "smalldatetime")]
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

        [Column(TypeName = "smalldatetime")]
        public DateTime LockDateTime { get; set; }
    }
}
