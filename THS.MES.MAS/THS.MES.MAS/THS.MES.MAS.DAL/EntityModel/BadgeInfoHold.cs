namespace THS.MES.MAS.DAL.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BadgeInfoHold")]
    public partial class BadgeInfoHold
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoID { get; set; }

        [Required]
        [StringLength(3)]
        public string LocationID { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short BadgeYear { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BadgeSequenceNo { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string ProviderID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short WorkYear { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(13)]
        public string WorkID { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(1)]
        public string AskCode { get; set; }

        [Required]
        [StringLength(10)]
        public string AskUser { get; set; }

        public DateTime AskDateTime { get; set; }

        [Required]
        [StringLength(10)]
        public string AskWorkstationID { get; set; }

        [Required]
        [StringLength(10)]
        public string CreateUser { get; set; }

        public DateTime CreateDateTime { get; set; }

        [Required]
        [StringLength(10)]
        public string CreateWorkstationID { get; set; }

        [Required]
        [StringLength(10)]
        public string ModifiedUser { get; set; }

        public DateTime ModifiedDateTime { get; set; }

        [Required]
        [StringLength(10)]
        public string ModifiedWorkstationID { get; set; }
    }
}
