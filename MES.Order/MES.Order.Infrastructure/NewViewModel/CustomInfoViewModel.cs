using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MES.Order.Infrastructure.NewViewModel
{
    public class CustomInfoViewModel

    {
        private string mArea;

        /// <summary>
        /// 地區
        /// </summary>
        [Required]
        [Column(Order = 0)]
        [StringLength(10)]
        [Display(Name = "地區", Prompt = "請輸入地區")]
        public string Area
        {
            get => this.mArea;
            set => this.mArea = value;
        }

        private string mCustomer;

        /// <summary>
        /// 客戶
        /// </summary>
        [Required]
        [Column(Order = 1)]
        [StringLength(40)]
        [Display(Name = "客戶", Prompt = "請輸入客戶")]
        public string Customer
        {
            get => this.mCustomer;
            set => this.mCustomer = value;
        }

        private string mFaceBookId;

        /// <summary>
        /// FaceBook帳號
        /// </summary>
        [StringLength(20)]
        [Display(Name = "FaceBook帳號", Prompt = "請輸入FaceBook帳號")]
        public string FaceBookId
        {
            get => this.mFaceBookId;
            set => this.mFaceBookId = value;
        }

        private string mFaceBookLink;

        /// <summary>
        /// FaceBook個人網址
        /// </summary>
        [StringLength(100)]
        [Display(Name = "FaceBook個人網址", Prompt = "請輸入FaceBook個人網址")]
        public string FaceBookLink
        {
            get => this.mFaceBookLink;
            set => this.mFaceBookLink = value;
        }

        private string mRemark;

        /// <summary>
        /// 備註
        /// </summary>
        [StringLength(50)]
        [Display(Name = "備註", Prompt = "請輸入備註")]
        public string Remark
        {
            get => this.mRemark;
            set => this.mRemark = value;
        }

        private DateTime mCreateDate;

        [Column(TypeName = "smalldatetime")]
        public DateTime CreateDate
        {
            get => this.mCreateDate;
            set => this.mCreateDate = value;
        }


        [StringLength(10)]
        [Display(AutoGenerateField = false)]
        public string CreateUser { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime UpdateDate { get; set; }

        private string mUpdateUser;


        [StringLength(10)]
        public string UpdateUser
        {
            get => this.mUpdateUser;
            set => this.mUpdateUser = value;
        }
    }
}