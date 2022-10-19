using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class ClientAnimal
    {
        public int ClientAnimalId { get; set; }
        public int ClientId { get; set; }
        public int AnimalId { get; set; }
        public string? AnimalIdcardNo { get; set; }
        public bool? IsCurrentOwner { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int? ModifiedByUserId { get; set; }

        public virtual Animal Animal { get; set; } = null!;
        public virtual Client Client { get; set; } = null!;
    }
}
