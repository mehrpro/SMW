using System.Data.Entity;

namespace ShopManager.Models
{
    public partial class DBModel : DbContext
    {
        public DBModel()
            : base("name=DBModel")
        {
        }

        public virtual DbSet<AppUser> AppUsers { get; set; }
        public virtual DbSet<InvoiceType> InvoiceTypes { get; set; }
        public virtual DbSet<Logger> Loggers { get; set; }
        public virtual DbSet<LogMessage> LogMessages { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ProductList> ProductLists { get; set; }
        public virtual DbSet<PurchaseInvoiceDetail> PurchaseInvoiceDetails { get; set; }
        public virtual DbSet<PurchaseInvoicy> PurchaseInvoicies { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<StoreProductList> StoreProductLists { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<Journal> Journals { get; set; }
        public virtual  DbSet<GeneralLedgerEntity> GeneralLedgerEntities { get; set; }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{

        //}
    }
}
