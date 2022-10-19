using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class Specie
    {
        public Specie()
        {
            Breeds = new HashSet<Breed>();
            SpeciesServices = new HashSet<SpeciesService>();
        }

        public int SpecieId { get; set; }
        public string SpecieName { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int? ModifiedByUserId { get; set; }

        public virtual ICollection<Breed> Breeds { get; set; }
        public virtual ICollection<SpeciesService> SpeciesServices { get; set; }
    }
}
