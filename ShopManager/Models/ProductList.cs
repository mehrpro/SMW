namespace ShopManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductList")]
    public partial class ProductList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductList()
        {
            StoreProductLists = new HashSet<StoreProductList>();
            PurchaseInvoiceDetails = new HashSet<PurchaseInvoiceDetail>();
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
        public virtual ICollection<StoreProductList> StoreProductLists { get; set; }

        public virtual Unit Unit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseInvoiceDetail> PurchaseInvoiceDetails { get; set; }
    }
}
