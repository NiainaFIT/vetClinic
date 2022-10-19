using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class Microchip
    {
        public Microchip()
        {
            AnimalMicrochips = new HashSet<AnimalMicrochip>();
        }

        public int MicrochipId { get; set; }
        public string? BatchSerialNumber { get; set; }
        public string Code { get; set; } = null!;
        public bool IsBuiltIn { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int? EditedByUserId { get; set; }

        public virtual ICollection<AnimalMicrochip> AnimalMicrochips { get; set; }
    }
}
