using System;

namespace MES.Order.Infrastructure.UI.Order
{
    public class ProductsOrderViewModel

    {
        /// <summary>
        /// 地區
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// 客戶名稱
        /// </summary>
        public string CustomID { get; set; }

        /// <summary>
        /// 客戶名稱
        /// </summary>
        public string CustomName { get; set; }

        public DateTime UpdateDate { get; set; }

        /// <summary>
        /// 購買數量
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 是否已取貨
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 訂購日期
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// 廠商名稱
        /// </summary>
        public string ProductGroupID { get; set; }

        /// <summary>
        /// 產品名稱
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 售價
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// 總售價
        /// </summary>
        public int TotalPrice { get; set; }

        /// <summary>
        /// 總批價
        /// </summary>
        public int TotalCost { get; set; }

        /// <summary>
        /// 總利潤
        /// </summary>
        public int TotalProfit { get; set; }

        /// <summary>
        /// 備註3
        /// </summary>
        public string Note3 { get; set; }

        /// <summary>
        /// 備註2
        /// </summary>
        public string Note2 { get; set; }

        /// <summary>
        /// 備註1
        /// </summary>
        public string Note1 { get; set; }
    }
}