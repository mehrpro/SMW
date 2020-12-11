namespace ShopManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ProductList")]
    public  class ProductList
    {
        public ProductList()
        {
            StoreProductLists = new HashSet<StoreProductList>();
            PurchaseInvoiceDetails = new HashSet<PurchaseInvoiceDetail>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Required]
        [StringLength(150)]
        public string ProductName { get; set; }

        [StringLength(20)]
        public string ProductNumber { get; set; }


        [Required]
        [ForeignKey("Unit")]
        public int UnitId_FK { get; set; }
        public virtual Unit Unit { get; set; }


        [Required]
        [ForeignKey("AppUser")]
        public int AppUser_FK { get; set; }
        public virtual AppUser AppUser { get; set; }


        public bool Enabled { get; set; }

        public DateTime DateRegister { get; set; }

        [StringLength(250)]
        public string Description { get; set; }







        public virtual ICollection<StoreProductList> StoreProductLists { get; set; }

        public virtual ICollection<PurchaseInvoiceDetail> PurchaseInvoiceDetails { get; set; }
    }
}
