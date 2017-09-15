namespace LaserExpertise.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial7 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pictures", "ArtworkId", "dbo.Artworks");
            DropForeignKey("dbo.Artworks", "ArtistId", "dbo.Users");
            DropForeignKey("dbo.ServiceStates", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.ServiceStates", "UserId", "dbo.Users");
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Artworks", new[] { "ArtistId" });
            DropIndex("dbo.Pictures", new[] { "ArtworkId" });
            DropIndex("dbo.ServiceStates", new[] { "ServiceId" });
            DropIndex("dbo.ServiceStates", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.Artworks");
            DropTable("dbo.Pictures");
            DropTable("dbo.Roles");
            DropTable("dbo.Services");
            DropTable("dbo.ServiceStates");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ServiceStates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiceId = c.Int(),
                        UserId = c.Int(),
                        State = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pictures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Path = c.String(),
                        ArtworkId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Artworks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ArtistId = c.Int(),
                        Genre = c.String(),
                        School = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Password = c.String(),
                        ConfirmPassword = c.String(),
                        RoleId = c.Int(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Telephone = c.String(),
                        Skype = c.String(),
                        BirthDay = c.String(),
                        Gender = c.Int(nullable: false),
                        School = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.ServiceStates", "UserId");
            CreateIndex("dbo.ServiceStates", "ServiceId");
            CreateIndex("dbo.Pictures", "ArtworkId");
            CreateIndex("dbo.Artworks", "ArtistId");
            CreateIndex("dbo.Users", "RoleId");
            AddForeignKey("dbo.ServiceStates", "UserId", "dbo.Users", "Id");
            AddForeignKey("dbo.Users", "RoleId", "dbo.Roles", "Id");
            AddForeignKey("dbo.ServiceStates", "ServiceId", "dbo.Services", "Id");
            AddForeignKey("dbo.Artworks", "ArtistId", "dbo.Users", "Id");
            AddForeignKey("dbo.Pictures", "ArtworkId", "dbo.Artworks", "Id");
        }
    }
}
