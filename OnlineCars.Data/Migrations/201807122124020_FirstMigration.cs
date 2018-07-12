namespace OnlineCars.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdditionalInfoes",
                c => new
                    {
                        AdditionalInfoID = c.Int(nullable: false, identity: true),
                        bids = c.Int(nullable: false),
                        endDate = c.Long(nullable: false),
                        endDateEn = c.DateTime(nullable: false),
                        endDateAr = c.DateTime(nullable: false),
                        currencyEn = c.String(),
                        currencyAr = c.String(),
                        currentPrice = c.Double(nullable: false),
                        minIncrement = c.Double(nullable: false),
                        lot = c.Long(nullable: false),
                        priority = c.Int(nullable: false),
                        VATPercent = c.Int(nullable: false),
                        isModified = c.Int(nullable: false),
                        itemid = c.Int(nullable: false),
                        iCarId = c.Int(nullable: false),
                        iVinNumber = c.String(),
                    })
                .PrimaryKey(t => t.AdditionalInfoID);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        CarID = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Description_Ar = c.String(),
                        Description_En = c.String(),
                        imgCount = c.Int(nullable: false),
                        SharingLink = c.String(),
                        mileage = c.String(),
                        year = c.Int(nullable: false),
                        AdditionalInfoID = c.Int(nullable: false),
                        CompanyID = c.Int(nullable: false),
                        modelID = c.Int(nullable: false),
                        makeID = c.Int(nullable: false),
                        bodyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CarID)
                .ForeignKey("dbo.AdditionalInfoes", t => t.AdditionalInfoID, cascadeDelete: true)
                .ForeignKey("dbo.AuctionCompanies", t => t.CompanyID, cascadeDelete: true)
                .ForeignKey("dbo.Bodies", t => t.bodyId, cascadeDelete: true)
                .ForeignKey("dbo.Makes", t => t.makeID, cascadeDelete: true)
                .ForeignKey("dbo.Models", t => t.modelID, cascadeDelete: true)
                .Index(t => t.AdditionalInfoID)
                .Index(t => t.CompanyID)
                .Index(t => t.modelID)
                .Index(t => t.makeID)
                .Index(t => t.bodyId);
            
            CreateTable(
                "dbo.AuctionCompanies",
                c => new
                    {
                        CompanyID = c.Int(nullable: false, identity: true),
                        CompanyNameEn = c.String(),
                        CompanyNameAr = c.String(),
                    })
                .PrimaryKey(t => t.CompanyID);
            
            CreateTable(
                "dbo.Bodies",
                c => new
                    {
                        bodyId = c.Int(nullable: false, identity: true),
                        bodyEn = c.String(),
                        bodyAr = c.String(),
                    })
                .PrimaryKey(t => t.bodyId);
            
            CreateTable(
                "dbo.Makes",
                c => new
                    {
                        makeID = c.Int(nullable: false, identity: true),
                        makeEn = c.String(),
                        makeAr = c.String(),
                    })
                .PrimaryKey(t => t.makeID);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        modelID = c.Int(nullable: false, identity: true),
                        modelAr = c.String(),
                        modelEn = c.String(),
                    })
                .PrimaryKey(t => t.modelID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "modelID", "dbo.Models");
            DropForeignKey("dbo.Cars", "makeID", "dbo.Makes");
            DropForeignKey("dbo.Cars", "bodyId", "dbo.Bodies");
            DropForeignKey("dbo.Cars", "CompanyID", "dbo.AuctionCompanies");
            DropForeignKey("dbo.Cars", "AdditionalInfoID", "dbo.AdditionalInfoes");
            DropIndex("dbo.Cars", new[] { "bodyId" });
            DropIndex("dbo.Cars", new[] { "makeID" });
            DropIndex("dbo.Cars", new[] { "modelID" });
            DropIndex("dbo.Cars", new[] { "CompanyID" });
            DropIndex("dbo.Cars", new[] { "AdditionalInfoID" });
            DropTable("dbo.Models");
            DropTable("dbo.Makes");
            DropTable("dbo.Bodies");
            DropTable("dbo.AuctionCompanies");
            DropTable("dbo.Cars");
            DropTable("dbo.AdditionalInfoes");
        }
    }
}
