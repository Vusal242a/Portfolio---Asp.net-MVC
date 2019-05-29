namespace ASPNetFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VusalCVv10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AcademicBackgrounds", "Image", c => c.String());
            AddColumn("dbo.BioSkills", "Image", c => c.String());
            AddColumn("dbo.ProfessionalExperiences", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProfessionalExperiences", "Image");
            DropColumn("dbo.BioSkills", "Image");
            DropColumn("dbo.AcademicBackgrounds", "Image");
        }
    }
}
