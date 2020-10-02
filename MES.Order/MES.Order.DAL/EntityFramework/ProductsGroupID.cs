using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MES.Order.DAL.EntityFramework
{
    [Table("ProductsGroupID")]
    public class ProductsGroupID
    {
        [Key]
        public int AutoID { get; set; }

        [StringLength(40)]
        public string ProductGroupID { get; set; }

        [StringLength(40)]
        public string ProductGroupName { get; set; }
    }
}