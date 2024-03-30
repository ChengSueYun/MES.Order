namespace MES.Order.DAL.NewEntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AreaInfo")]
    public partial class AreaInfo
    {

        [Key]
        [StringLength(10)]
        public string Area { get; set; }
    }
}
