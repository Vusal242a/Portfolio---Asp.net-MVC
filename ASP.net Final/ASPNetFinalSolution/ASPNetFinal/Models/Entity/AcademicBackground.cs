using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNetFinal.Models.Entity
{
    public class AcademicBackground:BaseEntity
    {
        public string Image { get; set; }
        [StringLength(150)]
        public string Qualification { get; set; }
        [StringLength(150)]
        public string Degree { get; set; }
        [StringLength(100)]
        public string UniversityName { get; set; }
        [StringLength(100)]
        public string YearOfObtention { get; set; }
        [StringLength(500)]
        public string Details { get; set; }
    }
}