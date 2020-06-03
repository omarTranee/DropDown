namespace DropDown.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removecolumn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Clinics", "TypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clinics", "TypeId", c => c.Int(nullable: false));
        }
    }
}
