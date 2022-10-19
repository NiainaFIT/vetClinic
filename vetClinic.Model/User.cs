using System;
using System.Collections.Generic;

namespace vetClinic.Model
{
    public partial class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Jmbg { get; set; }
        public string Email { get; set; }
        public string CellPhone { get; set; }
        public string Username { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime? DateDeactivated { get; set; }
        public int? ModifiedByUserId { get; set; }

        //public virtual ICollection<AnimalTreatement> AnimalTreatements { get; set; }
        //public virtual ICollection<OrderInvoice> OrderInvoices { get; set; }
        //public virtual ICollection<Purchase> Purchases { get; set; }
        //public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
