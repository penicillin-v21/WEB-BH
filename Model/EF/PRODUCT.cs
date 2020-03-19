namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRODUCTS")]
    public partial class PRODUCT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCT()
        {
            CARTS = new HashSet<CART>();
            DETAILBILLINs = new HashSet<DETAILBILLIN>();
            ORDERDETAILS = new HashSet<ORDERDETAIL>();
        }

        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Descriptions { get; set; }

        public double? Price { get; set; }

        public double? OriginalPrice { get; set; }

        public string Details { get; set; }

        public int? Stock { get; set; }

        public int? CategoryId { get; set; }

        public int? ViewCount { get; set; }

        public DateTime? DateCreate { get; set; }

        [StringLength(100)]
        public string SeoDescriptioon { get; set; }

        [StringLength(100)]
        public string SeoTitle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CART> CARTS { get; set; }

        public virtual CATEGORy CATEGORy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETAILBILLIN> DETAILBILLINs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDERDETAIL> ORDERDETAILS { get; set; }
    }
}
