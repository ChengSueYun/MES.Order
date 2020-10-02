using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MES.Order.DAL.EntityFramework
{
    [Table("Custom")]
    public class Custom
    {
        [StringLength(50)]
        public string CustomName { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime UpdateDate { get; set; }

        [StringLength(50)]
        public string 備註 { get; set; }

        [StringLength(50)]
        public string 備註1 { get; set; }

        [StringLength(50)]
        public string 備註2 { get; set; }

        [Key]
        public int AutoID { get; set; }

        [StringLength(50)]
        public string CustomID { get; set; }
    }
}