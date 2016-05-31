namespace Doser.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bunkers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Output = c.Int(nullable: false),
                        isActive = c.Boolean(nullable: false),
                        UseImpulseMode = c.Boolean(nullable: false),
                        Prevention = c.Int(nullable: false),
                        PauseInterval = c.Int(nullable: false),
                        ImpMin = c.Int(nullable: false),
                        ImpMax = c.Int(nullable: false),
                        PauseIntervalSmall = c.Int(nullable: false),
                        ImpMinSmall = c.Int(nullable: false),
                        ImpMaxSmall = c.Int(nullable: false),
                        EnterImpModeValue = c.Double(nullable: false),
                        SmallDose = c.Double(nullable: false),
                        Inaccuracy = c.Double(nullable: false),
                        TimeCreate = c.DateTime(),
                        TimeDeleted = c.DateTime(),
                        isDeleted = c.Boolean(nullable: false),
                        Description = c.String(),
                        Material_Id = c.Int(nullable: false),
                        Terminal_Id = c.Int(nullable: false),
                        UserCreate_Id = c.Int(),
                        UserDeleted_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Materials", t => t.Material_Id, cascadeDelete: true)
                .ForeignKey("dbo.Terminals", t => t.Terminal_Id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserCreate_Id)
                .ForeignKey("dbo.Users", t => t.UserDeleted_Id)
                .Index(t => t.Material_Id)
                .Index(t => t.Terminal_Id)
                .Index(t => t.UserCreate_Id)
                .Index(t => t.UserDeleted_Id);
            
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code1c = c.String(),
                        TimeCreate = c.DateTime(),
                        TimeDeleted = c.DateTime(),
                        isDeleted = c.Boolean(nullable: false),
                        Description = c.String(),
                        UserCreate_Id = c.Int(),
                        UserDeleted_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserCreate_Id)
                .ForeignKey("dbo.Users", t => t.UserDeleted_Id)
                .Index(t => t.UserCreate_Id)
                .Index(t => t.UserDeleted_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Password = c.String(),
                        Role = c.Int(nullable: false),
                        TimeCreate = c.DateTime(),
                        TimeDeleted = c.DateTime(),
                        isDeleted = c.Boolean(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Terminals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address485 = c.Int(nullable: false),
                        IPAddress = c.String(),
                        EmptyWeigth = c.Double(nullable: false),
                        TimeCreate = c.DateTime(),
                        TimeDeleted = c.DateTime(),
                        isDeleted = c.Boolean(nullable: false),
                        Description = c.String(),
                        ComPort_Id = c.Int(),
                        Line_Id = c.Int(),
                        UserCreate_Id = c.Int(),
                        UserDeleted_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ports", t => t.ComPort_Id)
                .ForeignKey("dbo.Lines", t => t.Line_Id)
                .ForeignKey("dbo.Users", t => t.UserCreate_Id)
                .ForeignKey("dbo.Users", t => t.UserDeleted_Id)
                .Index(t => t.ComPort_Id)
                .Index(t => t.Line_Id)
                .Index(t => t.UserCreate_Id)
                .Index(t => t.UserDeleted_Id);
            
            CreateTable(
                "dbo.Ports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Speed = c.String(),
                        Parity = c.Int(nullable: false),
                        TimeCreate = c.DateTime(),
                        TimeDeleted = c.DateTime(),
                        isDeleted = c.Boolean(nullable: false),
                        Description = c.String(),
                        UserCreate_Id = c.Int(),
                        UserDeleted_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserCreate_Id)
                .ForeignKey("dbo.Users", t => t.UserDeleted_Id)
                .Index(t => t.UserCreate_Id)
                .Index(t => t.UserDeleted_Id);
            
            CreateTable(
                "dbo.Lines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TimeCreate = c.DateTime(),
                        TimeDeleted = c.DateTime(),
                        isDeleted = c.Boolean(nullable: false),
                        Description = c.String(),
                        Port_Id = c.Int(),
                        UserCreate_Id = c.Int(),
                        UserDeleted_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ports", t => t.Port_Id)
                .ForeignKey("dbo.Users", t => t.UserCreate_Id)
                .ForeignKey("dbo.Users", t => t.UserDeleted_Id)
                .Index(t => t.Port_Id)
                .Index(t => t.UserCreate_Id)
                .Index(t => t.UserDeleted_Id);
            
            CreateTable(
                "dbo.Components",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UseImpMode = c.Boolean(nullable: false),
                        TargetWeigth = c.Double(nullable: false),
                        ResultWeigth = c.Double(nullable: false),
                        ProductVolume = c.Double(nullable: false),
                        TimeStart = c.DateTime(),
                        TimeFinished = c.DateTime(),
                        Status = c.Int(nullable: false),
                        Bunker_Id = c.Int(),
                        Material_Id = c.Int(),
                        Port_Id = c.Int(),
                        Terminal_Id = c.Int(),
                        User_Id = c.Int(),
                        Protocol_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bunkers", t => t.Bunker_Id)
                .ForeignKey("dbo.Materials", t => t.Material_Id)
                .ForeignKey("dbo.Ports", t => t.Port_Id)
                .ForeignKey("dbo.Terminals", t => t.Terminal_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Protocols", t => t.Protocol_Id)
                .Index(t => t.Bunker_Id)
                .Index(t => t.Material_Id)
                .Index(t => t.Port_Id)
                .Index(t => t.Terminal_Id)
                .Index(t => t.User_Id)
                .Index(t => t.Protocol_Id);
            
            CreateTable(
                "dbo.Consumers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code1c = c.String(),
                        TimeCreate = c.DateTime(),
                        TimeDeleted = c.DateTime(),
                        isDeleted = c.Boolean(nullable: false),
                        Description = c.String(),
                        UserCreate_Id = c.Int(),
                        UserDeleted_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserCreate_Id)
                .ForeignKey("dbo.Users", t => t.UserDeleted_Id)
                .Index(t => t.UserCreate_Id)
                .Index(t => t.UserDeleted_Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Code1c = c.String(),
                        TimeCreate = c.DateTime(),
                        TimeDeleted = c.DateTime(),
                        isDeleted = c.Boolean(nullable: false),
                        Description = c.String(),
                        UserCreate_Id = c.Int(),
                        UserDeleted_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserCreate_Id)
                .ForeignKey("dbo.Users", t => t.UserDeleted_Id)
                .Index(t => t.UserCreate_Id)
                .Index(t => t.UserDeleted_Id);
            
            CreateTable(
                "dbo.Protocols",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UseManual = c.Boolean(nullable: false),
                        TargetWeigth = c.Double(nullable: false),
                        ResultWeigth = c.Double(nullable: false),
                        ProductVolume = c.Double(nullable: false),
                        TimeStart = c.DateTime(),
                        TimeFinished = c.DateTime(),
                        Status = c.Int(nullable: false),
                        Consumer_Id = c.Int(),
                        Line_Id = c.Int(),
                        Product_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Consumers", t => t.Consumer_Id)
                .ForeignKey("dbo.Lines", t => t.Line_Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Consumer_Id)
                .Index(t => t.Line_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.RecipeElements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Weigth = c.Double(nullable: false),
                        Description = c.String(),
                        Material_Id = c.Int(),
                        Recipe_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Materials", t => t.Material_Id)
                .ForeignKey("dbo.Recipes", t => t.Recipe_Id)
                .Index(t => t.Material_Id)
                .Index(t => t.Recipe_Id);
            
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TimeCreate = c.DateTime(nullable: false),
                        TimeDeleted = c.DateTime(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                        Description = c.String(),
                        Product_Id = c.Int(),
                        UserCreate_Id = c.Int(),
                        UserDeleted_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.Users", t => t.UserCreate_Id)
                .ForeignKey("dbo.Users", t => t.UserDeleted_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.UserCreate_Id)
                .Index(t => t.UserDeleted_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Recipes", "UserDeleted_Id", "dbo.Users");
            DropForeignKey("dbo.Recipes", "UserCreate_Id", "dbo.Users");
            DropForeignKey("dbo.Recipes", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.RecipeElements", "Recipe_Id", "dbo.Recipes");
            DropForeignKey("dbo.RecipeElements", "Material_Id", "dbo.Materials");
            DropForeignKey("dbo.Protocols", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Protocols", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Protocols", "Line_Id", "dbo.Lines");
            DropForeignKey("dbo.Protocols", "Consumer_Id", "dbo.Consumers");
            DropForeignKey("dbo.Components", "Protocol_Id", "dbo.Protocols");
            DropForeignKey("dbo.Products", "UserDeleted_Id", "dbo.Users");
            DropForeignKey("dbo.Products", "UserCreate_Id", "dbo.Users");
            DropForeignKey("dbo.Consumers", "UserDeleted_Id", "dbo.Users");
            DropForeignKey("dbo.Consumers", "UserCreate_Id", "dbo.Users");
            DropForeignKey("dbo.Components", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Components", "Terminal_Id", "dbo.Terminals");
            DropForeignKey("dbo.Components", "Port_Id", "dbo.Ports");
            DropForeignKey("dbo.Components", "Material_Id", "dbo.Materials");
            DropForeignKey("dbo.Components", "Bunker_Id", "dbo.Bunkers");
            DropForeignKey("dbo.Bunkers", "UserDeleted_Id", "dbo.Users");
            DropForeignKey("dbo.Bunkers", "UserCreate_Id", "dbo.Users");
            DropForeignKey("dbo.Bunkers", "Terminal_Id", "dbo.Terminals");
            DropForeignKey("dbo.Terminals", "UserDeleted_Id", "dbo.Users");
            DropForeignKey("dbo.Terminals", "UserCreate_Id", "dbo.Users");
            DropForeignKey("dbo.Terminals", "Line_Id", "dbo.Lines");
            DropForeignKey("dbo.Lines", "UserDeleted_Id", "dbo.Users");
            DropForeignKey("dbo.Lines", "UserCreate_Id", "dbo.Users");
            DropForeignKey("dbo.Lines", "Port_Id", "dbo.Ports");
            DropForeignKey("dbo.Terminals", "ComPort_Id", "dbo.Ports");
            DropForeignKey("dbo.Ports", "UserDeleted_Id", "dbo.Users");
            DropForeignKey("dbo.Ports", "UserCreate_Id", "dbo.Users");
            DropForeignKey("dbo.Bunkers", "Material_Id", "dbo.Materials");
            DropForeignKey("dbo.Materials", "UserDeleted_Id", "dbo.Users");
            DropForeignKey("dbo.Materials", "UserCreate_Id", "dbo.Users");
            DropIndex("dbo.Recipes", new[] { "UserDeleted_Id" });
            DropIndex("dbo.Recipes", new[] { "UserCreate_Id" });
            DropIndex("dbo.Recipes", new[] { "Product_Id" });
            DropIndex("dbo.RecipeElements", new[] { "Recipe_Id" });
            DropIndex("dbo.RecipeElements", new[] { "Material_Id" });
            DropIndex("dbo.Protocols", new[] { "User_Id" });
            DropIndex("dbo.Protocols", new[] { "Product_Id" });
            DropIndex("dbo.Protocols", new[] { "Line_Id" });
            DropIndex("dbo.Protocols", new[] { "Consumer_Id" });
            DropIndex("dbo.Products", new[] { "UserDeleted_Id" });
            DropIndex("dbo.Products", new[] { "UserCreate_Id" });
            DropIndex("dbo.Consumers", new[] { "UserDeleted_Id" });
            DropIndex("dbo.Consumers", new[] { "UserCreate_Id" });
            DropIndex("dbo.Components", new[] { "Protocol_Id" });
            DropIndex("dbo.Components", new[] { "User_Id" });
            DropIndex("dbo.Components", new[] { "Terminal_Id" });
            DropIndex("dbo.Components", new[] { "Port_Id" });
            DropIndex("dbo.Components", new[] { "Material_Id" });
            DropIndex("dbo.Components", new[] { "Bunker_Id" });
            DropIndex("dbo.Lines", new[] { "UserDeleted_Id" });
            DropIndex("dbo.Lines", new[] { "UserCreate_Id" });
            DropIndex("dbo.Lines", new[] { "Port_Id" });
            DropIndex("dbo.Ports", new[] { "UserDeleted_Id" });
            DropIndex("dbo.Ports", new[] { "UserCreate_Id" });
            DropIndex("dbo.Terminals", new[] { "UserDeleted_Id" });
            DropIndex("dbo.Terminals", new[] { "UserCreate_Id" });
            DropIndex("dbo.Terminals", new[] { "Line_Id" });
            DropIndex("dbo.Terminals", new[] { "ComPort_Id" });
            DropIndex("dbo.Materials", new[] { "UserDeleted_Id" });
            DropIndex("dbo.Materials", new[] { "UserCreate_Id" });
            DropIndex("dbo.Bunkers", new[] { "UserDeleted_Id" });
            DropIndex("dbo.Bunkers", new[] { "UserCreate_Id" });
            DropIndex("dbo.Bunkers", new[] { "Terminal_Id" });
            DropIndex("dbo.Bunkers", new[] { "Material_Id" });
            DropTable("dbo.Recipes");
            DropTable("dbo.RecipeElements");
            DropTable("dbo.Protocols");
            DropTable("dbo.Products");
            DropTable("dbo.Consumers");
            DropTable("dbo.Components");
            DropTable("dbo.Lines");
            DropTable("dbo.Ports");
            DropTable("dbo.Terminals");
            DropTable("dbo.Users");
            DropTable("dbo.Materials");
            DropTable("dbo.Bunkers");
        }
    }
}
