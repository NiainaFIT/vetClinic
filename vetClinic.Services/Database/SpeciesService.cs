using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class SpeciesService
    {
        public int SpeciesServiceId { get; set; }
        public int SpecieId { get; set; }
        public int ServiceId { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int? ModifiedByUserId { get; set; }

        public virtual Service Service { get; set; } = null!;
        public virtual Specie Specie { get; set; } = null!;
    }
}
