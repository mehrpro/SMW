namespace ShopManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public  class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        [Required]
        [ForeignKey("Account")]
        public int AccountID { get; set; }
        public Account Account { get; set; }

        public DateTime OrderDate { get; set; }

        [Required]
        [ForeignKey("InvoiceType")]
        public byte InvoiceType_FK { get; set; }
        public virtual InvoiceType InvoiceType { get; set; }

        public bool Enabled { get; set; }

        public DateTime OrderRegister { get; set; }


        [Required]
        [ForeignKey("AppUser")]
        public int AppUser_FK { get; set; }
        public virtual AppUser AppUser { get; set; }

        public double SumPrice { get; set; }


        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
