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
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Good> Goods { get; set; }
        public virtual DbSet<InvoiceType> InvoiceTypes { get; set; }
        public virtual DbSet<Logger> Loggers { get; set; }
        public virtual DbSet<LogMessage> LogMessages { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ProductList> ProductLists { get; set; }
        public virtual DbSet<PurchaseInvoicy> PurchaseInvoicies { get; set; }
        public virtual DbSet<Saller> Sallers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Unit> Units { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>()
                .Property(e => e.UserMobile)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AppUser>()
                .HasMany(e => e.Customers)
                .WithRequired(e => e.AppUser)
                .HasForeignKey(e => e.AppUser_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AppUser>()
                .HasMany(e => e.Goods)
                .WithRequired(e => e.AppUser)
                .HasForeignKey(e => e.AppUser_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AppUser>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.AppUser)
                .HasForeignKey(e => e.AppUser_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AppUser>()
                .HasMany(e => e.ProductLists)
                .WithRequired(e => e.AppUser)
                .HasForeignKey(e => e.AppUser_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AppUser>()
                .HasMany(e => e.PurchaseInvoicies)
                .WithRequired(e => e.AppUser)
                .HasForeignKey(e => e.AppUser_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AppUser>()
                .HasMany(e => e.Sallers)
                .WithRequired(e => e.AppUser)
                .HasForeignKey(e => e.AppUser_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerMobile)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.Customers_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Good>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Good)
                .HasForeignKey(e => e.Goods_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InvoiceType>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.InvoiceType)
                .HasForeignKey(e => e.InvoiceType_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InvoiceType>()
                .HasMany(e => e.PurchaseInvoicies)
                .WithRequired(e => e.InvoiceType)
                .HasForeignKey(e => e.InvoiceType_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LogMessage>()
                .HasMany(e => e.Loggers)
                .WithRequired(e => e.LogMessage)
                .HasForeignKey(e => e.LogMessage_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Order)
                .HasForeignKey(e => e.Orders_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductList>()
                .Property(e => e.ProductNumber)
                .IsFixedLength();

            modelBuilder.Entity<ProductList>()
                .HasMany(e => e.Goods)
                .WithRequired(e => e.ProductList)
                .HasForeignKey(e => e.ProductList_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductList>()
                .HasMany(e => e.PurchaseInvoicies)
                .WithRequired(e => e.ProductList)
                .HasForeignKey(e => e.ProductList_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PurchaseInvoicy>()
                .HasMany(e => e.Goods)
                .WithRequired(e => e.PurchaseInvoicy)
                .HasForeignKey(e => e.PurchaseInvoice_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Saller>()
                .Property(e => e.SallerPhoneNumber)
                .IsFixedLength();

            modelBuilder.Entity<Saller>()
                .Property(e => e.SallerMobile)
                .IsFixedLength();

            modelBuilder.Entity<Saller>()
                .Property(e => e.SallerFaxNumber)
                .IsFixedLength();

            modelBuilder.Entity<Saller>()
                .HasMany(e => e.PurchaseInvoicies)
                .WithRequired(e => e.Saller)
                .HasForeignKey(e => e.Saller_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Unit>()
                .HasMany(e => e.Goods)
                .WithRequired(e => e.Unit)
                .HasForeignKey(e => e.Unit_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Unit>()
                .HasMany(e => e.ProductLists)
                .WithRequired(e => e.Unit)
                .HasForeignKey(e => e.UnitId_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Unit>()
                .HasMany(e => e.PurchaseInvoicies)
                .WithRequired(e => e.Unit)
                .HasForeignKey(e => e.Unit_FK)
                .WillCascadeOnDelete(false);
        }
    }
}
