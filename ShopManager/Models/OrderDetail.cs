using System.ComponentModel.DataAnnotations;

namespace ShopManager.Models
{
    public partial class OrderDetail
    {
        [Key]
        public int OrderDetailsId { get; set; }

        public int Orders_FK { get; set; }

        public int Goods_FK { get; set; }

        public int Numbers { get; set; }

        public double Price { get; set; }

        public virtual Good Good { get; set; }

        public virtual Order Order { get; set; }
    }
}
