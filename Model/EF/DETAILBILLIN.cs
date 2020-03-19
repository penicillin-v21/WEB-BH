namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DETAILBILLIN")]
    public partial class DETAILBILLIN
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BillId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        public double? OriginalPrice { get; set; }

        public int? Quantity { get; set; }

        public int? ProciderId { get; set; }

        public virtual BILLIN BILLIN { get; set; }

        public virtual PRODUCT PRODUCT { get; set; }

        public virtual PROVIDER PROVIDER { get; set; }
    }
}
