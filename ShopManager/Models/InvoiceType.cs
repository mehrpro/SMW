namespace ShopManager.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("InvoiceType")]
    public  class InvoiceType
    {
        public InvoiceType()
        {
            Orders = new HashSet<Order>();
            PurchaseInvoicies = new HashSet<PurchaseInvoicy>();
            OrderDetails = new HashSet<OrderDetail>();
            Journals = new HashSet<Journal>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte InvoiceTypeId { get; set; }

        [Required]
        [StringLength(150)]
        public string InvoiceName { get; set; }





        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<PurchaseInvoicy> PurchaseInvoicies { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual ICollection<Journal> Journals { get; set; }
    }
}
