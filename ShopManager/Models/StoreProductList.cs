namespace ShopManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StoreProductList")]
    public partial class StoreProductList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StoreProductList()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key] public int StoreId { get; set; }

        public int ProductList_FK { get; set; }

        public int PurchaseInvoice_FK { get; set; }

        public double Price { get; set; }

        public byte Percent { get; set; }

        public double Numbers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual ProductList ProductList { get; set; }

        public virtual PurchaseInvoicy PurchaseInvoicy { get; set; }
    }
}
