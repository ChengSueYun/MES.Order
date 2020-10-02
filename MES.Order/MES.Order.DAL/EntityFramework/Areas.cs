using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MES.Order.DAL.EntityFramework
{
    [Table("Area")]
    public class Areas
    {
        [Key]
        public int AutoID { get; set; }

        [Column("Area")]
        [StringLength(40)]
        public string Area { get; set; }

        [StringLength(40)]
        public string AreaName { get; set; }
    }
}