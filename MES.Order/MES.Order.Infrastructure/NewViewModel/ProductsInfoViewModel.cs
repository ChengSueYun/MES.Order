using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace MES.Order.Infrastructure.NewViewModel
{
    public class ProductsInfoViewModel : INotifyPropertyChanged
    {
        private string mFactoryProduct;

        public string FactoryProduct
        {
            get
            {
                if (!string.IsNullOrEmpty(Factory) && !string.IsNullOrEmpty(this.Product))
                {
                    this.mFactoryProduct = $"{this.Factory}-{this.Product}";
                }
                return this.mFactoryProduct;
            }
            set
            {
                if (value == this.mFactoryProduct) return;

                this.mFactoryProduct = value;
                this.OnPropertyChanged();
            }
        }

        private string mFactory;

        /// <summary>
        /// 廠商
        /// </summary>
        [Display(Name = "廠商", Prompt = "請輸入廠商")]
        [Column(Order = 0)]
        [StringLength(10)]
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
                this.OnPropertyChanged(nameof(this.FactoryProduct));
            }
        }

        private string mProduct;

        /// <summary>
        /// 產品
        /// </summary>
        [Display(Name = "產品", Prompt = "請輸入產品")]
        [Column(Order = 1)]
        [StringLength(200)]
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
                this.OnPropertyChanged(nameof(this.FactoryProduct));
            }
        }

        private string mProductType;

        /// <summary>
        /// 產品類別
        /// </summary>
        [Display(Name = "產品類別", Prompt = "請輸入產品類別")]
        [StringLength(10)]
        public string ProductType
        {
            get => this.mProductType;
            set
            {
                if (value == this.mProductType)
                {
                    return;
                }

                this.mProductType = value;
                this.OnPropertyChanged();
            }
        }

        private int mPrice;

        /// <summary>
        /// 金額
        /// </summary>
        [Display(Name = "金額", Prompt = "請輸入金額")]
        public int Price
        {
            get => this.mPrice;
            set
            {
                if (value == this.mPrice)
                {
                    return;
                }

                this.mPrice = value;
                this.OnPropertyChanged();
            }
        }

        private int mCost;

        /// <summary>
        /// 批價
        /// </summary>
        [Display(Name = "批價", Prompt = "請輸入批價")]
        public int Cost
        {
            get => this.mCost;
            set
            {
                if (value == this.mCost)
                {
                    return;
                }

                this.mCost = value;
                this.OnPropertyChanged();
            }
        }

        private int mProfit;

        /// <summary>
        /// 利潤
        /// </summary>
        [Display(Name = "利潤", Prompt = "請輸入利潤")]
        public int Profit
        {
            get => this.mProfit = this.Price - this.Cost;
            set
            {
                if (value == this.mProfit)
                {
                    return;
                }

                this.mProfit = value;
                this.OnPropertyChanged();
            }
        }

        private byte[] mImage;

        /// <summary>
        /// 圖片
        /// </summary>
        [Display(Name = "圖片", Prompt = "請上傳圖片")]
        public byte[] Image
        {
            get => this.mImage;
            set
            {
                if (Equals(value, this.mImage))
                {
                    return;
                }

                this.mImage = value;
                this.OnPropertyChanged();
            }
        }

        private string mProductWebSite;

        /// <summary>
        /// 產品網址
        /// </summary>
        [Display(Name = "產品網址", Prompt = "請輸入產品網址")]
        [StringLength(300)]
        public string ProductWebSite
        {
            get => this.mProductWebSite;
            set
            {
                if (value == this.mProductWebSite)
                {
                    return;
                }

                this.mProductWebSite = value;
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