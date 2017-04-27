namespace LaserExpertise.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
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
                        Gender = c.Int(nullable: false),
                        School = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Pictures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ArtistId = c.Int(),
                        Genre = c.String(),
                        School = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.ArtistId)
                .Index(t => t.ArtistId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Pictures", "ArtistId", "dbo.Users");
            DropIndex("dbo.Pictures", new[] { "ArtistId" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropTable("dbo.Roles");
            DropTable("dbo.Pictures");
            DropTable("dbo.Users");
        }
    }
}
