namespace ShopManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public  class PurchaseInvoicy
    {
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



        [Required]
        [ForeignKey("InvoiceType")]
        public byte InvoiceType_FK { get; set; }
        public virtual InvoiceType InvoiceType { get; set; }



        [Required]
        [ForeignKey("Account")]
        public int AccountID { get; set; }
        public virtual Account Account { get; set; }



        [Required]
        [ForeignKey("AppUser")]
        public int AppUser_FK { get; set; }
        public virtual AppUser AppUser { get; set; }





        public DateTime DateRegister { get; set; }

        public bool Enabled { get; set; }



        public virtual ICollection<PurchaseInvoiceDetail> PurchaseInvoiceDetails { get; set; }

        public virtual ICollection<StoreProductList> StoreProductLists { get; set; }


    }
}
