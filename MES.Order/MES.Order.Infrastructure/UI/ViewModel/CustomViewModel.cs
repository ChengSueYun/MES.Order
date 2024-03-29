using System;

namespace MES.Order.Infrastructure.UI.ViewModel
{
    public class CustomViewModel
    {
        /// <summary>
        /// 客戶名稱
        /// </summary>
        public string CustomName { get; set; }

        /// <summary>
        /// 地區
        /// <para>Area</para>
        /// </summary>
        public string Address { get; set; }

        public DateTime UpdateDate { get; set; } = DateTime.Today;

        public string 備註 { get; set; }

        public string 備註1 { get; set; }

        public string 備註2 { get; set; }

        public int AutoID { get; set; }

        private string _customId;

        /// <summary>
        /// 客戶名稱
        /// </summary>
        public string CustomID
        {
            get => this._customId = this.CustomName;
            set => this._customId = value;
        }
    }
}