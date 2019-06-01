using ASPNetFinal.Models.Entity;
using System.Data.Entity;


namespace ASPNetFinal.Models
{
    public class CvDbContext : DbContext
    {
        public CvDbContext()
            : base("name=cString")
        {

        }
        public DbSet<Person> Person { get; set; }
        public DbSet<AcademicBackground> AAcademicBackgroundca { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<BioSkills> BioSkills { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ContactMe> ContactMe { get; set; }
        public DbSet<ProfessionalExperience> ProfessionalExperience { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<ErrorHistory> ErrorHistories { get; set; }
        public DbSet<SocialProfiles> SocialProfiles { get; set; }
    }
}