namespace THS.MES.MAS.DAL.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MASSystemParameter")]
    public partial class MASSystemParameter
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string ParameterTabID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string DefinitionCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string DefinitionValue { get; set; }

        [Required]
        [StringLength(50)]
        public string DefinitionDesc { get; set; }

        [Required]
        [StringLength(50)]
        public string DefinitionLocalDesc { get; set; }

        [Required]
        [StringLength(2)]
        public string StatusCode { get; set; }

        [Required]
        [StringLength(10)]
        public string CreateUser { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CreateDateTime { get; set; }

        [Required]
        [StringLength(10)]
        public string CreateWorkstationID { get; set; }

        [Required]
        [StringLength(10)]
        public string ModifiedUser { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ModifiedDateTime { get; set; }

        [Required]
        [StringLength(10)]
        public string ModifiedWorkstationID { get; set; }

        [Required]
        [StringLength(1)]
        public string LockFlag { get; set; }

        [Required]
        [StringLength(50)]
        public string LockUser { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime LockDateTime { get; set; }
    }
}
