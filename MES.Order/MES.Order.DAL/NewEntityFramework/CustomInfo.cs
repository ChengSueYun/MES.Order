namespace MES.Order.DAL.NewEntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomInfo")]
    public partial class CustomInfo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Area { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string Customer { get; set; }

        [Required]
        [StringLength(20)]
        public string FaceBookId { get; set; }

        [Required]
        [StringLength(100)]
        public string FaceBookLink { get; set; }

        [Required]
        [StringLength(50)]
        public string Remark { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CreateDate { get; set; }

        [Required]
        [StringLength(10)]
        public string CreateUser { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime UpdateDate { get; set; }

        [Required]
        [StringLength(10)]
        public string UpdateUser { get; set; }
    }
}
