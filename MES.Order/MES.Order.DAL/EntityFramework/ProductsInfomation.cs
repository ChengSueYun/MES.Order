using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MES.Order.DAL.EntityFramework
{
    [Table("ProductsInfomation")]
    public class ProductsInfomation
    {
        [Key]
        public int AutoID { get; set; }

        [StringLength(70)]
        public string ProductName { get; set; }

        public int Price { get; set; }

        [StringLength(40)]
        public string ProductGroupID { get; set; }

        public int Cost { get; set; }

        private int _profit;

        public int Profit
        {
            get
            {
                return this._profit = this.Price - this.Cost;
            }
            set => this._profit = value;
        }
    }
}