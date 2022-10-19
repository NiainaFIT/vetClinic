using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class Animal
    {
        public Animal()
        {
            AnimalImages = new HashSet<AnimalImage>();
            AnimalMicrochips = new HashSet<AnimalMicrochip>();
            AnimalTreatements = new HashSet<AnimalTreatement>();
            ClientAnimals = new HashSet<ClientAnimal>();
        }

        public int AnimalId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; }
        public string? AnimalNote { get; set; }
        public string Sex { get; set; } = null!;
        public string IsSterilized { get; set; } = null!;
        public string IsAlive { get; set; } = null!;
        public string IsDangerous { get; set; } = null!;
        public string? DangerousExplaned { get; set; }
        public DateTime? DateOfDeath { get; set; }
        public string Description { get; set; } = null!;
        public int BreedId { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int? ModifiedByUserId { get; set; }

        public virtual Breed Breed { get; set; } = null!;
        public virtual ICollection<AnimalImage> AnimalImages { get; set; }
        public virtual ICollection<AnimalMicrochip> AnimalMicrochips { get; set; }
        public virtual ICollection<AnimalTreatement> AnimalTreatements { get; set; }
        public virtual ICollection<ClientAnimal> ClientAnimals { get; set; }
    }
}
