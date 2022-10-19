using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class Service
    {
        public Service()
        {
            SpeciesServices = new HashSet<SpeciesService>();
            TreatementServices = new HashSet<TreatementService>();
        }

        public int ServiceId { get; set; }
        public string ServiceCode { get; set; } = null!;
        public string ServiceName { get; set; } = null!;
        public int ServiceTypeId { get; set; }
        public int ServiceMeasureId { get; set; }
        public decimal? Price { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int? ModifiedByUserId { get; set; }

        public virtual ServiceMeasure ServiceMeasure { get; set; } = null!;
        public virtual ServiceType ServiceType { get; set; } = null!;
        public virtual ICollection<SpeciesService> SpeciesServices { get; set; }
        public virtual ICollection<TreatementService> TreatementServices { get; set; }
    }
}
