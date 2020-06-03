namespace DropDown.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClinicTableAndRelateItWithCityTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cities", "ClinicId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cities", "ClinicId");
        }
    }
}
