namespace MES.Order.DAL.NewEntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductsInfo")]
    public partial class ProductsInfo
    {

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Factory { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string Product { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(10)]
        public string ProductType { get; set; }

        public int Price { get; set; }

        public int Cost { get; set; }

        public int Profit { get; set; }

        [Required(AllowEmptyStrings = true)]
        public byte[] Image { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(300)]
        public string ProductWebSite { get; set; }
    }
}
