using System;
using System.Collections.Generic;

namespace AirsoftRUs.Models
{
    public partial class AirsoftGear
    {
        public int GearId { get; set; }
        public int? GearTypeId { get; set; }

        public virtual AirsoftGearType? GearType { get; set; }
    }
}
