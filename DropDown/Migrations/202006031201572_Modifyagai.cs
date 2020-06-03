namespace DropDown.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Modifyagai : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Clinics", "StateId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clinics", "StateId", c => c.Int(nullable: false));
        }
    }
}
