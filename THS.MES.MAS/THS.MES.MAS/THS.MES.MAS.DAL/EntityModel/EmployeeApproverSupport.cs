namespace THS.MES.MAS.DAL.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeApproverSupport")]
    public partial class EmployeeApproverSupport
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string LocationID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string DeptID { get; set; }

        [Required]
        [StringLength(3)]
        public string SalaryLocationID { get; set; }

        [Required]
        [StringLength(20)]
        public string SalaryDeptID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string EmployeeID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(2)]
        public string SignLevel { get; set; }

        [Required]
        [StringLength(10)]
        public string SupervisorID { get; set; }
    }
}
