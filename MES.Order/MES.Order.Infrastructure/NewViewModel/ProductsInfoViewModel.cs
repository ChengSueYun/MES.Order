using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MES.Order.Infrastructure.NewViewModel
{
    public class ProductsInfoViewModel
    {
        /// <summary>
        /// 廠商
        /// </summary>
        [Display(Name = "廠商", Prompt = "請輸入廠商")]
        [Required]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Factory { get; set; }

        /// <summary>
        /// 產品
        /// </summary>
        [Display(Name = "產品", Prompt = "請輸入產品")]
        [Required]
        [Column(Order = 1)]
        [StringLength(200)]
        public string Product { get; set; }

        /// <summary>
        /// 產品類別
        /// </summary>
        [Display(Name = "產品類別", Prompt = "請輸入產品類別")]
        [Required(AllowEmptyStrings = true)]
        [StringLength(10)]
        public string ProductType { get; set; }

        /// <summary>
        /// 金額
        /// </summary>
        [Display(Name = "金額", Prompt = "請輸入金額")]
        public int Price { get; set; }

        /// <summary>
        /// 批價
        /// </summary>
        [Display(Name = "批價", Prompt = "請輸入批價")]
        public int Cost { get; set; }

        /// <summary>
        /// 利潤
        /// </summary>
        [Display(Name = "利潤", Prompt = "請輸入利潤")]
        public int Profit { get; set; }

        /// <summary>
        /// 圖片
        /// </summary>
        [Display(Name = "利潤", Prompt = "請上傳利潤")]
        [Column(TypeName = "image")]
        [Required(AllowEmptyStrings = true)]
        public byte[] Image { get; set; }

        /// <summary>
        /// 產品網址
        /// </summary>
        [Display(Name = "產品網址", Prompt = "請輸入產品網址")]
        [StringLength(300)]
        public string ProductWebSite { get; set; }
    }
}