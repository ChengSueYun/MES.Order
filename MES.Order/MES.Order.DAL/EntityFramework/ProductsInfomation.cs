using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MES.Order.DAL.EntityFramework
{
    [Table("ProductsInfomation")]
    public class ProductsInfomation
    {
        [Key]
        public int AutoID { get; set; }

        [StringLength(40)]
        public string ProductName { get; set; }

        public int? Price { get; set; }

        [StringLength(40)]
        public string ProductGroupID { get; set; }

        public int? Cost { get; set; }

        public int? Profit { get; set; }
    }
}