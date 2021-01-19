using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Order.DAL.ViewModel
{
    public class TakeOrder
    {
        public string Area { get; set; }

        public string CustomerName { get; set; }

        public string ProductName { get; set; }

        public int TotalPrice { get; set; }
    }
}