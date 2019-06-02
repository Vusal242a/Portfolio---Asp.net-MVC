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
                                Name = "Vusal Mahmudlu",
                                Email = "vusalim@code.edu.az",
                                Phone = "+994504843471",
                                Age = 27,
                                CareerLevel ="Web Developer",
                                Degree="Master",
                                Experience = "6 years",
                                Fax = "4545848848",
                                Location = "Baki",
                                Image ="",
                                Website = "Vusal.com",
                                CreatedDate=DateTime.Now
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
                                 CreatedDate=DateTime.Now
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
                                CreatedDate=DateTime.Now
                        }

                    }); ;
                }

                if (!context.Skills.Any())
                {
                    context.Skills.AddRange(new[]
                {
                        new Skills
                        {
                                Name = "C#",
                                CreatedDate=DateTime.Now
                        },
                        new Skills
                        {
                                Name = "ASP.Net",
                                CreatedDate=DateTime.Now
                        },
                        new Skills
                        {
                                Name = "Java-Script",
                                CreatedDate=DateTime.Now
                        },
                        new Skills
                        {
                                Name ="JQuery",
                                CreatedDate=DateTime.Now
                        },
                        new Skills
                        {
                                Name = "HTML5",
                                CreatedDate=DateTime.Now
                        },
                        new Skills
                        {
                                Name = "CSS3",
                                CreatedDate=DateTime.Now
                        }
                    });
                }
                if (!context.Category.Any())
                {
                    context.Category.AddRange(new[]
                {
                        new Category
                        {
                                Name = "Web Developer",
                                CreatedDate=DateTime.Now
                        },
                        new Category
                        {
                                Name = "Frontend Developer",
                                CreatedDate=DateTime.Now
                        },
                        new Category
                        {
                                Name = "Backend Developer",
                                CreatedDate=DateTime.Now
                        },
                        new Category
                        {
                                Name = "Designer",
                                CreatedDate=DateTime.Now
                        },
                        new Category
                        {
                                Name ="Coder",
                                CreatedDate=DateTime.Now
                        },
                        new Category
                        {
                                Name = "System Adminstration",
                                CreatedDate=DateTime.Now
                        },
                        new Category
                        {
                                Name = "Help Desk",
                                CreatedDate=DateTime.Now
                        }
                    });
                }

                //if (!context.BioSkills.Any())
                //{
                //    context.BioSkills.AddRange(new[]
                //{
                //        new BioSkills
                //        {
                //                SkillLeve = 77,
                //                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                //                SkillDescription = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                //                AsBar = true,
                //                AsTag =false,
                //                CategoryId=1,
                //                SkillsId=1,
                //                CreatedDate=DateTime.Now
                //        },
                //        new BioSkills
                //        {
                //                SkillLeve = 86,
                //                SkillDescription = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                //                AsBar = true,
                //                AsTag =false,
                //                CategoryId=2,
                //                SkillsId=3,
                //                CreatedDate=DateTime.Now
                //        },
                //        new BioSkills
                //        {
                //                AsBar = false,
                //                AsTag =true,
                //                CategoryId=1,
                //                SkillsId=1,
                //                CreatedDate=DateTime.Now
                //        },
                //        new BioSkills
                //        {
                //                AsBar = false,
                //                AsTag =true,
                //                CategoryId=5,
                //                SkillsId=5,
                //                CreatedDate=DateTime.Now
                //        }
                //    });
                //}



                //if (!context.ProfessionalExperience.Any())
                //{
                //    context.ProfessionalExperience.AddRange(new[]
                //{
                //        new ProfessionalExperience
                //        {
                //                Duration="2013-2014",
                //                JobTitle="Esger",
                //                CompanyName="Milli Ordu",
                //                Location="Naxcivan.Sahbuz",
                //                Details="Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                //                CreatedDate=DateTime.Now
                //        },
                //         new ProfessionalExperience
                //        {
                //                Duration="2015-2016",
                //                JobTitle="Operator",
                //                CompanyName="Avrora MMC",
                //                Location="Baki.Hokmeli",
                //                Details="Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                //                CreatedDate=DateTime.Now
                //        }
                //    });
                //}


                //if (!context.AAcademicBackgroundca.Any())
                //{
                //    context.AAcademicBackgroundca.AddRange(new[]
                //{
                //        new AcademicBackground
                //        {
                //                Qualification="Senayenin teskili ve idare olunmasi",
                //                Degree="Bachelor",
                //                UniversityName="Iqtisad Universiteti",
                //                YearOfObtention="2008-2013",
                //                Details="Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. ",
                //                CreatedDate=DateTime.Now
                //        },
                //         new AcademicBackground
                //        {
                //                Qualification="Proqramlasdirma",
                //                Degree="Student",
                //                UniversityName="Code Academy",
                //                YearOfObtention="2018-2019",
                //                Details="Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. ",
                //                CreatedDate=DateTime.Now
                //        }
                //    });
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}

