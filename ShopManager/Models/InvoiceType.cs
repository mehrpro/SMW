using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopManager.Models
{
    [Table("InvoiceType")]
    public partial class InvoiceType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InvoiceType()
        {
            Orders = new HashSet<Order>();
            PurchaseInvoicies = new HashSet<PurchaseInvoicy>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte InvoiceTypeId { get; set; }

        [Required]
        [StringLength(150)]
        public string InvoiceName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseInvoicy> PurchaseInvoicies { get; set; }
    }
}
