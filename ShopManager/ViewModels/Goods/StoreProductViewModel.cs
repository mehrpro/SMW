using System;

namespace ShopManager.ViewModels.Goods
{
    public class StoreProductViewModel
    {

        public int Customers_FK { get; set; }
        public DateTime OrderDate { get; set; }
        public byte InvoiceType_FK { get; set; }
        public double SumPrice { get; set; }
        public int StoreId { get; set; }
        public string ProductName { get; set; }
        public int ProductList_FK { get; set; }
        public int PurchaseInvoice_FK { get; set; }
        public int Orders_FK { get; set; }
        public int StoreId_FK { get; set; }
        public double Numbers { get; set; }
        public double Price { get; set; }

    }
}