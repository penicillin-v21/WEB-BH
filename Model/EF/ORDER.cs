namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ORDERS")]
    public partial class ORDER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ORDER()
        {
            ORDERDETAILS = new HashSet<ORDERDETAIL>();
        }

        public int Id { get; set; }

        public DateTime? OrderDate { get; set; }

        public int? UserId { get; set; }

        [StringLength(100)]
        public string ShipName { get; set; }

        [StringLength(200)]
        public string ShipAdress { get; set; }

        [StringLength(50)]
        public string ShipPhoneNumber { get; set; }

        public bool? Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDERDETAIL> ORDERDETAILS { get; set; }

        public virtual USER USER { get; set; }
    }
}
