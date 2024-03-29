using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MES.Order.Infrastructure.NewViewModel
{
    public class OrderInfoViewModel
    {
        /// <summary>
        /// 地區
        /// </summary>
        [Required]
        [Column(Order = 0)]
        [StringLength(10)]
        [Display(Name = "地區", Prompt = "請輸入地區")]
        public string Area { get; set; }

        /// <summary>
        /// 客戶
        /// </summary>
        [Required]
        [Column(Order = 1)]
        [StringLength(15)]
        [Display(Name = "客戶", Prompt = "請輸入客戶")]
        public string Customer { get; set; }

        /// <summary>
        /// 廠商
        /// </summary>
        [Required]
        [Column(Order = 2)]
        [StringLength(10)]
        [Display(Name = "廠商", Prompt = "請輸入廠商")]
        public string Factory { get; set; }

        /// <summary>
        /// 產品
        /// </summary>
        [Required]
        [Column(Order = 3)]
        [StringLength(100)]
        [Display(Name = "產品", Prompt = "請輸入產品")]
        public string Product { get; set; }

        /// <summary>
        /// 訂購日期
        /// </summary>
        [Column(TypeName = "smalldatetime")]
        [Display(Name = "訂購日期", Prompt = "請輸入訂購日期")]
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// 訂購數量
        /// </summary>
        [Display(Name = "訂購數量", Prompt = "請輸入訂購數量")]
        public int Count { get; set; }

        /// <summary>
        /// 訂購總金額
        /// </summary>
        [Display(Name = "訂購總金額", Prompt = "請輸入訂購總金額")]
        public int TotalPrice { get; set; }

        /// <summary>
        /// 訂購總批價
        /// </summary>
        [Display(Name = "訂購總批價", Prompt = "請輸入訂購總批價")]
        public int TotalCost { get; set; }

        /// <summary>
        /// 訂購總利潤
        /// </summary>
        [Display(Name = "訂購總利潤", Prompt = "請輸入訂購總利潤")]
        public int TotalProfit { get; set; }

        /// <summary>
        /// 顏色規格
        /// </summary>
        [Display(Name = "顏色規格", Prompt = "請輸入顏色規格")]
        [StringLength(7)]
        public string ColorSpec { get; set; }

        /// <summary>
        /// 尺寸規格
        /// </summary>
        [Display(Name = "尺寸規格", Prompt = "請輸入尺寸規格")]
        [StringLength(7)]
        public string SizSpec { get; set; }

        /// <summary>
        /// 備註
        /// </summary>
        [Display(Name = "備註", Prompt = "請輸入備註")]
        [StringLength(100)]
        public string Remark { get; set; }

        [Required]
        [StringLength(3)]
        public string Status { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime UpdateDate { get; set; }
    }
}
