using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace MES.Order.Infrastructure.NewViewModel
{
    public class OrderInfoViewModel : INotifyPropertyChanged
    {
        public bool Selection
        {
            get => _selection;

            set
            {
                if (value == _selection) return;
                _selection = value;
                OnPropertyChanged();
            }
        }

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

        private DateTime mOrderDate;

        /// <summary>
        /// 訂購日期
        /// </summary>
        [Column(TypeName = "datetime")]
        [Display(Name = "訂購日期", Prompt = "請輸入訂購日期")]
        public DateTime OrderDate
        {
            get => this.mOrderDate = DateTime.Now;

            set
            {
                if (value.Equals(this.mOrderDate)) return;

                this.mOrderDate = value;
                this.OnPropertyChanged();
            }
        }

        private int mCount;

        /// <summary>
        /// 訂購數量
        /// </summary>
        [Display(Name = "訂購數量", Prompt = "請輸入訂購數量")]
        public int Count
        {
            get => this.mCount;

            set
            {
                if (value == this.mCount)
                {
                    return;
                }

                this.mCount = value;
                this.OnPropertyChanged();
            }
        }

        private int mTotalPrice;

        /// <summary>
        /// 訂購總金額
        /// </summary>
        [Display(Name = "訂購總金額", Prompt = "請輸入訂購總金額")]
        public int TotalPrice
        {
            get => this.mTotalPrice;

            set
            {
                if (value == this.mTotalPrice)
                {
                    return;
                }

                this.mTotalPrice = value;
                this.OnPropertyChanged();
                this.OnPropertyChanged(nameof(this.TotalProfit));
            }
        }

        private int mTotalCost;

        /// <summary>
        /// 訂購總批價
        /// </summary>
        [Display(Name = "訂購總批價", Prompt = "請輸入訂購總批價")]
        public int TotalCost
        {
            get => this.mTotalCost;

            set
            {
                if (value == this.mTotalCost)
                {
                    return;
                }

                this.mTotalCost = value;
                this.OnPropertyChanged();
                this.OnPropertyChanged(nameof(this.TotalProfit));
            }
        }

        private int mTotalProfit;
        private INotifyCollectionChanged mNotifyCollectionChangedImplementation;

        /// <summary>
        /// 訂購總利潤
        /// </summary>
        [Display(Name = "訂購總利潤", Prompt = "請輸入訂購總利潤")]
        public int TotalProfit
        {
            get => this.mTotalProfit = this.TotalPrice - this.TotalCost;

            set
            {
                if (value == this.mTotalProfit) return;

                this.mTotalProfit = value;
                this.OnPropertyChanged();
            }
        }

        private string mColorSpec;

        /// <summary>
        /// 顏色規格
        /// </summary>
        [Display(Name = "顏色規格", Prompt = "請輸入顏色規格")]
        [StringLength(7)]
        public string ColorSpec
        {
            get => this.mColorSpec;

            set
            {
                if (value == this.mColorSpec)
                {
                    return;
                }

                this.mColorSpec = value;
                this.OnPropertyChanged();
            }
        }

        private string mSizSpec;

        /// <summary>
        /// 尺寸規格
        /// </summary>
        [Display(Name = "尺寸規格", Prompt = "請輸入尺寸規格")]
        [StringLength(7)]
        public string SizSpec
        {
            get => this.mSizSpec;

            set
            {
                if (value == this.mSizSpec)
                {
                    return;
                }

                this.mSizSpec = value;
                this.OnPropertyChanged();
            }
        }

        private string mRemark;

        /// <summary>
        /// 備註
        /// </summary>
        [Display(Name = "備註", Prompt = "請輸入備註")]
        [StringLength(100)]
        public string Remark
        {
            get => this.mRemark;

            set
            {
                if (value == this.mRemark)
                {
                    return;
                }

                this.mRemark = value;
                this.OnPropertyChanged();
            }
        }

        private string mStatus;

        
        [StringLength(20)]
        public string Status
        {
            get => this.mStatus;

            set
            {
                if (value == this.mStatus)
                {
                    return;
                }

                this.mStatus = value;
                this.OnPropertyChanged();
            }
        }

        private DateTime mUpdateDate;
        private bool _selection;

        [Column(TypeName = "smalldatetime")]
        public DateTime UpdateDate
        {
            get => this.mUpdateDate;

            set
            {
                if (value.Equals(this.mUpdateDate))
                {
                    return;
                }

                this.mUpdateDate = value;
                this.OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;

            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}