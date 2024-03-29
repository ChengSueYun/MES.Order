using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MES.Order.Infrastructure.Annotations;

namespace MES.Order.Infrastructure.UI.Order
{
    public class FilterProductsOrderRequest : INotifyPropertyChanged
    {
        private string       _area;
        private string       _customerName;
        private string       _productGroupId;
        private string       _productName;
        private DateTime     _orderDateS;
        private DateTime     _orderDateE;
        private List<string> _customerNames;

        /// <summary>
        /// 地區
        /// </summary>
        [DisplayName("地區")]
        public string Area
        {
            get => this._area ?? "全部";
            set
            {
                if (value.Equals(this._area))
                {
                    return;
                }

                this._area = value;
                this.OnPropertyChanged();
            }
        }

        /// <summary>
        /// 客戶名稱
        /// </summary>
        [DisplayName("客戶名稱")]
        public string CustomerName
        {
            get => this._customerName ?? "全部";
            set
            {
                if (value.Equals(this._customerName))
                {
                    return;
                }

                this._customerName = value;
                this.OnPropertyChanged();
            }
        }

        public List<string> CustomerNames
        {
            get => this._customerNames ?? new List<string>();
            set => this._customerNames = value;
        }

        /// <summary>
        /// 廠商名稱
        /// </summary>
        [DisplayName("廠商名稱")]
        public string ProductGroupID
        {
            get => this._productGroupId ?? "全部";
            set
            {
                if (value.Equals(this._productGroupId))
                {
                    return;
                }

                this._productGroupId = value;
                this.OnPropertyChanged();
            }
        }

        /// <summary>
        /// 產品名稱
        /// </summary>
        [DisplayName("產品名稱")]
        public string ProductName
        {
            get => this._productName ?? "全部";
            set
            {
                if (value.Equals(this._productName))
                {
                    return;
                }

                this._productName = value;
                this.OnPropertyChanged();
            }
        }

        /// <summary>
        /// 訂貨起日
        /// </summary>
        [DisplayName("訂貨起日")]
        public DateTime OrderDateS
        {
            get => this._orderDateS = DateTime.Today;
            set
            {
                if (value.Equals(this._orderDateS))
                {
                    return;
                }

                this._orderDateS = value;
                this.OnPropertyChanged();
            }
        }

        /// <summary>
        /// 訂貨迄日
        /// </summary>
        [DisplayName("訂貨迄日")]
        public DateTime OrderDateE
        {
            get => this._orderDateE = DateTime.Today.AddMonths(-3);
            set
            {
                if (value.Equals(this._orderDateE))
                {
                    return;
                }

                this._orderDateE = value;
                this.OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}