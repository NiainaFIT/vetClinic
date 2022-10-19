using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class AnimalTreatement
    {
        public AnimalTreatement()
        {
            Notes = new HashSet<Note>();
            TreatementServices = new HashSet<TreatementService>();
        }

        public int AnimalTreatementId { get; set; }
        public string Description { get; set; } = null!;
        public int AnimalId { get; set; }
        public bool? IsPayed { get; set; }
        public decimal? TotalPrice { get; set; }
        public int? UserId { get; set; }
        public int? AppointementId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int? ModifiedByUserId { get; set; }

        public virtual Animal Animal { get; set; } = null!;
        public virtual Appointement? Appointement { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<TreatementService> TreatementServices { get; set; }
    }
}
