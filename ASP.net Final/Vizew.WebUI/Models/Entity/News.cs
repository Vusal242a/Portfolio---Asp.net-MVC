using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vizew.WebUI.Models.Entity
{
    public class News
    {
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Title { get; set; }
        public string Body { get; set; }
        public string MediaUrl { get; set; }
        [StringLength(70)]
        public string Author { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        [VizewSqlDefaultValue(DefaultValueSql = "1")]
        public bool IsPopular { get; set; }

        [VizewDatabaseGenerated(DatabaseGeneratedOption.Computed, DefaultValueSql = "getdate()")]
        public DateTime CreationDate { get; set; }
    }
}