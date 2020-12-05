using System;
using System.ComponentModel.DataAnnotations;

namespace ShopManager.ViewModels.Goods
{
    public class StoreProductViewModel
    {
        [Display(AutoGenerateField = false)]
        public int Customers_FK { get; set; }
        [Display(AutoGenerateField = false)]
        public DateTime OrderDate { get; set; }
        [Display(AutoGenerateField = false)]
        public byte InvoiceType_FK { get; set; }
        [Display(Name = "جمع")]
        public double SumPrice { get; set; }
        [Display(AutoGenerateField = false)]
        public int StoreId { get; set; }
        [Display(Name = "کالا")]
        public string ProductName { get; set; }
        [Display(AutoGenerateField = false)]
        public int ProductList_FK { get; set; }
        [Display(AutoGenerateField = false)]
        public int PurchaseInvoice_FK { get; set; }
        [Display(AutoGenerateField = false)]
        public int Orders_FK { get; set; }
        [Display(AutoGenerateField = false)]
        public int StoreId_FK { get; set; }
        [Display(Name = "تعداد")]
        public double Numbers { get; set; }
        [Display(Name = "قیمت")]
        public double Price { get; set; }
        [Display(Name = "واحد")]
        public string UnitNam { get; set; }
        [Display(Name = "تخفیف")]
        public byte Percent { get; set; }
        [Display(Name = "مبلغ تخفیف داده شده")]
        public double PercentPrice { get; set; }
        [Display(Name = "مبلغ پرداختی")]
        public double SumAfterPercent { get; set; }

    }
}