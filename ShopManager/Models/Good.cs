using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopManager.Models
{
    public partial class Good
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Good()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        public int GoodsId { get; set; }

        public int ProductList_FK { get; set; }

        public int PurchaseInvoice_FK { get; set; }

        public int Unit_FK { get; set; }

        public double Price { get; set; }

        public int Numbers { get; set; }

        public int AppUser_FK { get; set; }

        public virtual AppUser AppUser { get; set; }

        public virtual ProductList ProductList { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual PurchaseInvoicy PurchaseInvoicy { get; set; }

        public virtual Unit Unit { get; set; }
    }
}
