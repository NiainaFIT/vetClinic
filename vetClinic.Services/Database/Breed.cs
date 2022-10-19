using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class Breed
    {
        public Breed()
        {
            Animals = new HashSet<Animal>();
        }

        public int BreedId { get; set; }
        public string BreedName { get; set; } = null!;
        public int SpeciesId { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int? ModifiedByUserId { get; set; }

        public virtual Specie Species { get; set; } = null!;
        public virtual ICollection<Animal> Animals { get; set; }
    }
}
