using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class Appointement
    {
        public Appointement()
        {
            AnimalTreatements = new HashSet<AnimalTreatement>();
        }

        public int AppointementId { get; set; }
        public DateTime DateTimeStart { get; set; }
        public DateTime? DateTimeEnd { get; set; }
        public int? VetId { get; set; }
        public int AnimalId { get; set; }
        public int AppointemenStatusId { get; set; }
        public int? UserId { get; set; }
        public int? ClientId { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int? ModifiedByUserId { get; set; }

        public virtual AppointementStatus AppointemenStatus { get; set; } = null!;
        public virtual ICollection<AnimalTreatement> AnimalTreatements { get; set; }
    }
}
