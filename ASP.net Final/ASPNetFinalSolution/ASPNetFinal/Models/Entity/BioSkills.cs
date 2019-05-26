using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNetFinal.Models.Entity
{
    public class BioSkills:BaseEntity
    {
        [StringLength(500)]
        public string Description { get; set; }
        public int SkillLeve { get; set; }
        [StringLength(500)]
        public string SkillDescription { get; set; }
        public bool AsBar { get; set; }
        public bool AsTag { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int SkillsId { get; set; }
        public virtual Skills Skills { get; set; }
    }
}