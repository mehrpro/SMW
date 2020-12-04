namespace ShopManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class up2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PurchaseInvoicies", "SumCurrency", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PurchaseInvoicies", "SumCurrency");
        }
    }
}
