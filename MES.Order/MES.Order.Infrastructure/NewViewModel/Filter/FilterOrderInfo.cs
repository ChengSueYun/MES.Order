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