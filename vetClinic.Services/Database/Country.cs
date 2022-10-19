using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class Country
    {
        public Country()
        {
            Cities = new HashSet<City>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public bool IsActive { get; set; }
        public int? ModifiedByUserId { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
