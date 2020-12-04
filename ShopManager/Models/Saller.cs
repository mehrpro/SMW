namespace ShopManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Saller
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Saller()
        {
            PurchaseInvoicies = new HashSet<PurchaseInvoicy>();
        }

        public int SallerId { get; set; }

        [Required]
        [StringLength(150)]
        public string SallerName { get; set; }

        [StringLength(150)]
        public string SallerCompany { get; set; }

        [StringLength(250)]
        public string SallerAddress { get; set; }

        [StringLength(10)]
        public string SallerPhoneNumber { get; set; }

        [Required]
        [StringLength(10)]
        public string SallerMobile { get; set; }

        [StringLength(10)]
        public string SallerFaxNumber { get; set; }

        public int AppUser_FK { get; set; }

        public virtual AppUser AppUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseInvoicy> PurchaseInvoicies { get; set; }
    }
}
