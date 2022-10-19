using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class User
    {
        public User()
        {
            AnimalTreatements = new HashSet<AnimalTreatement>();
            OrderInvoices = new HashSet<OrderInvoice>();
            Purchases = new HashSet<Purchase>();
            UserRoles = new HashSet<UserRole>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Jmbg { get; set; }
        public string Email { get; set; } = null!;
        public string? CellPhone { get; set; }
        public string Username { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string PasswordSalt { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime? DateDeactivated { get; set; }
        public int? ModifiedByUserId { get; set; }

        public virtual ICollection<AnimalTreatement> AnimalTreatements { get; set; }
        public virtual ICollection<OrderInvoice> OrderInvoices { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
