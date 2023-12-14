namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alltables1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MonitoringManagers", "PermanentAddress", c => c.String(nullable: false, maxLength: 250));
            DropColumn("dbo.MonitoringManagers", "PermaanentAddress");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MonitoringManagers", "PermaanentAddress", c => c.String(nullable: false, maxLength: 250));
            DropColumn("dbo.MonitoringManagers", "PermanentAddress");
        }
    }
}
