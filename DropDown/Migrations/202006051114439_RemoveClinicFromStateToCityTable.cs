namespace DropDown.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveClinicFromStateToCityTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clinics", "State_state_id", "dbo.States");
            DropIndex("dbo.Clinics", new[] { "State_state_id" });
            AddColumn("dbo.Clinics", "City_id", c => c.Int());
            CreateIndex("dbo.Clinics", "City_id");
            AddForeignKey("dbo.Clinics", "City_id", "dbo.Cities", "id");
            DropColumn("dbo.States", "ClinicId");
            DropColumn("dbo.Clinics", "State_state_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clinics", "State_state_id", c => c.Int());
            AddColumn("dbo.States", "ClinicId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Clinics", "City_id", "dbo.Cities");
            DropIndex("dbo.Clinics", new[] { "City_id" });
            DropColumn("dbo.Clinics", "City_id");
            CreateIndex("dbo.Clinics", "State_state_id");
            AddForeignKey("dbo.Clinics", "State_state_id", "dbo.States", "state_id");
        }
    }
}
