﻿using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class Role
    {
        public Role()
        {
            UserRoles = new HashSet<UserRole>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateDeactivated { get; set; }
        public int? ModifiedByUserId { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
