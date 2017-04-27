namespace LaserExpertise.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pictures", "Path", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pictures", "Path");
        }
    }
}
