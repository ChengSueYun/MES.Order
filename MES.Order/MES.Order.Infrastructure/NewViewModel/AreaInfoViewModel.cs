using System.ComponentModel.DataAnnotations;

namespace MES.Order.Infrastructure.NewViewModel
{
    public class AreaInfoViewModel
    {
        /// <summary>
        /// 地區
        /// </summary>
        [Required]
        [StringLength(10)]
        [Display(Name = "地區",Prompt = "請輸入地區")]
        public string Area { get; set; }
    }
}