namespace MES.Order.DAL.NewEntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderInfo")]
    public partial class OrderInfo
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

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string Factory { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string Product { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime OrderDate { get; set; }

        public int Count { get; set; }

        public int TotalPrice { get; set; }

        public int TotalCost { get; set; }

        public int TotalProfit { get; set; }

        [Required]
        [StringLength(7)]
        public string ColorSpec { get; set; }

        [Required]
        [StringLength(7)]
        public string SizSpec { get; set; }

        [Required]
        [StringLength(100)]
        public string Remark { get; set; }

        [Required]
        [StringLength(3)]
        public string Status { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime UpdateDate { get; set; }
    }
}
