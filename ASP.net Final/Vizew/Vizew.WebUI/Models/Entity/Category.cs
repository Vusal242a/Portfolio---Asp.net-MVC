using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vizew.WebUI.Models.Entity
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<News> News { get; set; }

        [VizewDatabaseGenerated(DatabaseGeneratedOption.Computed, DefaultValueSql = "getdate()")]
        public DateTime CreationDate { get; set; }
        /*
         enable-migrations
         add-migration
         update-database
         */
    }
}