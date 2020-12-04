namespace ShopManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderDetail
    {
        [Key]
        public int OrderDetailsId { get; set; }

        public int Orders_FK { get; set; }

        public int StoreId_FK { get; set; }

        public double Numbers { get; set; }

        public double Price { get; set; }

        public byte InvoiceType_FK { get; set; }

        public virtual InvoiceType InvoiceType { get; set; }

        public virtual StoreProductList StoreProductList { get; set; }

        public virtual Order Order { get; set; }
    }
}
