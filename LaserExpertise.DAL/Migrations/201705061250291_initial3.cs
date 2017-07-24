namespace LaserExpertise.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial3 : DbMigration
    {
        public override void Up()
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Services", t => t.ServiceId)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.ServiceId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServiceStates", "UserId", "dbo.Users");
            DropForeignKey("dbo.ServiceStates", "ServiceId", "dbo.Services");
            DropIndex("dbo.ServiceStates", new[] { "UserId" });
            DropIndex("dbo.ServiceStates", new[] { "ServiceId" });
            DropTable("dbo.Services");
            DropTable("dbo.ServiceStates");
        }
    }
}
