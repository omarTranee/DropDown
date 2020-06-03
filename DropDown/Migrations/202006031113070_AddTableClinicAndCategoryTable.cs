namespace DropDown.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableClinicAndCategoryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clinics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CityId = c.Int(nullable: false),
                        TypeId = c.Int(nullable: false),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId)
                .Index(t => t.Category_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clinics", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Clinics", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Clinics", new[] { "Category_Id" });
            DropIndex("dbo.Clinics", new[] { "CityId" });
            DropTable("dbo.Clinics");
            DropTable("dbo.Categories");
        }
    }
}
