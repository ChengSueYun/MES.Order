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

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Area { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string Customer { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string Factory { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(200)]
        public string Product { get; set; }

        [Key]
        [Column(TypeName = "datetime",Order = 4)]
        public DateTime OrderDate { get; set; }

        public int Count { get; set; }

        public int TotalPrice { get; set; }

        public int TotalCost { get; set; }

        public int TotalProfit { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(7)]
        public string ColorSpec { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(7)]
        public string SizSpec { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(100)]
        public string Remark { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(20)]
        public string Status { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime UpdateDate { get; set; }
    }
}
