using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MES.Order.DAL.EntityFramework
{
    [Table("ProductsOrder")]
    public class ProductsOrder
    {
        [Key]
        public int AutoID { get; set; }

        [StringLength(40)]
        public string Area { get; set; }

        [StringLength(40)]
        public string CustomID { get; set; }

        [StringLength(40)]
        public string CustomName { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime UpdateDate { get; set; }

        public int Count { get; set; }

        [StringLength(40)]
        public string Address { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime OrderDate { get; set; }

        [StringLength(40)]
        public string ProductGroupID { get; set; }

        [StringLength(70)]
        public string ProductName { get; set; }

        public int Price { get; set; }

        public int TotalPrice { get; set; }

        public int TotalCost { get; set; }

        public int TotalProfit { get; set; }

        [StringLength(30)]
        public string Note3 { get; set; }

        [StringLength(30)]
        public string Note2 { get; set; }

        [StringLength(30)]
        public string Note1 { get; set; }
    }
}