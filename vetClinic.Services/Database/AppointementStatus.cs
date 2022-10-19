using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class AppointementStatus
    {
        public AppointementStatus()
        {
            Appointements = new HashSet<Appointement>();
        }

        public int AppointementStatusId { get; set; }
        public string StatusName { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int? EditedByUserId { get; set; }

        public virtual ICollection<Appointement> Appointements { get; set; }
    }
}
