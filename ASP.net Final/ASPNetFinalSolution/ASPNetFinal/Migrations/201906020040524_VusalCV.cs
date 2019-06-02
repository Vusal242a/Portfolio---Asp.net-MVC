namespace ASPNetFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VusalCV : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AcademicBackgrounds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Qualification = c.String(maxLength: 150),
                        Degree = c.String(maxLength: 150),
                        UniversityName = c.String(maxLength: 100),
                        YearOfObtention = c.String(maxLength: 100),
                        Details = c.String(maxLength: 500),
                        CreatedDate = c.DateTime(),
                        DeletedDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Password = c.String(),
                        CreatedDate = c.DateTime(),
                        DeletedDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BioSkills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Description = c.String(maxLength: 500),
                        SkillLeve = c.Int(nullable: false),
                        SkillDescription = c.String(maxLength: 500),
                        AsBar = c.Boolean(nullable: false),
                        AsTag = c.Boolean(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        SkillsId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        DeletedDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Skills", t => t.SkillsId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.SkillsId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedDate = c.DateTime(),
                        DeletedDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedDate = c.DateTime(),
                        DeletedDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ContactMes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 100),
                        Subject = c.String(nullable: false, maxLength: 50),
                        Content = c.String(nullable: false, maxLength: 500),
                        Answer = c.String(),
                        IsRead = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(),
                        DeletedDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ErrorHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AreaName = c.String(),
                        ControllerName = c.String(),
                        ActionName = c.String(),
                        ErrorCode = c.Int(),
                        ErrorMessage = c.String(),
                        CreatedDate = c.DateTime(),
                        DeletedDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Name = c.String(nullable: false, maxLength: 50),
                        Age = c.Int(),
                        Location = c.String(maxLength: 100),
                        Experience = c.String(maxLength: 30),
                        Degree = c.String(maxLength: 50),
                        CareerLevel = c.String(maxLength: 100),
                        Phone = c.String(nullable: false, maxLength: 25),
                        Fax = c.String(maxLength: 25),
                        Email = c.String(nullable: false, maxLength: 50),
                        Website = c.String(maxLength: 50),
                        CreatedDate = c.DateTime(),
                        DeletedDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProfessionalExperiences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Duration = c.String(maxLength: 10),
                        JobTitle = c.String(maxLength: 150),
                        CompanyName = c.String(maxLength: 100),
                        Location = c.String(maxLength: 100),
                        Details = c.String(maxLength: 500),
                        CreatedDate = c.DateTime(),
                        DeletedDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SocialProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Facebook = c.String(maxLength: 100),
                        Twitter = c.String(maxLength: 100),
                        Google = c.String(maxLength: 100),
                        LinkedIn = c.String(maxLength: 100),
                        Dribble = c.String(maxLength: 100),
                        Behance = c.String(maxLength: 100),
                        Stumbleupon = c.String(maxLength: 100),
                        CreatedDate = c.DateTime(),
                        DeletedDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BioSkills", "SkillsId", "dbo.Skills");
            DropForeignKey("dbo.BioSkills", "CategoryId", "dbo.Categories");
            DropIndex("dbo.BioSkills", new[] { "SkillsId" });
            DropIndex("dbo.BioSkills", new[] { "CategoryId" });
            DropTable("dbo.SocialProfiles");
            DropTable("dbo.ProfessionalExperiences");
            DropTable("dbo.People");
            DropTable("dbo.ErrorHistories");
            DropTable("dbo.ContactMes");
            DropTable("dbo.Skills");
            DropTable("dbo.Categories");
            DropTable("dbo.BioSkills");
            DropTable("dbo.Admins");
            DropTable("dbo.AcademicBackgrounds");
        }
    }
}
