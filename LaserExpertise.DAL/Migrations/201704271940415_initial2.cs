namespace LaserExpertise.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pictures", "ArtistId", "dbo.Users");
            DropIndex("dbo.Pictures", new[] { "ArtistId" });
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.ArtistId)
                .Index(t => t.ArtistId);
            
            AddColumn("dbo.Pictures", "ArtworkId", c => c.Int());
            CreateIndex("dbo.Pictures", "ArtworkId");
            AddForeignKey("dbo.Pictures", "ArtworkId", "dbo.Artworks", "Id");
            DropColumn("dbo.Pictures", "Name");
            DropColumn("dbo.Pictures", "ArtistId");
            DropColumn("dbo.Pictures", "Genre");
            DropColumn("dbo.Pictures", "School");
            DropColumn("dbo.Pictures", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pictures", "Description", c => c.String());
            AddColumn("dbo.Pictures", "School", c => c.String());
            AddColumn("dbo.Pictures", "Genre", c => c.String());
            AddColumn("dbo.Pictures", "ArtistId", c => c.Int());
            AddColumn("dbo.Pictures", "Name", c => c.String());
            DropForeignKey("dbo.Pictures", "ArtworkId", "dbo.Artworks");
            DropForeignKey("dbo.Artworks", "ArtistId", "dbo.Users");
            DropIndex("dbo.Pictures", new[] { "ArtworkId" });
            DropIndex("dbo.Artworks", new[] { "ArtistId" });
            DropColumn("dbo.Pictures", "ArtworkId");
            DropTable("dbo.Artworks");
            CreateIndex("dbo.Pictures", "ArtistId");
            AddForeignKey("dbo.Pictures", "ArtistId", "dbo.Users", "Id");
        }
    }
}
