using System.ComponentModel.DataAnnotations.Schema;

namespace MES.Order.DAL.ViewModel
{
    [Table("KeyAndNameForCombo")]
    public class KeyAndNameForCombo
    {
        public string Code { get; set; }

        public string LocalDescription { get; set; }
    }
}