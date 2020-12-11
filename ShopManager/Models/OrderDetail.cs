using System.ComponentModel.DataAnnotations.Schema;

namespace ShopManager.Models
{
    using System.ComponentModel.DataAnnotations;

    public  class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderDetailsId { get; set; }


        [Required]
        [ForeignKey("Order")]
        public int Orders_FK { get; set; }
        public virtual Order Order { get; set; }


        [Required]
        [ForeignKey("StoreProductList")]
        public int StoreId_FK { get; set; }
        public virtual StoreProductList StoreProductList { get; set; }



        [Required]
        [ForeignKey("InvoiceType")]
        public byte InvoiceType_FK { get; set; }
        public virtual InvoiceType InvoiceType { get; set; }


        public double Numbers { get; set; }
        public double Price { get; set; }
        public byte Percent { get; set; }
        public double PercentPrice { get; set; }
        public double SumPrice { get; set; }
        public double SumAfterPercent { get; set; }





    
    }
}
