namespace ShopManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PurchaseInvoicies", "InvoiceNumber", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PurchaseInvoicies", "InvoiceNumber", c => c.String());
        }
    }
}
