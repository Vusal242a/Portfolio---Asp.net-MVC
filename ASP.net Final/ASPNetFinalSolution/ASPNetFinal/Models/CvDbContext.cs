using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPNetFinal.Models
{
    public class CvDbContext: DbContext
    {
        public CvDbContext()
            :base ("name=cString")
        {

        }
        public DbSet<Person> Person { get; set; }
    }
}