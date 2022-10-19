using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class TreatementService
    {
        public int TreatementServiceId { get; set; }
        public int ServiceId { get; set; }
        public int AnimalTreatementId { get; set; }
        public int? Quantity { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int? ModifiedByUserId { get; set; }

        public virtual AnimalTreatement AnimalTreatement { get; set; } = null!;
        public virtual Service Service { get; set; } = null!;
    }
}
