using System;
using System.Collections.Generic;

namespace AirsoftRUs.Models
{
    public partial class AirsoftAmmoMaterial
    {
        public AirsoftAmmoMaterial()
        {
            AirsoftAmmoTypes = new HashSet<AirsoftAmmoType>();
        }

        public int AmmoMaterialId { get; set; }
        public string? Material { get; set; }

        public virtual ICollection<AirsoftAmmoType> AirsoftAmmoTypes { get; set; }
    }
}
