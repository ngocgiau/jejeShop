namespace jejeShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUpdateOrderDetail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "CustomerName", c => c.String(nullable: false, maxLength: 256));
            AddColumn("dbo.Orders", "CustomerAddress", c => c.String(nullable: false, maxLength: 256));
            AddColumn("dbo.Orders", "CustomerEmail", c => c.String(nullable: false, maxLength: 256));
            AddColumn("dbo.Orders", "CustomerMobile", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Orders", "CustomerMessage", c => c.String(nullable: false, maxLength: 256));
            AddColumn("dbo.Orders", "PaymentMethod", c => c.String(maxLength: 256));
            DropColumn("dbo.Orders", "CutomerName");
            DropColumn("dbo.Orders", "CutomerAddress");
            DropColumn("dbo.Orders", "CutomerEmail");
            DropColumn("dbo.Orders", "CutomerMobile");
            DropColumn("dbo.Orders", "CutomerMessage");
            DropColumn("dbo.Orders", "PaymenMethod");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "PaymenMethod", c => c.String(maxLength: 256));
            AddColumn("dbo.Orders", "CutomerMessage", c => c.String(nullable: false, maxLength: 256));
            AddColumn("dbo.Orders", "CutomerMobile", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Orders", "CutomerEmail", c => c.String(nullable: false, maxLength: 256));
            AddColumn("dbo.Orders", "CutomerAddress", c => c.String(nullable: false, maxLength: 256));
            AddColumn("dbo.Orders", "CutomerName", c => c.String(nullable: false, maxLength: 256));
            DropColumn("dbo.Orders", "PaymentMethod");
            DropColumn("dbo.Orders", "CustomerMessage");
            DropColumn("dbo.Orders", "CustomerMobile");
            DropColumn("dbo.Orders", "CustomerEmail");
            DropColumn("dbo.Orders", "CustomerAddress");
            DropColumn("dbo.Orders", "CustomerName");
        }
    }
}
