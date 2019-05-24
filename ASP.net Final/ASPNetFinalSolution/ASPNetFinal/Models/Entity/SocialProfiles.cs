using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNetFinal.Models.Entity
{
    public class SocialProfiles:BaseEntity
    {
        [StringLength(100)]
        public string Facebook { get; set; }
        [StringLength(100)]
        public string Twitter { get; set; }
        [StringLength(100)]
        public string Google { get; set; }
        [StringLength(100)]
        public string LinkedIn { get; set; }
        [StringLength(100)]
        public string Dribble { get; set; }
        [StringLength(100)]
        public string Behance { get; set; }
        [StringLength(100)]
        public string Stumbleupon { get; set; }
    }
}