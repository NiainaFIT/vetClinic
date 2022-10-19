using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class Client
    {
        public Client()
        {
            ClientAnimals = new HashSet<ClientAnimal>();
            Orders = new HashSet<Order>();
            Reviews = new HashSet<Review>();
        }

        public int ClientId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Jmbg { get; set; }
        public string? IdcardNumber { get; set; }
        public string? Address { get; set; }
        public string? Ppt { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Note { get; set; }
        public int? CityId { get; set; }
        public string Username { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string PasswordSalt { get; set; } = null!;
        public bool IsRegisteredOnline { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int? ModifiedByUserId { get; set; }

        public virtual City? City { get; set; }
        public virtual ICollection<ClientAnimal> ClientAnimals { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
