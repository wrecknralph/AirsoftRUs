using System;
using System.Collections.Generic;

namespace AirsoftRUs.Models
{
    public partial class AirsoftLocation
    {
        public AirsoftLocation()
        {
            AirsoftLocationAndRules = new HashSet<AirsoftLocationAndRule>();
        }

        public int LocationId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }

        public virtual ICollection<AirsoftLocationAndRule> AirsoftLocationAndRules { get; set; }
    }
}
