namespace MES.Order.DAL.NewEntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FactoryInfo")]
    public partial class FactoryInfo
    {

        [Key]
        [StringLength(10)]
        public string Factory { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(300)]
        public string FactoryWebSit { get; set; }
    }
}
