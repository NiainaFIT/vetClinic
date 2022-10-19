using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class ServiceMeasure
    {
        public ServiceMeasure()
        {
            Services = new HashSet<Service>();
        }

        public int ServiceMeasureId { get; set; }
        public string MeasureName { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int? ModifiedByUserId { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}
