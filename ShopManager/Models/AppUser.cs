namespace ShopManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public  class AppUser
    {
        public AppUser()
        {
           
            Orders = new HashSet<Order>();
            ProductLists = new HashSet<ProductList>();
            PurchaseInvoicies = new HashSet<PurchaseInvoicy>();
            Accounts = new HashSet<Account>();
            Journals = new HashSet<Journal>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        [StringLength(10)]
        public string UserMobile { get; set; }

        [Required]
        public string UserPassword { get; set; }

        public DateTime DateRgister { get; set; }

        public bool Enabled { get; set; }



        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<ProductList> ProductLists { get; set; }

        public virtual ICollection<PurchaseInvoicy> PurchaseInvoicies { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }

        public virtual ICollection<Journal> Journals { get; set; }

       
    }
}
