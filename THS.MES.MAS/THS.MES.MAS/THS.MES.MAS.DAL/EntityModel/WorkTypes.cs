namespace THS.MES.MAS.DAL.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WorkType")]
    public partial class WorkTypes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoID { get; set; }

        [Key]
        [Column("WorkType")]
        [StringLength(2)]
        public string WorkType { get; set; }

        [Required]
        [StringLength(20)]
        public string WorkTypeBrief { get; set; }

        [Required]
        [StringLength(100)]
        public string WorkTypeLocalBrief { get; set; }

        [Required]
        [StringLength(60)]
        public string ValidDepartment { get; set; }

        [Required]
        [StringLength(30)]
        public string ExceptDepartment { get; set; }

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
