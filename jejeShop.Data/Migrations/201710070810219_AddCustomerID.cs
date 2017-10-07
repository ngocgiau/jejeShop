namespace jejeShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "CustomerId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Orders", "CutomerName", c => c.String(nullable: false, maxLength: 256));
            AlterColumn("dbo.Orders", "CutomerAddress", c => c.String(nullable: false, maxLength: 256));
            AlterColumn("dbo.Orders", "CutomerEmail", c => c.String(nullable: false, maxLength: 256));
            AlterColumn("dbo.Orders", "CutomerMobile", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Orders", "CutomerMessage", c => c.String(nullable: false, maxLength: 256));
            AlterColumn("dbo.Orders", "PaymenMethod", c => c.String(maxLength: 256));
            AlterColumn("dbo.Orders", "PaymenStatus", c => c.String());
            CreateIndex("dbo.Orders", "CustomerId");
            AddForeignKey("dbo.Orders", "CustomerId", "dbo.ApplicationUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.ApplicationUsers");
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            AlterColumn("dbo.Orders", "PaymenStatus", c => c.String(nullable: false));
            AlterColumn("dbo.Orders", "PaymenMethod", c => c.String());
            AlterColumn("dbo.Orders", "CutomerMessage", c => c.String());
            AlterColumn("dbo.Orders", "CutomerMobile", c => c.String(nullable: false));
            AlterColumn("dbo.Orders", "CutomerEmail", c => c.String(nullable: false));
            AlterColumn("dbo.Orders", "CutomerAddress", c => c.String(nullable: false));
            AlterColumn("dbo.Orders", "CutomerName", c => c.String(nullable: false));
            DropColumn("dbo.Orders", "CustomerId");
        }
    }
}
