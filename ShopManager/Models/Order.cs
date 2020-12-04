namespace ShopManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }

        public int Customers_FK { get; set; }

        public DateTime OrderDate { get; set; }

        public byte InvoiceType_FK { get; set; }

        public bool Enabled { get; set; }

        public DateTime OrderRegister { get; set; }

        public int AppUser_FK { get; set; }

        public double SumPrice { get; set; }

        public virtual AppUser AppUser { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual InvoiceType InvoiceType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
