namespace ShopManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class up : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PurchaseInvoicies", "UnitName");
            DropColumn("dbo.PurchaseInvoicies", "Currency");
            DropColumn("dbo.PurchaseInvoicies", "SumCurrency");
            DropColumn("dbo.PurchaseInvoicies", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PurchaseInvoicies", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.PurchaseInvoicies", "SumCurrency", c => c.Double());
            AddColumn("dbo.PurchaseInvoicies", "Currency", c => c.Double());
            AddColumn("dbo.PurchaseInvoicies", "UnitName", c => c.String());
        }
    }
}
