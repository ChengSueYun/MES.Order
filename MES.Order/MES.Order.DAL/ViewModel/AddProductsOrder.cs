using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Order.DAL.ViewModel
{
    public class AddProductsOrder

    {

        public string Area { get; set; }

        public string CustomID { get; set; }

        public string CustomName { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? Count { get; set; }

        public string Address { get; set; }

        public DateTime? OrderDate { get; set; }

        public string ProductGroupID { get; set; }

        public string ProductName { get; set; }

        public string Price { get; set; }

        public int? TotalPrice { get; set; }

        public int? TotalCost { get; set; }

        public int? TotalProfit { get; set; }

        public string Note3 { get; set; }

        public string Note2 { get; set; }

        public string Note1 { get; set; }
    }
}