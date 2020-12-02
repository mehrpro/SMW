using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopManager.Models
{
    public partial class Unit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Unit()
        {
            Goods = new HashSet<Good>();
            ProductLists = new HashSet<ProductList>();
            PurchaseInvoicies = new HashSet<PurchaseInvoicy>();
        }

        public int UnitId { get; set; }

        [Required]
        [StringLength(150)]
        public string UnitName { get; set; }

        public bool Enabled { get; set; }

        public DateTime DateRegister { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Good> Goods { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductList> ProductLists { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseInvoicy> PurchaseInvoicies { get; set; }
    }
}
