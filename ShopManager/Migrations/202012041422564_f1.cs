namespace ShopManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Goods", "Numbers", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Goods", "Numbers", c => c.Int(nullable: false));
        }
    }
}
