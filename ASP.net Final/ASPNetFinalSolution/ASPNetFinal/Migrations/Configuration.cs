namespace ASPNetFinal.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ASPNetFinal.Models.Entity;

    internal sealed class Configuration : DbMigrationsConfiguration<ASPNetFinal.Models.CvDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ASPNetFinal.Models.CvDbContext context)
        {
            try
            {
                if (!context.Person.Any())
                {
                    context.Person.AddRange(new[]
                {
                        new Person
                        {
                                Name = "Vusal",
                                 Email = "vusalim@code.edu.az",
                                  Phone = "+994504843471",
                                   Age = 27,
                                    CareerLevel ="Hight",
                                     Experience = "6 years",
                                      Fax = "4545848848",
                                       Location = "Baki",
                                        Image ="",
                                         Website = "Vusal.com",

                        }

                    });
                }


                if (!context.Admin.Any())
                {
                    context.Admin.AddRange(new[]
                    {
                        new Admin
                        {
                                Email ="vusalim@code.edu.az",
                                 Password = "admin123",
                                  
                        }

                    });
                }

                if (!context.SocialProfiles.Any())
                {
                    context.SocialProfiles.AddRange(new[]
                    {
                        new SocialProfiles
                        {
                                Facebook = "http://facebook.com/vusal242a",
                                 
                                 

                        }

                    }); ;
                }






            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}

