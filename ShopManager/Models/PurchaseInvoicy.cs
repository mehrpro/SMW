namespace ShopManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class PurchaseInvoicy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PurchaseInvoicy()
        {
            PurchaseInvoiceDetails = new HashSet<PurchaseInvoiceDetail>();
            StoreProductLists = new HashSet<StoreProductList>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PurchaseInvoiceId { get; set; }

        public DateTime InvoiceDate { get; set; }

        [Required]
        [StringLength(100)]
        public string InvoiceNumber { get; set; }

        public byte InvoiceType_FK { get; set; }

        public int Saller_FK { get; set; }

        public DateTime DateRegister { get; set; }

        public bool Enabled { get; set; }

        public int AppUser_FK { get; set; }

        public virtual AppUser AppUser { get; set; }

        public virtual InvoiceType InvoiceType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseInvoiceDetail> PurchaseInvoiceDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreProductList> StoreProductLists { get; set; }

        public virtual Saller Saller { get; set; }
    }
}
