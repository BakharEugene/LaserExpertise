namespace LaserExpertise.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial5 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "BirthDay");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "BirthDay", c => c.DateTime(nullable: false));
        }
    }
}
