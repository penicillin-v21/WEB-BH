namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATEGORIES")]
    public partial class CATEGORy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CATEGORy()
        {
            PRODUCTS = new HashSet<PRODUCT>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string SortOrder { get; set; }

        public bool? IsShowOnHome { get; set; }

        [StringLength(10)]
        public string ParentId { get; set; }

        public bool? Status { get; set; }

        [StringLength(100)]
        public string SeoDescription { get; set; }

        [StringLength(100)]
        public string SeoTitle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCT> PRODUCTS { get; set; }
    }
}
