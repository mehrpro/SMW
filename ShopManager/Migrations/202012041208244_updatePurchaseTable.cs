namespace ShopManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatePurchaseTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PurchaseInvoicies", "UnitName", c => c.String());
            AddColumn("dbo.PurchaseInvoicies", "Currency", c => c.Double());
            AddColumn("dbo.PurchaseInvoicies", "SumCurrency", c => c.Double());
            AddColumn("dbo.PurchaseInvoicies", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.PurchaseInvoicies", "Numbers", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PurchaseInvoicies", "Numbers", c => c.Int(nullable: false));
            DropColumn("dbo.PurchaseInvoicies", "Discriminator");
            DropColumn("dbo.PurchaseInvoicies", "SumCurrency");
            DropColumn("dbo.PurchaseInvoicies", "Currency");
            DropColumn("dbo.PurchaseInvoicies", "UnitName");
        }
    }
}
