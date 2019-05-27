namespace Vizew.WebUI.Migrations
{
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using Vizew.WebUI.Models;
    using Vizew.WebUI.Models.Entity;

    internal sealed class Configuration : DbMigrationsConfiguration<VizewDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            SetSqlGenerator("System.Data.SqlClient", new VizewSqlServerMigrationSqlGenerator());
        }

        protected override void Seed(VizewDbContext context)
        {
            try
            {
                if (!context.Category.Any())
                {
                    context.Category.AddRange(new[] {
                    new Category{
                        Name="Sports",
                        IsActive=true
                    },
                    new Category{
                        Name="Game",
                        IsActive=true
                    },
                    new Category{
                        Name="Business",
                        IsActive=true
                    }
                });
                }

                //if (!context.News.Any())
                //{
                //    context.News.AddRange(new[] {
                //        new News{
                //            Title="Sports"
                //        },
                //        new News{
                //            Title="Game"
                //        },
                //        new News{
                //            Title="Business"
                //        }
                //    });
                //}


                context.SaveChanges();
            }
            catch (System.Exception ex)
            {
                while (ex.InnerException!=null)
                    ex = ex.InnerException;


                File.AppendAllText(@"F:\error.log",ex.ToString());
            }
        }
    }
}
