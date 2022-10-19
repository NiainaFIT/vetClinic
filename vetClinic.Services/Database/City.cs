using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class City
    {
        public City()
        {
            Clients = new HashSet<Client>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; } = null!;
        public bool IsActive { get; set; }
        public int CountryId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int? ModifiedByUserId { get; set; }

        public virtual Country Country { get; set; } = null!;
        public virtual ICollection<Client> Clients { get; set; }
    }
}
