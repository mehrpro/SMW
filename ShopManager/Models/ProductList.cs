using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopManager.Models
{
    [Table("ProductList")]
    public partial class ProductList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductList()
        {
            Goods = new HashSet<Good>();
            PurchaseInvoicies = new HashSet<PurchaseInvoicy>();
        }

        [Key]
        public int ProductId { get; set; }

        [Required]
        [StringLength(150)]
        public string ProductName { get; set; }

        [StringLength(20)]
        public string ProductNumber { get; set; }

        public int UnitId_FK { get; set; }

        public bool Enabled { get; set; }

        public DateTime DateRegister { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public int AppUser_FK { get; set; }

        public virtual AppUser AppUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Good> Goods { get; set; }

        public virtual Unit Unit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseInvoicy> PurchaseInvoicies { get; set; }
    }
}
