namespace DropDown.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyRelations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clinics", "CityId", "dbo.Cities");
            DropIndex("dbo.Clinics", new[] { "CityId" });
            AddColumn("dbo.States", "ClinicId", c => c.Int(nullable: false));
            AddColumn("dbo.Clinics", "StateID", c => c.Int(nullable: false));
            AddColumn("dbo.Clinics", "State_state_id", c => c.Int());
            CreateIndex("dbo.Clinics", "State_state_id");
            AddForeignKey("dbo.Clinics", "State_state_id", "dbo.States", "state_id");
            DropColumn("dbo.Cities", "ClinicId");
            DropColumn("dbo.Clinics", "CityId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clinics", "CityId", c => c.Int(nullable: false));
            AddColumn("dbo.Cities", "ClinicId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Clinics", "State_state_id", "dbo.States");
            DropIndex("dbo.Clinics", new[] { "State_state_id" });
            DropColumn("dbo.Clinics", "State_state_id");
            DropColumn("dbo.Clinics", "StateID");
            DropColumn("dbo.States", "ClinicId");
            CreateIndex("dbo.Clinics", "CityId");
            AddForeignKey("dbo.Clinics", "CityId", "dbo.Cities", "id", cascadeDelete: true);
        }
    }
}
