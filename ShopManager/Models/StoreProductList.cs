namespace ShopManager.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("StoreProductList")]
    public partial class StoreProductList
    {

        public StoreProductList()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StoreId { get; set; }

        public int ProductList_FK { get; set; }
        public virtual ProductList ProductList { get; set; }
        public int PurchaseInvoice_FK { get; set; }
        public virtual PurchaseInvoicy PurchaseInvoicy { get; set; }
        public double Price { get; set; }

        public byte Percent { get; set; }

        public double Numbers { get; set; }



        public virtual ICollection<OrderDetail> OrderDetails { get; set; }



    
    }
}
