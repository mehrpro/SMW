namespace ShopManager.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOrderDetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderDetails", "Percent", c => c.Byte(nullable: false));
            AddColumn("dbo.OrderDetails", "PercentPrice", c => c.Double(nullable: false));
            AddColumn("dbo.OrderDetails", "SumPrice", c => c.Double(nullable: false));
            AddColumn("dbo.OrderDetails", "SumAfterPercent", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderDetails", "SumAfterPercent");
            DropColumn("dbo.OrderDetails", "SumPrice");
            DropColumn("dbo.OrderDetails", "PercentPrice");
            DropColumn("dbo.OrderDetails", "Percent");
        }
    }
}
