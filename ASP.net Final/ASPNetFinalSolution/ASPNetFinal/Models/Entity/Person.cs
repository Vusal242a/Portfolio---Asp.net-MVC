using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNetFinal.Models.Entity
{
    public class Person: BaseEntity
    {
        public string Image { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public int? Age { get; set; }
        [StringLength(100)]
        public string Location { get; set; }
        [StringLength(30)]
        public string Experience { get; set; }
        [StringLength(50)]
        public string Degree { get; set; }
        [StringLength(100)]
        public string CareerLevel { get; set; }
        [Required]
        [StringLength(25)]
        public string Phone { get; set; }
        [StringLength(25)]
        public string Fax { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Website { get; set; }
    }
}