namespace ShopManager.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class updateStoreProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StoreProductList", "Percent", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StoreProductList", "Percent");
        }
    }
}
