namespace DropDown.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDAtaToCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories (Name) VALUES ('Dermatology (Skin)')");
            Sql("INSERT INTO Categories (Name) VALUES ('Psychiatry (Mental, Emotional or Behavioral Disorders)')");

            Sql("INSERT INTO Categories (Name) VALUES ('Pediatrics and New Born (Child)')");
            Sql("INSERT INTO Categories (Name) VALUES ('Neurology (Brain & Nerves)')");
            Sql("INSERT INTO Categories (Name) VALUES ('Orthopedics (Bones)')");
            Sql("INSERT INTO Categories (Name) VALUES ('Gynaecology and Infertility')");
            Sql("INSERT INTO Categories (Name) VALUES ('Ear, Nose and Throat')");
            Sql("INSERT INTO Categories (Name) VALUES ('Cardiology and Vascular Disease (Heart)')");
            Sql("INSERT INTO Categories (Name) VALUES ('Allergy and Immunology (Sensitivity and Immunity)')");
        }
        
        public override void Down()
        {
        }
    }
}
