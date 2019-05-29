using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNetFinal.Models.Entity
{
    public class ProfessionalExperience:BaseEntity
    {
        public string Image { get; set; }
        [StringLength(10)]
        public string Duration { get; set; }
        [StringLength(150)]
        public string JobTitle { get; set; }
        [StringLength(100)]
        public string CompanyName { get; set; }
        [StringLength(100)]
        public string Location { get; set; }
        [StringLength(500)]
        public string Details { get; set; }
    }
}