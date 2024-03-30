using System.ComponentModel.DataAnnotations;

namespace MES.Order.Infrastructure.NewViewModel
{
    public class FactoryInfoViewModel
    {
        /// <summary>
        /// 廠商
        /// </summary>
        [Key]
        [StringLength(10)]
        [Display(Name = "廠商", Prompt = "請輸入廠商")]
        public string Factory { get; set; }

        /// <summary>
        /// 廠商網頁網址
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(300)]
        [Display(Name = "廠商網頁網址", Prompt = "請輸入廠商網頁網址")]
        public string FactoryWebSit { get; set; }
    }
}
