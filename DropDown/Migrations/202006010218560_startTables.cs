namespace DropDown.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class startTables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.States", "Country_id", "dbo.Countries");
            DropIndex("dbo.States", new[] { "Country_id" });
            AlterColumn("dbo.States", "country_id", c => c.Int(nullable: false));
            CreateIndex("dbo.States", "country_id");
            AddForeignKey("dbo.States", "country_id", "dbo.Countries", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.States", "country_id", "dbo.Countries");
            DropIndex("dbo.States", new[] { "country_id" });
            AlterColumn("dbo.States", "country_id", c => c.Int());
            CreateIndex("dbo.States", "Country_id");
            AddForeignKey("dbo.States", "Country_id", "dbo.Countries", "id");
        }
    }
}
