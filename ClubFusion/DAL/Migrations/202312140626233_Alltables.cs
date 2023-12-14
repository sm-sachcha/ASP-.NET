namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alltables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        isActive = c.Boolean(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        UpdateBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UpdateBy)
                .Index(t => t.UpdateBy);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        PhoneNo = c.String(nullable: false, maxLength: 11),
                        Email = c.String(maxLength: 60),
                        Password = c.String(nullable: false),
                        BloodGroup = c.String(nullable: false),
                        Image = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        isActive = c.Boolean(nullable: false),
                        UpdateBy = c.Int(nullable: false),
                        UserType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClubManagers",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        ClubManagerId = c.String(nullable: false, maxLength: 6),
                        Name = c.String(nullable: false, maxLength: 100),
                        ClubId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Clubs", t => t.ClubId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.ClubManagerId, unique: true, name: "UniqueClubManagerId")
                .Index(t => t.ClubId);
            
            CreateTable(
                "dbo.Clubs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 120),
                        Image = c.String(),
                        JoiningDate = c.DateTime(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        isActive = c.Boolean(nullable: false),
                        UpdateBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UpdateBy)
                .Index(t => t.UpdateBy);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        PhoneNo = c.String(nullable: false, maxLength: 11),
                        Email = c.String(nullable: false),
                        Address = c.String(nullable: false, maxLength: 250),
                        isActive = c.Boolean(nullable: false),
                        ClubId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clubs", t => t.ClubId, cascadeDelete: true)
                .Index(t => t.PhoneNo, unique: true, name: "UniquePhoneNo")
                .Index(t => t.ClubId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        isActive = c.Boolean(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        UpdateBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UpdateBy)
                .Index(t => t.UpdateBy);
            
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        IsActive = c.Boolean(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        UpdateBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UpdateBy)
                .Index(t => t.UpdateBy);
            
            CreateTable(
                "dbo.Divisions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        isActive = c.Boolean(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        UpdateBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UpdateBy)
                .Index(t => t.UpdateBy);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmpId = c.String(nullable: false, maxLength: 6),
                        Name = c.String(nullable: false, maxLength: 100),
                        FatherName = c.String(nullable: false, maxLength: 100),
                        MotherName = c.String(nullable: false, maxLength: 100),
                        PresentAddress = c.String(nullable: false, maxLength: 200),
                        PermanentAddress = c.String(nullable: false, maxLength: 200),
                        DateOfJoining = c.DateTime(nullable: false),
                        DateOfLeaving = c.DateTime(nullable: false),
                        GradeId = c.Int(nullable: false),
                        DesignationId = c.Int(nullable: false),
                        UnitId = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        DivisionId = c.Int(nullable: false),
                        LocationId = c.Int(nullable: false),
                        NidNo = c.String(maxLength: 10),
                        PassportNo = c.String(maxLength: 30),
                        TinNo = c.String(maxLength: 30),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmpId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Designations", t => t.DesignationId, cascadeDelete: true)
                .ForeignKey("dbo.Divisions", t => t.DivisionId, cascadeDelete: true)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: true)
                .ForeignKey("dbo.ProductGrades", t => t.GradeId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.EmpId, unique: true, name: "UniqueEmployeeId")
                .Index(t => t.GradeId)
                .Index(t => t.DesignationId)
                .Index(t => t.DepartmentId)
                .Index(t => t.DivisionId)
                .Index(t => t.LocationId)
                .Index(t => t.NidNo, unique: true, name: "UniqueNidNo")
                .Index(t => t.PassportNo, unique: true, name: "UniquePassportNo")
                .Index(t => t.TinNo, unique: true, name: "UniqueTinNo")
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        isActive = c.Boolean(nullable: false),
                        UpdateBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UpdateBy)
                .Index(t => t.UpdateBy);
            
            CreateTable(
                "dbo.ProductGrades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        isActive = c.Boolean(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        UpdateBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UpdateBy)
                .Index(t => t.UpdateBy);
            
            CreateTable(
                "dbo.MonitoringManagers",
                c => new
                    {
                        MonitoringManagerId = c.String(nullable: false, maxLength: 7),
                        Name = c.String(nullable: false),
                        PresentAddress = c.String(nullable: false, maxLength: 250),
                        PermaanentAddress = c.String(nullable: false, maxLength: 250),
                        PhoneNo = c.String(nullable: false, maxLength: 11),
                        Email = c.String(nullable: false, maxLength: 100),
                        JoiningDate = c.DateTime(nullable: false),
                        LeavingDate = c.DateTime(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        NidNo = c.String(nullable: false, maxLength: 10),
                        FatherName = c.String(nullable: false, maxLength: 100),
                        MotherName = c.String(nullable: false, maxLength: 100),
                        Gender = c.String(nullable: false),
                        TaskId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MonitoringManagerId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.MonitoringManagerId, unique: true, name: "UniqueMonitoringManagerId")
                .Index(t => t.UserId);
            
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
                "dbo.ProductColors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        ProductColorCode = c.String(nullable: false, maxLength: 50),
                        isActive = c.Boolean(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        UpdateBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UpdateBy)
                .Index(t => t.UpdateBy);
            
            CreateTable(
                "dbo.ProductSizes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        ProductMeasurement = c.String(nullable: false, maxLength: 50),
                        isActive = c.Boolean(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        UpdateBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UpdateBy)
                .Index(t => t.UpdateBy);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Image = c.String(),
                        EntryDate = c.DateTime(nullable: false),
                        FinishDate = c.DateTime(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        UpdateBy = c.Int(),
                        LocationId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.LocationId)
                .ForeignKey("dbo.Users", t => t.UpdateBy)
                .Index(t => t.UpdateBy)
                .Index(t => t.LocationId);
            
            CreateTable(
                "dbo.UnitOfProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Quantity = c.Int(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        UpdateBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UpdateBy)
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Units", "UpdateBy", "dbo.Users");
            DropForeignKey("dbo.UnitOfProducts", "UpdateBy", "dbo.Users");
            DropForeignKey("dbo.Tasks", "UpdateBy", "dbo.Users");
            DropForeignKey("dbo.Tasks", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.ProductSizes", "UpdateBy", "dbo.Users");
            DropForeignKey("dbo.ProductColors", "UpdateBy", "dbo.Users");
            DropForeignKey("dbo.Orders", "UpdateBy", "dbo.Users");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.MonitoringManagers", "UserId", "dbo.Users");
            DropForeignKey("dbo.Employees", "UserId", "dbo.Users");
            DropForeignKey("dbo.Employees", "GradeId", "dbo.ProductGrades");
            DropForeignKey("dbo.ProductGrades", "UpdateBy", "dbo.Users");
            DropForeignKey("dbo.Employees", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.Locations", "UpdateBy", "dbo.Users");
            DropForeignKey("dbo.Employees", "DivisionId", "dbo.Divisions");
            DropForeignKey("dbo.Employees", "DesignationId", "dbo.Designations");
            DropForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Divisions", "UpdateBy", "dbo.Users");
            DropForeignKey("dbo.Designations", "UpdateBy", "dbo.Users");
            DropForeignKey("dbo.Departments", "UpdateBy", "dbo.Users");
            DropForeignKey("dbo.Customers", "ClubId", "dbo.Clubs");
            DropForeignKey("dbo.ClubManagers", "UserId", "dbo.Users");
            DropForeignKey("dbo.ClubManagers", "ClubId", "dbo.Clubs");
            DropForeignKey("dbo.Clubs", "UpdateBy", "dbo.Users");
            DropForeignKey("dbo.Categories", "UpdateBy", "dbo.Users");
            DropIndex("dbo.Units", new[] { "UpdateBy" });
            DropIndex("dbo.UnitOfProducts", new[] { "UpdateBy" });
            DropIndex("dbo.Tasks", new[] { "LocationId" });
            DropIndex("dbo.Tasks", new[] { "UpdateBy" });
            DropIndex("dbo.ProductSizes", new[] { "UpdateBy" });
            DropIndex("dbo.ProductColors", new[] { "UpdateBy" });
            DropIndex("dbo.Orders", new[] { "UpdateBy" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.Orders", "UniqueOrderId");
            DropIndex("dbo.MonitoringManagers", new[] { "UserId" });
            DropIndex("dbo.MonitoringManagers", "UniqueMonitoringManagerId");
            DropIndex("dbo.ProductGrades", new[] { "UpdateBy" });
            DropIndex("dbo.Locations", new[] { "UpdateBy" });
            DropIndex("dbo.Employees", new[] { "UserId" });
            DropIndex("dbo.Employees", "UniqueTinNo");
            DropIndex("dbo.Employees", "UniquePassportNo");
            DropIndex("dbo.Employees", "UniqueNidNo");
            DropIndex("dbo.Employees", new[] { "LocationId" });
            DropIndex("dbo.Employees", new[] { "DivisionId" });
            DropIndex("dbo.Employees", new[] { "DepartmentId" });
            DropIndex("dbo.Employees", new[] { "DesignationId" });
            DropIndex("dbo.Employees", new[] { "GradeId" });
            DropIndex("dbo.Employees", "UniqueEmployeeId");
            DropIndex("dbo.Divisions", new[] { "UpdateBy" });
            DropIndex("dbo.Designations", new[] { "UpdateBy" });
            DropIndex("dbo.Departments", new[] { "UpdateBy" });
            DropIndex("dbo.Customers", new[] { "ClubId" });
            DropIndex("dbo.Customers", "UniquePhoneNo");
            DropIndex("dbo.Clubs", new[] { "UpdateBy" });
            DropIndex("dbo.ClubManagers", new[] { "ClubId" });
            DropIndex("dbo.ClubManagers", "UniqueClubManagerId");
            DropIndex("dbo.ClubManagers", new[] { "UserId" });
            DropIndex("dbo.Categories", new[] { "UpdateBy" });
            DropTable("dbo.Units");
            DropTable("dbo.UnitOfProducts");
            DropTable("dbo.Tasks");
            DropTable("dbo.ProductSizes");
            DropTable("dbo.ProductColors");
            DropTable("dbo.Orders");
            DropTable("dbo.MonitoringManagers");
            DropTable("dbo.ProductGrades");
            DropTable("dbo.Locations");
            DropTable("dbo.Employees");
            DropTable("dbo.Divisions");
            DropTable("dbo.Designations");
            DropTable("dbo.Departments");
            DropTable("dbo.Customers");
            DropTable("dbo.Clubs");
            DropTable("dbo.ClubManagers");
            DropTable("dbo.Users");
            DropTable("dbo.Categories");
        }
    }
}
