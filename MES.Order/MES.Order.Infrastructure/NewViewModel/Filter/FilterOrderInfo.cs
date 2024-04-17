using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MES.Order.Infrastructure.NewViewModel.Filter
{
    /// <summary>
    /// 查詢訂單的Model
    /// </summary>
    public class FilterOrderInfo : INotifyPropertyChanged
    {
        private string mArea;

        /// <summary>
        /// 地區
        /// </summary>
        [Column(Order = 0)]
        [StringLength(10)]
        [Display(Name = "地區", Prompt = "請輸入地區")]
        public string Area
        {
            get => this.mArea;

            set
            {
                if (value == this.mArea) return;

                this.mArea = value;
                this.OnPropertyChanged();
            }
        }

        private string mCustomer;

        /// <summary>
        /// 客戶
        /// </summary>
        [Column(Order = 1)]
        [StringLength(40)]
        [Display(Name = "客戶", Prompt = "請輸入客戶")]
        public string Customer
        {
            get => this.mCustomer;

            set
            {
                if (value == this.mCustomer)
                {
                    return;
                }

                this.mCustomer = value;
                this.OnPropertyChanged();
            }
        }

        private string mFactory;

        /// <summary>
        /// 廠商
        /// </summary>
        [Column(Order = 2)]
        [StringLength(10)]
        [Display(Name = "廠商", Prompt = "請輸入廠商")]
        public string Factory
        {
            get => this.mFactory;

            set
            {
                if (value == this.mFactory)
                {
                    return;
                }

                this.mFactory = value;
                this.OnPropertyChanged();
            }
        }

        private string mProduct;

        /// <summary>
        /// 產品
        /// </summary>
        
        [Column(Order = 3)]
        [StringLength(200)]
        [Display(Name = "產品", Prompt = "請輸入產品")]
        public string Product
        {
            get => this.mProduct;

            set
            {
                if (value == this.mProduct)
                {
                    return;
                }

                this.mProduct = value;
                this.OnPropertyChanged();
            }
        }
        private DateTime mOrderDateStart;

        /// <summary>
        /// 訂購起日
        /// </summary>
        [Display(Name = "訂購起日", Prompt = "請輸入訂購起日")]
        public DateTime OrderDateStart
        {
            get => this.mOrderDateStart;
            set
            {
                if (value.Equals(this.mOrderDateStart))
                {
                    return;
                }

                this.mOrderDateStart = value;
                this.OnPropertyChanged();
            }
        }

        private DateTime mOrderDateEnd;

        /// <summary>
        /// 訂購迄日
        /// </summary>
        [Display(Name = "訂購迄日", Prompt = "請輸入訂購迄日")]
        public DateTime OrderDateEnd
        {
            get => this.mOrderDateEnd;
            set
            {
                if (value.Equals(this.mOrderDateEnd))
                {
                    return;
                }

                this.mOrderDateEnd = value;
                this.OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField < T >(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;

            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}