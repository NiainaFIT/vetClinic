using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class AnimalMicrochip
    {
        public int AnimalMicrochipId { get; set; }
        public int MicrochipId { get; set; }
        public int AnimalId { get; set; }
        public bool? IsExternalMicrochip { get; set; }
        public string? ExternalMicrochipNumber { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int? ModifiedByUserId { get; set; }

        public virtual Animal Animal { get; set; } = null!;
        public virtual Microchip Microchip { get; set; } = null!;
    }
}
