namespace ShopManager.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class DBCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AppUsers",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 100),
                        UserMobile = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        UserPassword = c.String(nullable: false),
                        DateRgister = c.DateTime(nullable: false),
                        Enabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false, maxLength: 150),
                        CustomerMobile = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        CustomerAddress = c.String(maxLength: 250),
                        DateRegister = c.DateTime(nullable: false),
                        Enabled = c.Boolean(nullable: false),
                        AppUser_FK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("dbo.AppUsers", t => t.AppUser_FK)
                .Index(t => t.AppUser_FK);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        Customers_FK = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        InvoiceType_FK = c.Byte(nullable: false),
                        Enabled = c.Boolean(nullable: false),
                        OrderRegister = c.DateTime(nullable: false),
                        AppUser_FK = c.Int(nullable: false),
                        SumPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.InvoiceType", t => t.InvoiceType_FK)
                .ForeignKey("dbo.Customers", t => t.Customers_FK)
                .ForeignKey("dbo.AppUsers", t => t.AppUser_FK)
                .Index(t => t.Customers_FK)
                .Index(t => t.InvoiceType_FK)
                .Index(t => t.AppUser_FK);
            
            CreateTable(
                "dbo.InvoiceType",
                c => new
                    {
                        InvoiceTypeId = c.Byte(nullable: false, identity: true),
                        InvoiceName = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.InvoiceTypeId);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderDetailsId = c.Int(nullable: false, identity: true),
                        Orders_FK = c.Int(nullable: false),
                        StoreId_FK = c.Int(nullable: false),
                        Numbers = c.Double(nullable: false),
                        Price = c.Double(nullable: false),
                        InvoiceType_FK = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.OrderDetailsId)
                .ForeignKey("dbo.StoreProductList", t => t.StoreId_FK)
                .ForeignKey("dbo.InvoiceType", t => t.InvoiceType_FK)
                .ForeignKey("dbo.Orders", t => t.Orders_FK)
                .Index(t => t.Orders_FK)
                .Index(t => t.StoreId_FK)
                .Index(t => t.InvoiceType_FK);
            
            CreateTable(
                "dbo.StoreProductList",
                c => new
                    {
                        StoreId = c.Int(nullable: false, identity: true),
                        ProductList_FK = c.Int(nullable: false),
                        PurchaseInvoice_FK = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Numbers = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.StoreId)
                .ForeignKey("dbo.PurchaseInvoicies", t => t.PurchaseInvoice_FK)
                .ForeignKey("dbo.ProductList", t => t.ProductList_FK)
                .Index(t => t.ProductList_FK)
                .Index(t => t.PurchaseInvoice_FK);
            
            CreateTable(
                "dbo.ProductList",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 150),
                        ProductNumber = c.String(maxLength: 20, fixedLength: true),
                        UnitId_FK = c.Int(nullable: false),
                        Enabled = c.Boolean(nullable: false),
                        DateRegister = c.DateTime(nullable: false),
                        Description = c.String(maxLength: 250),
                        AppUser_FK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Units", t => t.UnitId_FK)
                .ForeignKey("dbo.AppUsers", t => t.AppUser_FK)
                .Index(t => t.UnitId_FK)
                .Index(t => t.AppUser_FK);
            
            CreateTable(
                "dbo.PurchaseInvoiceDetails",
                c => new
                    {
                        InvoiceDetailsId = c.Int(nullable: false, identity: true),
                        PurchaseInvoiceId_FK = c.Int(nullable: false),
                        ProductList_FK = c.Int(nullable: false),
                        PurchasePrice = c.Double(nullable: false),
                        Numbers = c.Double(nullable: false),
                        SumCurrency = c.Double(nullable: false),
                        Enabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.InvoiceDetailsId)
                .ForeignKey("dbo.PurchaseInvoicies", t => t.PurchaseInvoiceId_FK)
                .ForeignKey("dbo.ProductList", t => t.ProductList_FK)
                .Index(t => t.PurchaseInvoiceId_FK)
                .Index(t => t.ProductList_FK);
            
            CreateTable(
                "dbo.PurchaseInvoicies",
                c => new
                    {
                        PurchaseInvoiceId = c.Int(nullable: false, identity: true),
                        InvoiceDate = c.DateTime(nullable: false),
                        InvoiceNumber = c.String(nullable: false, maxLength: 100),
                        InvoiceType_FK = c.Byte(nullable: false),
                        Saller_FK = c.Int(nullable: false),
                        DateRegister = c.DateTime(nullable: false),
                        Enabled = c.Boolean(nullable: false),
                        AppUser_FK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PurchaseInvoiceId)
                .ForeignKey("dbo.Sallers", t => t.Saller_FK)
                .ForeignKey("dbo.InvoiceType", t => t.InvoiceType_FK)
                .ForeignKey("dbo.AppUsers", t => t.AppUser_FK)
                .Index(t => t.InvoiceType_FK)
                .Index(t => t.Saller_FK)
                .Index(t => t.AppUser_FK);
            
            CreateTable(
                "dbo.Sallers",
                c => new
                    {
                        SallerId = c.Int(nullable: false, identity: true),
                        SallerName = c.String(nullable: false, maxLength: 150),
                        SallerCompany = c.String(maxLength: 150),
                        SallerAddress = c.String(maxLength: 250),
                        SallerPhoneNumber = c.String(maxLength: 10, fixedLength: true),
                        SallerMobile = c.String(nullable: false, maxLength: 10, fixedLength: true),
                        SallerFaxNumber = c.String(maxLength: 10, fixedLength: true),
                        AppUser_FK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SallerId)
                .ForeignKey("dbo.AppUsers", t => t.AppUser_FK)
                .Index(t => t.AppUser_FK);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        UnitId = c.Int(nullable: false, identity: true),
                        UnitName = c.String(nullable: false, maxLength: 150),
                        Enabled = c.Boolean(nullable: false),
                        DateRegister = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UnitId);
            
            CreateTable(
                "dbo.Logger",
                c => new
                    {
                        LogId = c.Int(nullable: false, identity: true),
                        LogMessage_FK = c.Int(nullable: false),
                        AppUsers_FK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LogId)
                .ForeignKey("dbo.LogMessages", t => t.LogMessage_FK)
                .Index(t => t.LogMessage_FK);
            
            CreateTable(
                "dbo.LogMessages",
                c => new
                    {
                        LogMessageId = c.Int(nullable: false, identity: true),
                        LogMessage = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.LogMessageId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Logger", "LogMessage_FK", "dbo.LogMessages");
            DropForeignKey("dbo.Sallers", "AppUser_FK", "dbo.AppUsers");
            DropForeignKey("dbo.PurchaseInvoicies", "AppUser_FK", "dbo.AppUsers");
            DropForeignKey("dbo.ProductList", "AppUser_FK", "dbo.AppUsers");
            DropForeignKey("dbo.Orders", "AppUser_FK", "dbo.AppUsers");
            DropForeignKey("dbo.Customers", "AppUser_FK", "dbo.AppUsers");
            DropForeignKey("dbo.Orders", "Customers_FK", "dbo.Customers");
            DropForeignKey("dbo.OrderDetails", "Orders_FK", "dbo.Orders");
            DropForeignKey("dbo.PurchaseInvoicies", "InvoiceType_FK", "dbo.InvoiceType");
            DropForeignKey("dbo.Orders", "InvoiceType_FK", "dbo.InvoiceType");
            DropForeignKey("dbo.OrderDetails", "InvoiceType_FK", "dbo.InvoiceType");
            DropForeignKey("dbo.ProductList", "UnitId_FK", "dbo.Units");
            DropForeignKey("dbo.StoreProductList", "ProductList_FK", "dbo.ProductList");
            DropForeignKey("dbo.PurchaseInvoiceDetails", "ProductList_FK", "dbo.ProductList");
            DropForeignKey("dbo.StoreProductList", "PurchaseInvoice_FK", "dbo.PurchaseInvoicies");
            DropForeignKey("dbo.PurchaseInvoicies", "Saller_FK", "dbo.Sallers");
            DropForeignKey("dbo.PurchaseInvoiceDetails", "PurchaseInvoiceId_FK", "dbo.PurchaseInvoicies");
            DropForeignKey("dbo.OrderDetails", "StoreId_FK", "dbo.StoreProductList");
            DropIndex("dbo.Logger", new[] { "LogMessage_FK" });
            DropIndex("dbo.Sallers", new[] { "AppUser_FK" });
            DropIndex("dbo.PurchaseInvoicies", new[] { "AppUser_FK" });
            DropIndex("dbo.PurchaseInvoicies", new[] { "Saller_FK" });
            DropIndex("dbo.PurchaseInvoicies", new[] { "InvoiceType_FK" });
            DropIndex("dbo.PurchaseInvoiceDetails", new[] { "ProductList_FK" });
            DropIndex("dbo.PurchaseInvoiceDetails", new[] { "PurchaseInvoiceId_FK" });
            DropIndex("dbo.ProductList", new[] { "AppUser_FK" });
            DropIndex("dbo.ProductList", new[] { "UnitId_FK" });
            DropIndex("dbo.StoreProductList", new[] { "PurchaseInvoice_FK" });
            DropIndex("dbo.StoreProductList", new[] { "ProductList_FK" });
            DropIndex("dbo.OrderDetails", new[] { "InvoiceType_FK" });
            DropIndex("dbo.OrderDetails", new[] { "StoreId_FK" });
            DropIndex("dbo.OrderDetails", new[] { "Orders_FK" });
            DropIndex("dbo.Orders", new[] { "AppUser_FK" });
            DropIndex("dbo.Orders", new[] { "InvoiceType_FK" });
            DropIndex("dbo.Orders", new[] { "Customers_FK" });
            DropIndex("dbo.Customers", new[] { "AppUser_FK" });
            DropTable("dbo.LogMessages");
            DropTable("dbo.Logger");
            DropTable("dbo.Units");
            DropTable("dbo.Sallers");
            DropTable("dbo.PurchaseInvoicies");
            DropTable("dbo.PurchaseInvoiceDetails");
            DropTable("dbo.ProductList");
            DropTable("dbo.StoreProductList");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.InvoiceType");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
            DropTable("dbo.AppUsers");
        }
    }
}
