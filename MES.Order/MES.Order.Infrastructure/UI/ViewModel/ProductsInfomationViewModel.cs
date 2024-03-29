namespace MES.Order.Infrastructure.UI.ViewModel
{
    public class ProductsInfomationViewModel
    {
        /// <summary>
        /// 產品名稱
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 售價
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// 廠商
        /// </summary>
        public string ProductGroupID { get; set; }

        /// <summary>
        /// 批價
        /// </summary>
        public int Cost { get; set; }

        private int _profit;

        /// <summary>
        /// 利潤
        /// </summary>
        public int Profit
        {
            get { return this._profit = this.Price - this.Cost; }
            set => this._profit = value;
        }
    }
}