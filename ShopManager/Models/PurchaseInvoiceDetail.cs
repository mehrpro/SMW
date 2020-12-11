namespace ShopManager.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class PurchaseInvoiceDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvoiceDetailsId { get; set; }

        public int PurchaseInvoiceId_FK { get; set; }

        public int ProductList_FK { get; set; }

        public double PurchasePrice { get; set; }

        public double Numbers { get; set; }

        public double SumCurrency { get; set; }

        public bool Enabled { get; set; }

        public virtual ProductList ProductList { get; set; }

        public virtual PurchaseInvoicy PurchaseInvoicy { get; set; }
    }
}
