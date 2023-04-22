namespace WpfApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        TicketId = c.Int(nullable: false, identity: true),
                        FirstNameP = c.String(nullable: false, maxLength: 30),
                        LastNameP = c.String(nullable: false, maxLength: 30),
                        CruiseId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TicketId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Cruises", t => t.CruiseId, cascadeDelete: true)
                .Index(t => t.CruiseId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Cruises",
                c => new
                    {
                        CruiseId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(),
                        RouteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CruiseId)
                .ForeignKey("dbo.Routes", t => t.RouteId, cascadeDelete: true)
                .Index(t => t.RouteId);
            
            CreateTable(
                "dbo.Routes",
                c => new
                    {
                        RouteId = c.Int(nullable: false, identity: true),
                        RouteName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.RouteId);
            
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        DestinationId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.DestinationId);
            
            CreateTable(
                "dbo.DestinationRoutes",
                c => new
                    {
                        Destination_DestinationId = c.Int(nullable: false),
                        Route_RouteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Destination_DestinationId, t.Route_RouteId })
                .ForeignKey("dbo.Destinations", t => t.Destination_DestinationId, cascadeDelete: true)
                .ForeignKey("dbo.Routes", t => t.Route_RouteId, cascadeDelete: true)
                .Index(t => t.Destination_DestinationId)
                .Index(t => t.Route_RouteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "CruiseId", "dbo.Cruises");
            DropForeignKey("dbo.DestinationRoutes", "Route_RouteId", "dbo.Routes");
            DropForeignKey("dbo.DestinationRoutes", "Destination_DestinationId", "dbo.Destinations");
            DropForeignKey("dbo.Cruises", "RouteId", "dbo.Routes");
            DropForeignKey("dbo.Tickets", "CategoryId", "dbo.Categories");
            DropIndex("dbo.DestinationRoutes", new[] { "Route_RouteId" });
            DropIndex("dbo.DestinationRoutes", new[] { "Destination_DestinationId" });
            DropIndex("dbo.Cruises", new[] { "RouteId" });
            DropIndex("dbo.Tickets", new[] { "CategoryId" });
            DropIndex("dbo.Tickets", new[] { "CruiseId" });
            DropTable("dbo.DestinationRoutes");
            DropTable("dbo.Destinations");
            DropTable("dbo.Routes");
            DropTable("dbo.Cruises");
            DropTable("dbo.Tickets");
            DropTable("dbo.Categories");
        }
    }
}
