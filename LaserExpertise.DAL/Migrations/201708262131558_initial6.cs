namespace LaserExpertise.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "BirthDay", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "BirthDay");
        }
    }
}
