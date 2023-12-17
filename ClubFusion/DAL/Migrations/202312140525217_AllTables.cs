namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OdrId = c.String(nullable: false, maxLength: 9),
                        CustomerId = c.Int(nullable: false),
                        UpdateBy = c.Int(nullable: false),
                        DeliveryDate = c.Int(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OdrId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UpdateBy, cascadeDelete: true)
                .Index(t => t.OdrId, unique: true, name: "UniqueOrderId")
                .Index(t => t.CustomerId)
                .Index(t => t.UpdateBy);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        UpdateTime = c.DateTime(nullable: false),
                        UpdateBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UpdateBy)
                .Index(t => t.UpdateBy);
            
            AddColumn("dbo.ProductColors", "ProductColorCode", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Customers", "UpdateTime");
            DropColumn("dbo.ProductColors", "ProductColorName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductColors", "ProductColorName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Customers", "UpdateTime", c => c.DateTime(nullable: false));
            DropForeignKey("dbo.Units", "UpdateBy", "dbo.Users");
            DropForeignKey("dbo.Orders", "UpdateBy", "dbo.Users");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Units", new[] { "UpdateBy" });
            DropIndex("dbo.Orders", new[] { "UpdateBy" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.Orders", "UniqueOrderId");
            DropColumn("dbo.ProductColors", "ProductColorCode");
            DropTable("dbo.Units");
            DropTable("dbo.Orders");
        }
    }
}
