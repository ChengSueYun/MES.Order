using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Order.DAL.ViewModel
{
    [Table("AddOrderViewModel")]
    public class AddOrderViewModel
    {
        /// <summary>
        /// 地區
        /// </summary>
        [DisplayName("地區")]
        public string Area { get; set; }

        /// <summary>
        /// 客戶名稱
        /// </summary>
        [DisplayName("客戶")]
        public string CustomName { get; set; }

        private string _customId;

        public string CustomID
        {
            get => this._customId = this.CustomName;
            set => this._customId = value;
        }

        private DateTime? _updateDate;

        /// <summary>
        /// 修改日期
        /// </summary>
        [DisplayName("修改日期")]
        public DateTime? UpdateDate
        {
            get => this._updateDate = DateTime.Now;
            set => this._updateDate = value;
        }

        /// <summary>
        /// 訂購數量
        /// </summary>
        [DisplayName("數量")]
        public int Count { get; set; }

        /// <summary>
        /// 是否已取貨
        /// </summary>
        [DisplayName("是否已取貨")]
        public string Address { get; set; }

        private DateTime? _orderDate;

        /// <summary>
        /// 訂購日期
        /// </summary>
        [DisplayName("訂購日期")]
        public DateTime? OrderDate
        {
            get => this._orderDate = DateTime.Today;
            set => this._orderDate = value;
        }

        /// <summary>
        /// 廠商名稱
        /// </summary>
        [DisplayName("廠商")]
        public string ProductGroupID { get; set; }

        /// <summary>
        /// 產品名稱
        /// </summary>
        [DisplayName("產品")]
        public string ProductName { get; set; }

        /// <summary>
        /// 售價
        /// </summary>
        [DisplayName("售價")]
        public int Price { get; set; }

        /// <summary>
        /// 批價
        /// </summary>
        [DisplayName("批價")]
        public int Cost { get; set; }

        private int _totalPrice;

        /// <summary>
        /// 總售價
        /// </summary>
        [DisplayName("總售價")]
        public int TotalPrice
        {
            get => this._totalPrice = this.Count * this.Price;
            set => this._totalPrice = value;
        }

        private int _totalCost;

        /// <summary>
        /// 總成本
        /// </summary>
        [DisplayName("總成本")]
        public int TotalCost
        {
            get => this._totalCost = this.Count * this.Cost;
            set => this._totalCost = value;
        }

        private int _totalProfit;

        /// <summary>
        /// 總利潤
        /// </summary>
        [DisplayName("總利潤")]
        public int TotalProfit
        {
            get => this._totalProfit = this._totalPrice - this._totalCost;
            set => this._totalProfit = value;
        }

        /// <summary>
        /// 備註1
        /// </summary>
        [DisplayName("備註")]
        public string Note1 { get; set; }
    }
}