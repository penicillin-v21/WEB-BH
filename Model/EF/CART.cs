namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CARTS")]
    public partial class CART
    {
        public int Id { get; set; }

        public int? ProductId { get; set; }

        public int? Quantity { get; set; }

        public int? Price { get; set; }

        public virtual PRODUCT PRODUCT { get; set; }
    }
}
