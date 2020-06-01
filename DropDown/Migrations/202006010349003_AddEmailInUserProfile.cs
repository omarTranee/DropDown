namespace DropDown.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmailInUserProfile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfiles", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserProfiles", "Email");
        }
    }
}
